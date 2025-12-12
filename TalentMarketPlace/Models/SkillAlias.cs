using System.ComponentModel.DataAnnotations;

public class SkillAlias
{
    [Key]
    public int AliasId { get; set; }

    public int SkillId { get; set; }

    [Required]
    [MaxLength(100)]
    public string AliasName { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    // Navigation
    public Skill Skill { get; set; }
}
