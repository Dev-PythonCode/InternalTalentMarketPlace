namespace TalentMarketPlace.Services.Interfaces;

public interface IApplicationService
{
    Task<Application?> GetByIdAsync(int applicationId);
    Task<List<Application>> GetByRequirementAsync(int requirementId);
    Task<List<Application>> GetByEmployeeAsync(int employeeId);
    Task<Application> ApplyAsync(int employeeId, int requirementId, string? coverLetter);
    Task<Application> UpdateStatusAsync(int applicationId, string status, string? feedback);
    Task<bool> WithdrawAsync(int applicationId);
    Task<bool> HasAppliedAsync(int employeeId, int requirementId);
    Task<int> GetApplicationCountAsync(int requirementId);
    Task<List<Application>> GetByManagerAsync(int managerId);
    Task<List<Application>> GetByHRAsync();
    Task<List<Application>> GetAllAsync();
    Task<ApplicationValidation> ValidateApplicationAsync(int employeeId, int requirementId);
}

public class ApplicationValidation
{
    /// <summary>Match percentage based on MANDATORY skills only</summary>
    public decimal MatchPercentage { get; set; }

    /// <summary>AI recommendation score (same as MatchPercentage since scoring is now consistent)</summary>
    public decimal AIScore { get; set; }

    /// <summary>Recommendation category: "Good fit", "Needs training", or "Not recommended"</summary>
    public string Recommendation { get; set; } = string.Empty;

    /// <summary>Detailed reason for the recommendation</summary>
    public string RecommendationReason { get; set; } = string.Empty;

    /// <summary>All skill matches (both mandatory and optional) with match status</summary>
    public List<SkillMatchDetail> SkillAnalysis { get; set; } = new();

    /// <summary>Skill gaps - only MANDATORY skills that are missing or below threshold</summary>
    public List<SkillGap> GapAnalysis { get; set; } = new();

    /// <summary>Suggested learning resources for gap skills</summary>
    public List<LearningResource> SuggestedLearning { get; set; } = new();

    /// <summary>Detailed scoring breakdown for transparency</summary>
    public ScoringBreakdown? ScoringBreakdown { get; set; }
}

public class ApplicationListItem
{
    public int ApplicationId { get; set; }
    public int RequirementId { get; set; }
    public string RequirementTitle { get; set; } = string.Empty;
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; } = string.Empty;
    public string? EmployeePhoto { get; set; }
    public string? Designation { get; set; }
    public decimal? MatchPercentage { get; set; }
    public decimal? AIScore { get; set; }
    public string? AIRecommendation { get; set; }
    public string Status { get; set; } = string.Empty;
    public DateTime AppliedDate { get; set; }
    public DateTime? ReviewedDate { get; set; }
}