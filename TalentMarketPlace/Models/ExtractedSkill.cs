// ExtractedSkill.cs
// Temporary model for holding skills extracted from resume parsing

using System;

/// <summary>
/// Represents a skill extracted from a resume by the Python API
/// </summary>
public class ExtractedSkill
{
    public string SkillName { get; set; } = string.Empty;

    public decimal? YearsOfExperience { get; set; }

    public string? ProficiencyLevel { get; set; }

    /// <summary>
    /// Confidence score from AI parsing (0.0 to 1.0)
    /// </summary>
    public decimal ConfidenceScore { get; set; } = 0.0m;

    public DateTime? LastUsedDate { get; set; }

    /// <summary>
    /// Source of extraction (e.g., "Resume", "Auto")
    /// </summary>
    public string Source { get; set; } = "Auto";
}

