// Models/PythonApiModels.cs
// Model classes for Python API responses with correct JSON property mapping

using System.Text.Json.Serialization;

namespace TalentMarketPlace.Models;

public class ParseQueryResult
{
    [JsonPropertyName("original_query")]
    public string OriginalQuery { get; set; } = string.Empty;

    [JsonPropertyName("parsed")]
    public ParsedQuery Parsed { get; set; } = new();

    [JsonPropertyName("entities_detected")]
    public EntitiesDetected? EntitiesDetected { get; set; }

    [JsonPropertyName("applied_filters")]
    public List<string> AppliedFilters { get; set; } = new();

    [JsonPropertyName("skills_found")]
    public int SkillsFound { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }
}

public class ParsedQuery
{
    [JsonPropertyName("skills")]
    public List<string> Skills { get; set; } = new();

    [JsonPropertyName("categories")]
    public List<string> Categories { get; set; } = new();

    [JsonPropertyName("category_skills")]
    public List<string> CategorySkills { get; set; } = new();

    [JsonPropertyName("min_years_experience")]
    public decimal? MinYearsExperience { get; set; }

    [JsonPropertyName("max_years_experience")]
    public decimal? MaxYearsExperience { get; set; }

    [JsonPropertyName("experience_operator")]
    public string ExperienceOperator { get; set; } = "gte";

    [JsonPropertyName("experience_context")]
    public ExperienceContext? ExperienceContext { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("availability_status")]
    public string? AvailabilityStatus { get; set; }

    [JsonPropertyName("skill_levels")]
    public List<string> SkillLevels { get; set; } = new();

    [JsonPropertyName("roles")]
    public List<string> Roles { get; set; } = new();

    [JsonPropertyName("certifications")]
    public List<string> Certifications { get; set; } = new();

    [JsonPropertyName("companies")]
    public List<string> Companies { get; set; } = new();

    [JsonPropertyName("dates")]
    public List<string> Dates { get; set; } = new();

    [JsonPropertyName("skill_requirements")]
    public List<SkillRequirement>? SkillRequirements { get; set; }
}

public class ExperienceContext
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    [JsonPropertyName("skill")]
    public string? Skill { get; set; }

    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

public class SkillRequirement
{
    [JsonPropertyName("skill")]
    public string Skill { get; set; } = string.Empty;

    [JsonPropertyName("min_years")]
    public decimal? MinYears { get; set; }

    [JsonPropertyName("max_years")]
    public decimal? MaxYears { get; set; }

    [JsonPropertyName("operator")]
    public string Operator { get; set; } = "gte";

    [JsonPropertyName("experience_type")]
    public string ExperienceType { get; set; } = string.Empty;
}

public class EntitiesDetected
{
    [JsonPropertyName("skills")]
    public List<string> Skills { get; set; } = new();

    [JsonPropertyName("categories")]
    public List<string> Categories { get; set; } = new();

    [JsonPropertyName("tech_experiences")]
    public List<string> TechExperiences { get; set; } = new();

    [JsonPropertyName("overall_experiences")]
    public List<string> OverallExperiences { get; set; } = new();

    [JsonPropertyName("roles")]
    public List<string> Roles { get; set; } = new();

    [JsonPropertyName("skill_levels")]
    public List<string> SkillLevels { get; set; } = new();

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("certifications")]
    public List<string> Certifications { get; set; } = new();

    [JsonPropertyName("companies")]
    public List<string> Companies { get; set; } = new();

    [JsonPropertyName("dates")]
    public List<string> Dates { get; set; } = new();
}

public class ChatSearchResponse
{
    [JsonPropertyName("original_query")]
    public string OriginalQuery { get; set; } = string.Empty;

    [JsonPropertyName("parsed")]
    public ParsedQuery Parsed { get; set; } = new();

    [JsonPropertyName("results")]
    public List<ChatSearchEmployee> Results { get; set; } = new();

    [JsonPropertyName("total_results")]
    public int TotalResults { get; set; }

    [JsonPropertyName("search_method")]
    public string SearchMethod { get; set; } = string.Empty;

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }
}

public class ChatSearchEmployee
{
    [JsonPropertyName("employee_id")]
    public int EmployeeId { get; set; }

    [JsonPropertyName("full_name")]
    public string FullName { get; set; } = string.Empty;

    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;

    [JsonPropertyName("designation")]
    public string Designation { get; set; } = string.Empty;

    [JsonPropertyName("location")]
    public string Location { get; set; } = string.Empty;

    [JsonPropertyName("years_of_experience")]
    public decimal YearsOfExperience { get; set; }

    [JsonPropertyName("availability_status")]
    public string AvailabilityStatus { get; set; } = string.Empty;

    [JsonPropertyName("match_percentage")]
    public decimal MatchPercentage { get; set; }

    [JsonPropertyName("skills")]
    public List<ChatSearchSkill> Skills { get; set; } = new();
}

public class ChatSearchSkill
{
    [JsonPropertyName("skill_name")]
    public string SkillName { get; set; } = string.Empty;

    [JsonPropertyName("years_of_experience")]
    public decimal YearsOfExperience { get; set; }

    [JsonPropertyName("proficiency_level")]
    public string ProficiencyLevel { get; set; } = string.Empty;

    [JsonPropertyName("match_status")]
    public string MatchStatus { get; set; } = string.Empty;
}