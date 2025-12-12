// ISearchService.cs - UPDATED
// Added ExperienceContext field to EmployeeSearchResult

namespace TalentMarketPlace.Services.Interfaces;

public interface ISearchService
{
    Task<SearchResult> SearchEmployeesAsync(SearchQuery query);
    Task<SearchResult> NaturalLanguageSearchAsync(string chatQuery);
    Task<List<SearchHistory>> GetSearchHistoryAsync(int userId, int count = 10);
    Task<SearchHistory> SaveSearchAsync(int userId, string searchName, SearchQuery query);
    Task<List<SearchHistory>> GetSavedSearchesAsync(int userId);
    Task<bool> DeleteSavedSearchAsync(int searchId);
}

public class SearchQuery
{
    public List<int>? SkillIds { get; set; }
    public decimal? MinYearsExperience { get; set; }
    public string? Location { get; set; }
    public string? AvailabilityStatus { get; set; }
    public int? TeamId { get; set; }
    public string? Department { get; set; }
    public string? NaturalLanguageQuery { get; set; }
    public int? RequirementId { get; set; }
    public string SortBy { get; set; } = "MatchPercentage";
    public bool SortDescending { get; set; } = true;
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}

public class SearchResult
{
    public List<EmployeeSearchResult> Employees { get; set; } = new();
    public int TotalCount { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public string? ParsedQuery { get; set; }
    public List<string>? ExtractedSkills { get; set; }
    public List<string>? AppliedFilters { get; set; }
}

public class EmployeeSearchResult
{
    public int EmployeeId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? PhotoUrl { get; set; }
    public string? Location { get; set; }
    public string? Designation { get; set; }
    public string? TeamName { get; set; }
    public string? Department { get; set; }
    public string AvailabilityStatus { get; set; } = string.Empty;
    public int YearsOfExperience { get; set; }
    public decimal MatchPercentage { get; set; }
    public List<SkillTag> Skills { get; set; } = new();

    // ⭐ NEW: Experience context for display
    /// <summary>
    /// Type of experience match: "skill_specific" or "total"
    /// Used to show user HOW the match was calculated
    /// </summary>
    public string? ExperienceContext { get; set; }
}
public class SkillTag
{
    public string SkillName { get; set; } = string.Empty;
    public decimal YearsOfExperience { get; set; }
    public string ProficiencyLevel { get; set; } = string.Empty;
    public string MatchStatus { get; set; } = string.Empty;
    public DateTime? LastUsedDate { get; set; }
}

