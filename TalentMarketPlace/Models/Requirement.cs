using System.ComponentModel.DataAnnotations;

public class Requirement
{
    public int RequirementId { get; set; }
    
    [Required]
    [MaxLength(200)]
    public string Title { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(2000)]
    public string Description { get; set; } = string.Empty;
    
    public int PostedById { get; set; }
    public int? TeamId { get; set; }
    
    [Required]  // ← ADD THIS
    [MaxLength(100)]
    public string Location { get; set; } = "Bangalore";  // ← ADD DEFAULT
    
    [Required]  // ← ADD THIS
    [MaxLength(50)]
    public string Duration { get; set; } = "Permanent";
    
    public DateTime? StartDate { get; set; }
    
    [Required]  // ← ADD THIS
    [MaxLength(20)]
    public string Priority { get; set; } = "Medium";
    
    [Required]  // ← ADD THIS
    [MaxLength(20)]
    public string Status { get; set; } = "Open";
    
    public int ViewCount { get; set; } = 0;
    public int ApplicationCount { get; set; } = 0;
    public DateTime PostedDate { get; set; } = DateTime.UtcNow;
    public DateTime? ExpiryDate { get; set; }
    public bool IsActive { get; set; } = true;
    
    // Navigation
    public Employee PostedBy { get; set; } = null!;
    public Team? Team { get; set; }
    public ICollection<RequirementSkill> RequirementSkills { get; set; } = new List<RequirementSkill>();
    public ICollection<Application> Applications { get; set; } = new List<Application>();
    public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
    public ICollection<LearningRecommendation> LearningRecommendations { get; set; } = new List<LearningRecommendation>();
}