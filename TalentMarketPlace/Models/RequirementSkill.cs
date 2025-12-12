using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class RequirementSkill
{
    public int RequirementSkillId { get; set; }
    public int RequirementId { get; set; }
    public int SkillId { get; set; }
    
    [Column(TypeName = "decimal(4,2)")]
    public decimal MinYearsRequired { get; set; }
    
    [Required]  // ← ADD THIS
    [MaxLength(20)]
    public string ProficiencyLevel { get; set; } = "Intermediate";  // ← ADD DEFAULT
    
    public bool IsMandatory { get; set; } = true;
    public int Weightage { get; set; } = 1;
    
    // Navigation
    public Requirement Requirement { get; set; } = null!;
    public Skill Skill { get; set; } = null!;
}