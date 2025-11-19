using System.ComponentModel.DataAnnotations.Schema;

public class ProjectSkill
{
    public int ProjectSkillId { get; set; }

    public int ProjectId { get; set; }
    public int SkillId { get; set; }

    [Column(TypeName = "decimal(4,2)")]
    public decimal YearsUsed { get; set; }

    // Navigation
    public EmployeeProject Project { get; set; }
    public Skill Skill { get; set; }
}
