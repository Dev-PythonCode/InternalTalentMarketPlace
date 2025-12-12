namespace TalentMarketPlace.Services.Interfaces;

public interface IEmployeeService
{
    Task<Employee?> GetByIdAsync(int employeeId);
    Task<Employee?> GetByUserIdAsync(int userId);
    Task<Employee?> GetByEmailAsync(string email);
    Task<List<Employee>> GetAllAsync();
    Task<List<Employee>> SearchAsync(EmployeeSearchCriteria criteria);
    Task<Employee> CreateAsync(Employee employee);
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
}

public class SkillGap
{
    public string SkillName { get; set; } = string.Empty;
    public decimal GapYears { get; set; }
    public List<LearningResource>? RecommendedResources { get; set; }
}