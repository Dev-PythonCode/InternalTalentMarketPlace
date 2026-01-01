namespace TalentMarketPlace.Services.Interfaces;

public interface IEmployeeService
{
    Task<Employee?> GetByIdAsync(int employeeId);
    Task<Employee?> GetByUserIdAsync(int userId);
    Task<Employee?> GetByEmailAsync(string email);
    Task<List<Employee>> GetAllAsync();
    Task<List<Employee>> SearchAsync(EmployeeSearchCriteria criteria);
    Task<Employee> CreateAsync(Employee employee);
    Task<bool> UpdateTotalExperienceAsync(int employeeId, decimal yearsOfExperience);
    Task<Employee> UpdateAsync(Employee employee);
    Task<bool> UpdateAvailabilityAsync(int employeeId, string status);
    Task<bool> UpdateResumeAsync(int employeeId, string resumeUrl);
    Task<List<EmployeeSkill>> GetEmployeeSkillsAsync(int employeeId);
    Task<EmployeeSkill> AddSkillAsync(EmployeeSkill employeeSkill);
    Task<EmployeeSkill> UpdateSkillAsync(EmployeeSkill employeeSkill);
    Task<bool> DeleteSkillAsync(int employeeSkillId);
    Task<List<EmployeeProject>> GetEmployeeProjectsAsync(int employeeId);
    Task<EmployeeWithMatchScore> CalculateMatchScoreAsync(int employeeId, int requirementId);
}

public class EmployeeSearchCriteria
{
    public List<int>? SkillIds { get; set; }
    public decimal? MinYearsExperience { get; set; }
    public string? Location { get; set; }
    public string? AvailabilityStatus { get; set; }
    public int? TeamId { get; set; }
    public string? Department { get; set; }
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 20;
}

public class EmployeeWithMatchScore
{
    public Employee Employee { get; set; } = null!;
    public decimal MatchPercentage { get; set; }
    public List<SkillMatchDetail> SkillMatches { get; set; } = new();
    public List<SkillGap> SkillGaps { get; set; } = new();
}

public class SkillMatchDetail
{
    public string SkillName { get; set; } = string.Empty;
    public decimal RequiredYears { get; set; }
    public decimal EmployeeYears { get; set; }
    public string MatchStatus { get; set; } = string.Empty; // Full, Partial, Missing
    public bool IsMandatory { get; set; }
    public int Weightage { get; set; } = 1; // Score weight for this skill
    public decimal ScoreContribution { get; set; } = 0; // Actual score from this skill
}

public class SkillGap
{
    public string SkillName { get; set; } = string.Empty;
    public decimal GapYears { get; set; }
    public bool IsMandatory { get; set; }
    public List<LearningResource>? RecommendedResources { get; set; }
}

/// <summary>
/// Enhanced match score breakdown for detailed scoring analysis.
/// Scoring logic:
/// - Only MANDATORY skills are considered for scoring
/// - Optional/Nice-to-have skills are NOT included in the score calculation
/// - Match percentage = (Sum of matched mandatory skill weights / Sum of all mandatory skill weights) * 100
/// 
/// For each mandatory skill:
///   - Full Match (employee years >= required years): 100% of skill weight
///   - Partial Match (employee years 80-99% of required): 70% of skill weight
///   - Partial Match (employee years < 80% of required): (employee years / required years) * 50% of skill weight
///   - Missing (employee doesn't have skill): 0% of skill weight
/// </summary>
public class ScoringBreakdown
{
    /// <summary>Match percentage based on mandatory skills only</summary>
    public decimal MatchPercentage { get; set; }

    /// <summary>Overall years of experience (for context)</summary>
    public decimal EmployeeTotalExperience { get; set; }

    /// <summary>Mandatory skills analyzed for matching</summary>
    public List<SkillMatchDetail> MandatorySkills { get; set; } = new();

    /// <summary>Optional skills (NOT used in scoring, shown for reference)</summary>
    public List<SkillMatchDetail> OptionalSkills { get; set; } = new();

    /// <summary>Missing mandatory skills creating gaps</summary>
    public List<SkillGap> MissingMandatorySkills { get; set; } = new();

    /// <summary>Detailed calculation: total weight of all mandatory skills</summary>
    public decimal TotalMandatoryWeight { get; set; }

    /// <summary>Detailed calculation: actual weight earned from matching</summary>
    public decimal EarnedWeight { get; set; }

    /// <summary>Text explanation of how score was calculated</summary>
    public string ScoringExplanation { get; set; } = string.Empty;
}