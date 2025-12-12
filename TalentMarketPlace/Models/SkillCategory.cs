// ============================================
// 3. SKILLS & CATEGORIES
// ============================================

using System.ComponentModel.DataAnnotations;

public class SkillCategory
{
    [Key]
    public int CategoryId { get; set; }

    [Required]
    [MaxLength(100)]
    public string CategoryName { get; set; }

    [MaxLength(500)]
    public string? Description { get; set; }

    public int DisplayOrder { get; set; }

    // Navigation
    public ICollection<Skill> Skills { get; set; }
}
