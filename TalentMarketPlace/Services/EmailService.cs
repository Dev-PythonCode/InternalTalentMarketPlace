using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Mail;
using TalentMarketPlace.Data;
using TalentMarketPlace.Models;
using TalentMarketPlace.Services.Interfaces;

namespace TalentMarketPlace.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<EmailService> _logger;
        private readonly string _smtpHost;
        private readonly int _smtpPort;
        private readonly string _smtpUsername;
        private readonly string _smtpPassword;
        private readonly string _fromAddress;
        private readonly string _fromName;
        private TalentMarketplaceDbContext _context;
        private readonly string _emailProvider;


        public EmailService(IConfiguration configuration, ILogger<EmailService> logger, TalentMarketplaceDbContext context)
        {
            _configuration = configuration;
            _logger = logger;
            _context = context;
            // Read configuration
            _emailProvider = _configuration["Email:Provider"] ?? "Gmail";

            _smtpHost = _configuration["Email:SmtpHost"] ?? "smtp.gmail.com";
            _smtpPort = int.Parse(_configuration["Email:SmtpPort"] ?? "587");
            _smtpUsername = _configuration["Email:Username"] ?? "";
            _smtpPassword = _configuration["Email:Password"] ?? "";
            _fromAddress = _configuration["Email:FromAddress"] ?? "noreply@company.com";
            _fromName = _configuration["Email:FromName"] ?? "Skills Management System";
        }


        public async Task SendEmailAsync(
    string to,
    string subject,
    string body,
    string? cc = null)
        {
            if (_emailProvider.Equals("Org", StringComparison.OrdinalIgnoreCase))
            {
                SendUsingOrgLogic(to, subject, body, cc);
            }
            else
            {
                await SendUsingSmtpAsync(to, subject, body, cc);
            }
        }

        public async Task SendUsingSmtpAsync(string to, string subject, string body, string cc = null)
        {
            try
            {
                using var client = CreateSmtpClient();
                using var message = new MailMessage();

                message.From = new MailAddress(_fromAddress, _fromName);
                message.To.Add(to);
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = false;

                // Add CC recipients
                if (!string.IsNullOrWhiteSpace(cc))
                {
                    foreach (var ccEmail in cc.Split(';', StringSplitOptions.RemoveEmptyEntries))
                    {
                        var trimmedEmail = ccEmail.Trim();
                        if (!string.IsNullOrWhiteSpace(trimmedEmail))
                        {
                            message.CC.Add(trimmedEmail);
                        }
                    }
                }

                await client.SendMailAsync(message);
                _logger.LogInformation($"Email sent successfully to {to}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Failed to send email to {to}");
                throw;
            }
        }
        private void SendUsingOrgLogic(
    string to,
    string subject,
    string body,
    string? cc)
        {
            var mailModel = new MailMessageModel
            {
                FromAddress = _fromAddress,
                ToAddress = to,
                CCAddress = cc,
                Subject = subject,
                Body = body
            };

            SendMail(mailModel);
        }

        private bool SendMail(MailMessageModel model)
        {
            try
            {
                var mail = new MailMessage
                {
                    From = new MailAddress(model.FromAddress),
                    Subject = model.Subject,
                    Body = model.Body,
                    IsBodyHtml = true
                };

                foreach (var to in model.ToAddress.Split(',', StringSplitOptions.RemoveEmptyEntries))
                    mail.To.Add(to.Trim());

                if (!string.IsNullOrWhiteSpace(model.CCAddress))
                {
                    foreach (var cc in model.CCAddress.Split(',', StringSplitOptions.RemoveEmptyEntries))
                        mail.CC.Add(cc.Trim());
                }

              

                using var smtp = new SmtpClient("office.com", 25)
                {
                    EnableSsl = false
                };

                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Org email send failed");
                return false;
            }
        }


        public async Task<EmailResult> SendBulkEmailAsync(List<Employee> recipients, string subject, string body, string cc = null)
        {
            var result = new EmailResult();
            var successCount = 0;
            var failedCount = 0;
            var failedEmails = new List<string>();

            foreach (var employee in recipients)
            {
                try
                {
                    var personalizedBody = PersonalizeEmail(body, employee);
                    await SendEmailAsync(employee.Email, subject, personalizedBody, cc);
                    successCount++;

                    // Add small delay to avoid overwhelming SMTP server
                    if (successCount % 10 == 0)
                    {
                        await Task.Delay(1000);
                    }
                }
                catch (Exception ex)
                {
                    failedCount++;
                    failedEmails.Add(employee.Email);
                    _logger.LogError(ex, $"Failed to send email to {employee.Email}");
                }
            }

            result.SuccessCount = successCount;
            result.FailedCount = failedCount;
            result.FailedEmails = failedEmails;
            result.Message = $"Sent {successCount} emails successfully";

            if (failedCount > 0)
            {
                result.Message += $", {failedCount} failed";
            }

            // Save to history
            await SaveEmailHistoryAsync(new EmailHistory
            {
                SentDate = DateTime.Now,
                RecipientCount = recipients.Count,
                Subject = subject,
                SentBy = "Admin", // Get from authentication context
                RecipientType = recipients.Count == 1 ? "Single" : "Bulk",
                SuccessCount = successCount,
                FailedCount = failedCount
            });

            return result;
        }

        public async Task ScheduleEmailAsync(List<Employee> recipients, string subject, string body, string cc, DateTime scheduledTime)
        {
            // In a production environment, you would:
            // 1. Save this to a database table (ScheduledEmails)
            // 2. Use a background service (like Hangfire, Quartz.NET) to process scheduled emails
            // 3. Or use Azure Functions/AWS Lambda with a timer trigger

            var scheduledEmail = new ScheduledEmail
            {
                Recipients = string.Join(";", recipients.Select(r => r.Email)),
                Subject = subject,
                Body = body,
                CcAddress = cc,
                ScheduledTime = scheduledTime,
                Status = "Pending",
                CreatedDate = DateTime.Now
            };

            await _context.ScheduledEmails.AddAsync(scheduledEmail);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Email scheduled for {scheduledTime} to {recipients.Count} recipients");

            await Task.CompletedTask;
        }

        public async Task<List<EmailHistoryDto>> GetHistoryAsync()
        {
            // In production, fetch from database
            return await _context.EmailHistory
                .OrderByDescending(h => h.SentDate)
                .Take(50)
                .Select(h => new EmailHistoryDto
                {
                    Id = h.Id,
                  SentDate = h.SentDate,
                   RecipientCount = h.RecipientCount,
                   Subject = h.Subject,
                   SentBy = h.SentBy,
                  RecipientType = h.RecipientType,
                  SuccessCount = h.SuccessCount,
                   FailedCount = h.FailedCount
                 })
                .ToListAsync();

            // Mock data for demonstration
           /* return await Task.FromResult(new List<EmailHistoryDto>
            {
                new EmailHistoryDto
                {
                    Id = 1,
                    SentDate = DateTime.Now.AddDays(-7),
                    RecipientCount = 150,
                    Subject = "Q4 2024 Skills Update Reminder",
                    SuccessCount = 148,
                    FailedCount = 2
                },
                new EmailHistoryDto
                {
                    Id = 2,
                    SentDate = DateTime.Now.AddDays(-90),
                    RecipientCount = 148,
                    Subject = "Q3 2024 Skills Update Reminder",
                    SuccessCount = 148,
                    FailedCount = 0
                },
                new EmailHistoryDto
                {
                    Id = 3,
                    SentDate = DateTime.Now.AddDays(-180),
                    RecipientCount = 145,
                    Subject = "Q2 2024 Skills Update Reminder",
                    SuccessCount = 143,
                    FailedCount = 2
                }
            });*/
        }

        private SmtpClient CreateSmtpClient()
        {
            var client = new SmtpClient(_smtpHost, _smtpPort)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_smtpUsername, _smtpPassword),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Timeout = 30000 // 30 seconds
            };

            return client;
        }

        private string PersonalizeEmail(string body, Employee employee)
        {
            var quarter = GetCurrentQuarter();
            var year = DateTime.Now.Year;
            var dueDate = GetQuarterEndDate();

            var employeeName = employee.FullName ?? "Team Member";
            var designation = employee.Designation ?? "N/A";
            var location = employee.Location ?? "N/A";
            var email = employee.Email ?? "";

            return body
                .Replace("{EmployeeName}", employeeName)
                .Replace("{Email}", email)
                .Replace("{Department}", designation)
                .Replace("{Designation}", designation)
                .Replace("{Location}", location)
                .Replace("{Quarter}", $"Q{quarter}")
                .Replace("{Year}", year.ToString())
                .Replace("{DueDate}", dueDate.ToString("MMMM dd, yyyy"));
        }

        private int GetCurrentQuarter()
        {
            return (DateTime.Now.Month - 1) / 3 + 1;
        }

        private DateTime GetQuarterEndDate()
        {
            var quarter = GetCurrentQuarter();
            var year = DateTime.Now.Year;
            return quarter switch
            {
                1 => new DateTime(year, 3, 31),
                2 => new DateTime(year, 6, 30),
                3 => new DateTime(year, 9, 30),
                4 => new DateTime(year, 12, 31),
                _ => DateTime.Now.AddMonths(1)
            };
        }

        private async Task SaveEmailHistoryAsync(EmailHistory history)
        {
            // In production, save to database
             await _context.EmailHistory.AddAsync(history);
            await _context.SaveChangesAsync();

            await Task.CompletedTask;
        }

        public async Task SendEmailAsync(
        List<string> to,
        string subject,
        string body,
        string? cc)
        {
            foreach (var email in to.Where(e => !string.IsNullOrWhiteSpace(e)))
            {
                await SendEmailAsync(email, subject, body, cc);
            }
        }


    }
}
