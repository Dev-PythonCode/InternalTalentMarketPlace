// ============================================
// 4. EMPLOYEE SKILLS & PROJECTS
// ============================================

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class EmployeeSkill
{
    public int EmployeeSkillId { get; set; }

    public int EmployeeId { get; set; }
    public int SkillId { get; set; }

    [Column(TypeName = "decimal(4,2)")]
    public decimal YearsOfExperience { get; set; }

    [MaxLength(20)]
    public string ProficiencyLevel { get; set; } // Beginner, Intermediate, Advanced, Expert

    public DateTime? LastUsedDate { get; set; }

    [MaxLength(20)]
    public string Source { get; set; } = "Manual"; // Manual, Auto, Verified

    public bool IsVerified { get; set; } = false;

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    // Navigation
    public Employee Employee { get; set; }
    public Skill Skill { get; set; }
}
