using System.ComponentModel.DataAnnotations;

namespace TalentMarketPlace.Models
{
   
    public class ScheduledEmail
    {
        [Key]
        public int Id { get; set; }

        // NOT NULL in DB
        [Required]
        public string Recipients { get; set; } = null!;

        [Required]
        [MaxLength(500)]
        public string Subject { get; set; } = null!;

        [Required]
        public string Body { get; set; } = null!;

        // NULLABLE in DB
        [MaxLength(500)]
        public string? CcAddress { get; set; }

        [Required]
        public DateTime ScheduledTime { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; } = null!; // Pending, Sent, Failed

        [Required]
        public DateTime CreatedDate { get; set; }

        public DateTime? SentDate { get; set; }

        [MaxLength(100)]
        public string? CreatedBy { get; set; }

        [MaxLength(1000)]
        public string? ErrorMessage { get; set; }

        public int SuccessCount { get; set; } = 0;
        public int FailedCount { get; set; } = 0;
    }
}
