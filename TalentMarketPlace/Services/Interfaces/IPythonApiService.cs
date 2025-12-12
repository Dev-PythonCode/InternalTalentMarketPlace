// IPythonApiService.cs
// Updated to support year ranges (e.g., 2-5 years)

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TalentMarketPlace.Services.Interfaces
{
    public interface IPythonApiService
    {
        Task<bool> IsHealthyAsync();
        Task<ParseQueryResult> ParseQueryAsync(string query);
        Task<ChatSearchResponse> ChatSearchAsync(string query);
    }

    public class ParseQueryResult
    {
        public string OriginalQuery { get; set; } = string.Empty;
        public ParsedQueryData Parsed { get; set; } = new();
        public List<string> AppliedFilters { get; set; } = new();
        public int SkillsFound { get; set; }
        public EntitiesDetected EntitiesDetected { get; set; } = new();
        public string? Error { get; set; }
        public List<VectorSearchResult>? VectorResults { get; set; }
    }

    public class ParsedQueryData
    {
        public List<string> Skills { get; set; } = new();
        public List<string> Categories { get; set; } = new();
        public List<string> CategorySkills { get; set; } = new();

        public decimal? MinYearsExperience { get; set; }
        public decimal? MaxYearsExperience { get; set; }  // ⭐ NEW for ranges!

        public string? ExperienceOperator { get; set; }
        public ExperienceContext? ExperienceContext { get; set; }

        public string? Location { get; set; }
        public string? AvailabilityStatus { get; set; }
        public List<string>? SkillLevels { get; set; }
        public List<string>? Roles { get; set; }
        public List<string>? Certifications { get; set; }
        public List<string>? Companies { get; set; }
        public List<string>? Dates { get; set; }
    }

    public class ExperienceContext
    {
        public string Type { get; set; } = "total";
        public string? Skill { get; set; }
        public string? Reason { get; set; }
    }

    public class EntitiesDetected
    {
        public List<string> Skills { get; set; } = new();
        public List<string> Categories { get; set; } = new();
        public List<string> CategorySkills { get; set; } = new();
        public List<string> TechExperiences { get; set; } = new();
        public List<string> OverallExperiences { get; set; } = new();
        public string? Location { get; set; }
        public List<string>? SkillLevels { get; set; }
        public List<string>? Roles { get; set; }
        public List<string>? Certifications { get; set; }
        public List<string>? Companies { get; set; }
        public List<string>? Dates { get; set; }
    }

    public class VectorSearchResult
    {
        public int EmployeeId { get; set; }
        public decimal SimilarityScore { get; set; }
        public Dictionary<string, object>? Metadata { get; set; }
    }

    public class ChatSearchResponse
    {
        public string OriginalQuery { get; set; } = string.Empty;
        public ParsedQueryData Parsed { get; set; } = new();
        public List<PythonEmployeeResult> Results { get; set; } = new();
        public int TotalResults { get; set; }
        public string SearchMethod { get; set; } = string.Empty;
    }

    public class PythonEmployeeResult
    {
        public int EmployeeId { get; set; }
        public PythonEmployeeInfo EmployeeInfo { get; set; } = new();
        public List<PythonSkill> Skills { get; set; } = new();
        public DetailedMatch DetailedMatch { get; set; } = new();
    }

    public class PythonEmployeeInfo
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Designation { get; set; }
        public string? Location { get; set; }
        public decimal TotalExperience { get; set; }
        public string? AvailabilityStatus { get; set; }
        public string? TeamName { get; set; }
        public string? Department { get; set; }
    }

    public class PythonSkill
    {
        public string SkillName { get; set; } = string.Empty;
        public string? Category { get; set; }
        public decimal YearsOfExperience { get; set; }
        public string? ProficiencyLevel { get; set; }
        public DateTime? LastUsedDate { get; set; }
    }

    public class DetailedMatch
    {
        public decimal OverallMatchPercentage { get; set; }
        public Dictionary<string, decimal> ComponentScores { get; set; } = new();
        public List<SkillAnalysis> SkillAnalysis { get; set; } = new();
        public ExperienceAnalysis ExperienceAnalysis { get; set; } = new();
    }

    public class SkillAnalysis
    {
        public string Skill { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public bool EmployeeHas { get; set; }
        public decimal EmployeeYears { get; set; }
        public string? Proficiency { get; set; }
    }

    public class ExperienceAnalysis
    {
        public decimal? Required { get; set; }
        public string Type { get; set; } = string.Empty;
        public string? Skill { get; set; }
        public string Operator { get; set; } = string.Empty;
        public decimal ActualYears { get; set; }
        public bool MeetsRequirement { get; set; }
    }
}

