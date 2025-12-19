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
    Task<List<Application>> GetAllAsync();
    Task<ApplicationValidation> ValidateApplicationAsync(int employeeId, int requirementId);
}

public class ApplicationValidation
{
    public decimal MatchPercentage { get; set; }
    public decimal AIScore { get; set; }
    public string Recommendation { get; set; } = string.Empty; // Good fit, Needs training, Not recommended
    public string RecommendationReason { get; set; } = string.Empty;
    public List<SkillMatchDetail> SkillAnalysis { get; set; } = new();
    public List<SkillGap> GapAnalysis { get; set; } = new();
    public List<LearningResource> SuggestedLearning { get; set; } = new();
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