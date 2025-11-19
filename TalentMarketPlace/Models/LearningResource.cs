// ============================================
// 7. LEARNING & RECOMMENDATIONS
// ============================================

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class LearningResource
{
    public int ResourceId { get; set; }

    public int SkillId { get; set; }

    [Required]
    [MaxLength(200)]
    public string ResourceTitle { get; set; }

    [MaxLength(100)]
    public string Provider { get; set; } // Udemy, Coursera, LinkedIn Learning

    [MaxLength(500)]
    public string ResourceUrl { get; set; }

    [MaxLength(50)]
    public string ResourceType { get; set; } // Course, Tutorial, Book, Documentation

    public int DurationHours { get; set; }

    [MaxLength(20)]
    public string Level { get; set; } // Beginner, Intermediate, Advanced

    [Column(TypeName = "decimal(3,2)")]
    public decimal? Rating { get; set; }

    public bool IsActive { get; set; } = true;

    // Navigation
    public Skill Skill { get; set; }
    public ICollection<LearningRecommendation> LearningRecommendations { get; set; }
}
