namespace TalentMarketPlace.Services.Interfaces;

public interface IRequirementService
{
    Task<Requirement?> GetByIdAsync(int requirementId);
    Task<List<Requirement>> GetAllAsync(bool activeOnly = true);
    Task<List<Requirement>> GetByManagerAsync(int managerId);
    Task<List<Requirement>> GetByTeamAsync(int teamId);
    Task<Requirement> CreateAsync(Requirement requirement);
    Task<Requirement> UpdateAsync(Requirement requirement);
    Task<bool> CloseAsync(int requirementId);
    Task<bool> DeleteAsync(int requirementId);
    Task<List<RequirementSkill>> GetRequirementSkillsAsync(int requirementId);
    Task<RequirementSkill> AddSkillAsync(RequirementSkill requirementSkill);
    Task<bool> RemoveSkillAsync(int requirementSkillId);
    Task<List<EmployeeSearchResult>> FindMatchingEmployeesAsync(int requirementId);
    Task<bool> IncrementViewCountAsync(int requirementId);
    Task<List<Requirement>> FindBySkillsAsync(List<string> coreSkillNames, int minimumMatchPercentage = 70);
}

public class RequirementListItem
{
    public int RequirementId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string PostedByName { get; set; } = string.Empty;
    public string? TeamName { get; set; }
    public string? Location { get; set; }
    public string? Duration { get; set; }
    public string Priority { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public int ApplicationCount { get; set; }
    public DateTime PostedDate { get; set; }
    public List<string> RequiredSkills { get; set; } = new();
    public decimal? MatchPercentage { get; set; } // For employee view
}