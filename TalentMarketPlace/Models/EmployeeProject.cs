using System.ComponentModel.DataAnnotations;

public class EmployeeProject
{
    [Key]
    public int ProjectId { get; set; }

    public int EmployeeId { get; set; }

    [Required]
    [MaxLength(200)]
    public string ProjectName { get; set; }

    [MaxLength(1000)]
    public string Description { get; set; }

    [MaxLength(100)]
    public string Role { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    [MaxLength(200)]
    public string Client { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    // Navigation
    public Employee Employee { get; set; }
    public ICollection<ProjectSkill> ProjectSkills { get; set; }
}
