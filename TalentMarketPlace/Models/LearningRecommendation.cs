using System.ComponentModel.DataAnnotations;

public class LearningRecommendation
{
    [Key]
    public int RecommendationId { get; set; }

    public int EmployeeId { get; set; }
    public int ResourceId { get; set; }
    public int? RequirementId { get; set; }

    [MaxLength(500)]
    public string Reason { get; set; }

    [MaxLength(20)]
    public string Priority { get; set; } = "Medium"; // High, Medium, Low

    public bool IsCompleted { get; set; } = false;

    public DateTime RecommendedDate { get; set; } = DateTime.UtcNow;
    public DateTime? CompletedDate { get; set; }

    // Navigation
    public Employee Employee { get; set; }
    public LearningResource Resource { get; set; }
    public Requirement Requirement { get; set; }
}
