// ============================================
// 2. EMPLOYEE & TEAM
// ============================================

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Employee
{
    [Key]
    public int EmployeeId { get; set; }

    public int UserId { get; set; }

    [Required]
    [MaxLength(100)]
    public string FullName { get; set; }

    [Required]
    [MaxLength(100)]
    [EmailAddress]
    public string Email { get; set; }

    [MaxLength(20)]
    public string PhoneNumber { get; set; }  // ⭐ CHANGED: Phone → PhoneNumber

    [MaxLength(100)]
    public string Location { get; set; }

    public int? TeamId { get; set; }

    [MaxLength(100)]
    public string Designation { get; set; }

    [MaxLength(20)]
    public string AvailabilityStatus { get; set; } = "Available"; // Available, Limited, Not Available

    [Column(TypeName = "decimal(4,2)")]
    public decimal YearsOfExperience { get; set; }  // ⭐ CHANGED: int → decimal(4,2)

    public DateTime? JoiningDate { get; set; }

    [MaxLength(500)]
    public string? PhotoUrl { get; set; }

    [MaxLength(500)]
    public string? ResumeUrl { get; set; }

    public DateTime? LastResumeUpdate { get; set; }

    public bool IsVectorIndexed { get; set; } = false;
    public DateTime? VectorIndexedDate { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    // Navigation Properties
    public User User { get; set; }
    public Team Team { get; set; }
    public ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    public ICollection<EmployeeProject> EmployeeProjects { get; set; }
    public ICollection<Application> Applications { get; set; }
    public ICollection<Notification> Notifications { get; set; }
    public ICollection<SearchHistory> SearchHistories { get; set; }
    public ICollection<Requirement> PostedRequirements { get; set; }
    public ICollection<LearningRecommendation> LearningRecommendations { get; set; }
}

