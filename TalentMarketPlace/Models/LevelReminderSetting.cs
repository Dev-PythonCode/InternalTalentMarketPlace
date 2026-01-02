using System.ComponentModel.DataAnnotations;

namespace TalentMarketPlace.Models
{
    /// <summary>
    /// Stores automated reminder settings for employee levels
    /// Ensures one setting per level (no duplicates)
    /// </summary>
    public class LevelReminderSetting
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string EmployeeLevel { get; set; } = null!; // L1, L2, L3, ... L10

        [Required]
        [MaxLength(20)]
        public string Duration { get; set; } = null!; // Monthly, Quarterly, Half Yearly, Yearly

        [Required]
        public int DefaultEmailCount { get; set; } = 1; // Number of emails to send per duration

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? LastModifiedDate { get; set; }

        [MaxLength(100)]
        public string? CreatedBy { get; set; }

        [MaxLength(100)]
        public string? ModifiedBy { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
