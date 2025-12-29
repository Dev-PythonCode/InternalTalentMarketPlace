using TalentMarketPlace.Models;

namespace TalentMarketPlace.Services.Interfaces
{
    public interface IScheduledEmailService
    {
        /// <summary>
        /// Create a scheduled email
        /// </summary>
        Task<int> CreateScheduledEmailAsync(ScheduledEmail scheduledEmail);

        /// <summary>
        /// Get pending emails that are ready to be sent
        /// </summary>
        Task<List<ScheduledEmail>> GetPendingEmailsAsync();

        /// <summary>
        /// Send a scheduled email
        /// </summary>
        Task SendScheduledEmailAsync(int scheduledEmailId);

        /// <summary>
        /// Cancel a scheduled email
        /// </summary>
        Task CancelScheduledEmailAsync(int scheduledEmailId);

        /// <summary>
        /// Get all scheduled emails
        /// </summary>
        Task<List<ScheduledEmail>> GetAllScheduledEmailsAsync();
    }
}
