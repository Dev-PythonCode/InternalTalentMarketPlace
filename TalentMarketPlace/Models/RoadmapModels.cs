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

        [JsonPropertyName("learning_path")]
        public List<string>? LearningPath { get; set; }

        [JsonPropertyName("projects")]
        public List<string>? Projects { get; set; }

        [JsonPropertyName("timeline_weeks")]
        public int? TimelineWeeks { get; set; }

        [JsonPropertyName("notes")]
        public string? Notes { get; set; }

        [JsonPropertyName("parsed")]
        public ParsedData? Parsed { get; set; }

        [JsonPropertyName("applied_filters")]
        public List<string>? AppliedFilters { get; set; }

        [JsonPropertyName("skills_found")]
        public int? SkillsFound { get; set; }
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
