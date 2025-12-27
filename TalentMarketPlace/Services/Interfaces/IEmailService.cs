namespace TalentMarketPlace.Services.Interfaces
{
    public interface IEmailService
    {
        /// <summary>
        /// Send email to a single recipient
        /// </summary>
        Task SendEmailAsync(string to, string subject, string body, string cc = null);

        /// <summary>
        /// Send bulk emails to multiple recipients
        /// </summary>
        Task<EmailResult> SendBulkEmailAsync(List<Employee> recipients, string subject, string body, string cc = null);

        /// <summary>
        /// Schedule email for later delivery
        /// </summary>
        Task ScheduleEmailAsync(List<Employee> recipients, string subject, string body, string cc, DateTime scheduledTime);

        /// <summary>
        /// Get email sending history
        /// </summary>
        Task<List<EmailHistoryDto>> GetHistoryAsync();
        Task SendEmailAsync(List<string> list, string subject, string body, string ccAddress);
    }

    public class EmailResult
    {
        public int SuccessCount { get; set; }
        public int FailedCount { get; set; }
        public List<string> FailedEmails { get; set; } = new();
        public string Message { get; set; }
    }

    // DTO for displaying email history
    public class EmailHistoryDto
    {
        public int Id { get; set; }
        public DateTime SentDate { get; set; }
        public int RecipientCount { get; set; }
        public string Subject { get; set; }
        public string SentBy { get; set; }
        public string RecipientType { get; set; }
        public int SuccessCount { get; set; }
        public int FailedCount { get; set; }
    }
}
