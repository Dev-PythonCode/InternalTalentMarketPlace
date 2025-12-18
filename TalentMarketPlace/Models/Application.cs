using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Application
{
    public int ApplicationId { get; set; }

    public int RequirementId { get; set; }
    public int EmployeeId { get; set; }
    public DateTime ApplicationDate { get; set; }

    [MaxLength(2000)]
    public string? CoverLetter { get; set; }

    [Column(TypeName = "decimal(5,2)")]
    public decimal? MatchPercentage { get; set; }

    [Column(TypeName = "decimal(5,2)")]
    public decimal? AIScore { get; set; }

    [MaxLength(1000)]
    public string? AIRecommendation { get; set; }

    [MaxLength(20)]
    public string Status { get; set; } = "Pending"; // Pending, Accepted, Rejected, Shortlisted

    [MaxLength(1000)]
    public string? ManagerFeedback { get; set; }

    public DateTime AppliedDate { get; set; } = DateTime.UtcNow;
    public DateTime? ReviewedDate { get; set; }

    // Navigation
    public Requirement? Requirement { get; set; }
    public Employee? Employee { get; set; }
}

