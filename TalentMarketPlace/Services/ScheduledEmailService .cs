using Microsoft.EntityFrameworkCore;
using TalentMarketPlace.Data;
using TalentMarketPlace.Models;
using TalentMarketPlace.Services.Interfaces;

namespace TalentMarketPlace.Services
{
    public class ScheduledEmailService : IScheduledEmailService
    {
        private readonly TalentMarketplaceDbContext _context;
        private readonly IEmailService _emailService;
        private readonly IEmployeeService _employeeService;
        private readonly ILogger<ScheduledEmailService> _logger;

        public ScheduledEmailService(
            TalentMarketplaceDbContext context,
            IEmailService emailService,
            IEmployeeService employeeService,
            ILogger<ScheduledEmailService> logger)
        {
            _context = context;
            _emailService = emailService;
            _employeeService = employeeService;
            _logger = logger;
        }

        public async Task<int> CreateScheduledEmailAsync(ScheduledEmail scheduledEmail)
        {
            scheduledEmail.Status = "Pending";
            scheduledEmail.CreatedDate = DateTime.Now; // Use local time

            _context.ScheduledEmails.Add(scheduledEmail);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Scheduled email created with ID: {scheduledEmail.Id} for {scheduledEmail.ScheduledTime}");

            return scheduledEmail.Id;
        }

        public async Task<List<ScheduledEmail>> GetPendingEmailsAsync()
        {
            var now = DateTime.Now; // Use local time

            return await _context.ScheduledEmails
                .Where(e => e.Status == "Pending" && e.ScheduledTime <= now)
                .OrderBy(e => e.ScheduledTime)
                .ToListAsync();
        }

        public async Task SendScheduledEmailAsync(int scheduledEmailId)
        {
            var scheduledEmail = await _context.ScheduledEmails
                .FindAsync(scheduledEmailId);

            if (scheduledEmail == null)
            {
                _logger.LogWarning($"Scheduled email ID {scheduledEmailId} not found");
                return;
            }

            if (scheduledEmail.Status != "Pending")
            {
                _logger.LogWarning($"Scheduled email ID {scheduledEmailId} is not in Pending status");
                return;
            }

            try
            {
                // Update status to Processing
                scheduledEmail.Status = "Processing";
                await _context.SaveChangesAsync();

                // Get recipients
                var recipientEmails = scheduledEmail.Recipients
                    .Split(';', StringSplitOptions.RemoveEmptyEntries)
                    .Select(e => e.Trim())
                    .ToList();

                var allEmployees = await _employeeService.GetAllAsync();
                var recipients = allEmployees
                    .Where(e => recipientEmails.Contains(e.Email))
                    .ToList();

                if (!recipients.Any())
                {
                    throw new Exception("No valid recipients found");
                }

                // Send emails
                var result = await _emailService.SendBulkEmailAsync(
                    recipients,
                    scheduledEmail.Subject,
                    scheduledEmail.Body,
                    scheduledEmail.CcAddress
                );

                // Update status
                scheduledEmail.Status = "Sent";
                scheduledEmail.SentDate = DateTime.Now; // Use local time

                // If you haven't added SuccessCount/FailedCount columns, comment these out:
                scheduledEmail.SuccessCount = result.SuccessCount;
                scheduledEmail.FailedCount = result.FailedCount;

                _logger.LogInformation($"Scheduled email ID {scheduledEmailId} sent successfully. Success: {result.SuccessCount}, Failed: {result.FailedCount}");
            }
            catch (Exception ex)
            {
                scheduledEmail.Status = "Failed";
                scheduledEmail.ErrorMessage = ex.Message;
                _logger.LogError(ex, $"Failed to send scheduled email ID {scheduledEmailId}");
            }

            await _context.SaveChangesAsync();
        }

        public async Task CancelScheduledEmailAsync(int scheduledEmailId)
        {
            var scheduledEmail = await _context.ScheduledEmails
                .FindAsync(scheduledEmailId);

            if (scheduledEmail != null && scheduledEmail.Status == "Pending")
            {
                scheduledEmail.Status = "Cancelled";
                await _context.SaveChangesAsync();
                _logger.LogInformation($"Scheduled email ID {scheduledEmailId} cancelled");
            }
        }

        public async Task<List<ScheduledEmail>> GetAllScheduledEmailsAsync()
        {
            return await _context.ScheduledEmails
                .OrderByDescending(e => e.CreatedDate)
                .Take(50)
                .ToListAsync();
        }
    }
}
