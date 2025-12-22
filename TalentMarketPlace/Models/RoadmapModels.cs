using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TalentMarketPlace.Models
{
    public class RoadmapResponse
    {
        [JsonPropertyName("original_prompt")]
        public string? OriginalPrompt { get; set; }

        [JsonPropertyName("matched_profile")]
        public string? MatchedProfile { get; set; }

        [JsonPropertyName("recommended_skills")]
        public List<string>? RecommendedSkills { get; set; }

        [JsonPropertyName("optional_skills")]
        public List<string>? OptionalSkills { get; set; }

        [JsonPropertyName("mandatory_skills_count")]
        public int? MandatorySkillsCount { get; set; }

        [JsonPropertyName("optional_skills_count")]
        public int? OptionalSkillsCount { get; set; }

        [JsonPropertyName("learning_path")]
        public List<string>? LearningPath { get; set; }

        [JsonPropertyName("projects")]
        public List<string>? Projects { get; set; }

        [JsonPropertyName("timeline_weeks")]
        public int? TimelineWeeks { get; set; }

        [JsonPropertyName("effort_per_week")]
        public string? EffortPerWeek { get; set; }

        [JsonPropertyName("prerequisite_skills")]
        public List<string>? PrerequisiteSkills { get; set; }

        [JsonPropertyName("career_path")]
        public string? CareerPath { get; set; }

        [JsonPropertyName("job_market")]
        public string? JobMarket { get; set; }

        [JsonPropertyName("salary_range_usd")]
        public string? SalaryRangeUsd { get; set; }

        [JsonPropertyName("notes")]
        public string? Notes { get; set; }

        [JsonPropertyName("parsed")]
        public ParsedData? Parsed { get; set; }

        [JsonPropertyName("applied_filters")]
        public List<string>? AppliedFilters { get; set; }

        [JsonPropertyName("skills_found")]
        public int? SkillsFound { get; set; }
    }

    public class ParsedData
    {
        public List<string> Skills { get; set; } = new();
        
        [JsonPropertyName("optional_skills")]
        public List<string> OptionalSkills { get; set; } = new();
        
        public List<string> Categories { get; set; } = new();
        
        [JsonPropertyName("category_skills")]
        public List<string> CategorySkills { get; set; } = new();

        [JsonPropertyName("min_years_experience")]
        public int? MinYearsExperience { get; set; }

        [JsonPropertyName("max_years_experience")]
        public int? MaxYearsExperience { get; set; }

        [JsonPropertyName("experience_operator")]
        public string? ExperienceOperator { get; set; }

        [JsonPropertyName("experience_context")]
        public object? ExperienceContext { get; set; }

        [JsonPropertyName("skill_requirements")]
        public List<object>? SkillRequirements { get; set; }

        public string? Location { get; set; }
        public List<string> Locations { get; set; } = new();

        [JsonPropertyName("availability_status")]
        public AvailabilityStatus? AvailabilityStatus { get; set; }

        [JsonPropertyName("skill_levels")]
        public List<string> SkillLevels { get; set; } = new();

        public List<string> Roles { get; set; } = new();
        public List<string> Certifications { get; set; } = new();
        public List<string> Companies { get; set; } = new();
        public List<string> Dates { get; set; } = new();
    }

    public class SkillsResponse
    {
        [JsonPropertyName("total_skills")]
        public int? TotalSkills { get; set; }

        [JsonPropertyName("skills")]
        public List<string>? Skills { get; set; }

        [JsonPropertyName("categories")]
        public List<string>? Categories { get; set; }
    }
}
