using System.ComponentModel.DataAnnotations;

public class Skill
{
    [Key]
    public int SkillId { get; set; }

    [Required]
    [MaxLength(100)]
    public string SkillName { get; set; }

    public int CategoryId { get; set; }

    [MaxLength(500)]
    public string Description { get; set; }

    public bool IsActive { get; set; } = true;
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    // Navigation
    public SkillCategory Category { get; set; }
    public ICollection<SkillAlias> SkillAliases { get; set; }
    public ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    public ICollection<RequirementSkill> RequirementSkills { get; set; }
    public ICollection<ProjectSkill> ProjectSkills { get; set; }
    public ICollection<LearningResource> LearningResources { get; set; }
}
