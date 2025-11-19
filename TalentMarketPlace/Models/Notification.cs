// ============================================
// 6. NOTIFICATIONS & SEARCH
// ============================================

using System.ComponentModel.DataAnnotations;

public class Notification
{
    public int NotificationId { get; set; }

    public int EmployeeId { get; set; }
    public int? RequirementId { get; set; }

    [Required]
    [MaxLength(200)]
    public string Title { get; set; }

    [MaxLength(1000)]
    public string Message { get; set; }

    [MaxLength(50)]
    public string Type { get; set; } // NewRequirement, ApplicationUpdate, SkillMatch

    public bool IsRead { get; set; } = false;

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? ReadDate { get; set; }

    // Navigation
    public Employee Employee { get; set; }
    public Requirement Requirement { get; set; }
}
