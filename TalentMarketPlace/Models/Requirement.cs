// ============================================
// 5. REQUIREMENTS & APPLICATIONS
// ============================================

using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;

public class Requirement
{
    public int RequirementId { get; set; }

    [Required]
    [MaxLength(200)]
    public string Title { get; set; }

    [MaxLength(2000)]
    public string Description { get; set; }

    public int PostedById { get; set; }

    public int? TeamId { get; set; }

    [MaxLength(100)]
    public string Location { get; set; }

    [MaxLength(50)]
    public string Duration { get; set; } // 3 months, 6 months, Permanent

    public DateTime? StartDate { get; set; }

    [MaxLength(20)]
    public string Priority { get; set; } = "Medium"; // High, Medium, Low

    [MaxLength(20)]
    public string Status { get; set; } = "Open"; // Open, Closed, Filled

    public int ViewCount { get; set; } = 0;
    public int ApplicationCount { get; set; } = 0;

    public DateTime PostedDate { get; set; } = DateTime.UtcNow;
    public DateTime? ExpiryDate { get; set; }

    public bool IsActive { get; set; } = true;

    // Navigation
    public Employee PostedBy { get; set; }
    public Team Team { get; set; }
    public ICollection<RequirementSkill> RequirementSkills { get; set; }
    public ICollection<Application> Applications { get; set; }
    public ICollection<Notification> Notifications { get; set; }
    public ICollection<LearningRecommendation> LearningRecommendations { get; set; }
}
