using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class RequirementSkill
{
    public int RequirementSkillId { get; set; }

    public int RequirementId { get; set; }
    public int SkillId { get; set; }

    [Column(TypeName = "decimal(4,2)")]
    public decimal MinYearsRequired { get; set; }

    [MaxLength(20)]
    public string ProficiencyLevel { get; set; }

    public bool IsMandatory { get; set; } = true;

    public int Weightage { get; set; } = 1; // For match calculation

    // Navigation
    public Requirement Requirement { get; set; }
    public Skill Skill { get; set; }
}
