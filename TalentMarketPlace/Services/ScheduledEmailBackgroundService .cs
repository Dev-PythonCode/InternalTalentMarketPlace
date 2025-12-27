using Microsoft.EntityFrameworkCore;
using System;
using TalentMarketPlace.Data;
using TalentMarketPlace.Services.Interfaces;

namespace TalentMarketPlace.Services
{
    /// <summary>
    /// Background service that checks for scheduled emails and sends them
    /// Runs every minute to check for pending emails
    /// </summary>
    public class ScheduledEmailBackgroundService : BackgroundService
    {
        private readonly ILogger<ScheduledEmailBackgroundService> _logger;
        private readonly IServiceProvider _serviceProvider;

        public ScheduledEmailBackgroundService(
            ILogger<ScheduledEmailBackgroundService> logger,
            IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Scheduled Email Background Service started.");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    await ProcessScheduledEmails(stoppingToken);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error processing scheduled emails");
                }

                // Check every minute
                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }

            _logger.LogInformation("Scheduled Email Background Service stopped.");
        }

        private async Task ProcessScheduledEmails(CancellationToken stoppingToken)
        {
            using var scope = _serviceProvider.CreateScope();
            var scheduledEmailService = scope.ServiceProvider.GetRequiredService<IScheduledEmailService>();

            var pendingEmails = await scheduledEmailService.GetPendingEmailsAsync();

            if (pendingEmails.Any())
            {
                _logger.LogInformation($"Found {pendingEmails.Count} scheduled emails to process");

                foreach (var scheduledEmail in pendingEmails)
                {
                    if (stoppingToken.IsCancellationRequested)
                        break;

                    try
                    {
                        await scheduledEmailService.SendScheduledEmailAsync(scheduledEmail.Id);
                        _logger.LogInformation($"Sent scheduled email ID: {scheduledEmail.Id}");
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, $"Failed to send scheduled email ID: {scheduledEmail.Id}");
                    }
                }
            }
        }
    }

}
