using Microsoft.EntityFrameworkCore;
using TalentMarketPlace.Data;
using TalentMarketPlace.Services.Interfaces;

namespace TalentMarketPlace.Services;

public class RequirementService : IRequirementService
{
    private readonly TalentMarketplaceDbContext _context;
    private readonly ISearchService _searchService;

    public RequirementService(TalentMarketplaceDbContext context, ISearchService searchService)
    {
        _context = context;
        _searchService = searchService;
    }

    public async Task<Requirement?> GetByIdAsync(int requirementId)
    {
        return await _context.Requirements
            .Include(r => r.PostedBy)
            .Include(r => r.Team)
            .Include(r => r.RequirementSkills)
                .ThenInclude(rs => rs.Skill)
            .Include(r => r.Applications)
            .FirstOrDefaultAsync(r => r.RequirementId == requirementId);
    }

    public async Task<List<Requirement>> GetAllAsync(bool openOnly = false)
    {
        var query = _context.Requirements
            .Include(r => r.Team)
            .Include(r => r.RequirementSkills)
                .ThenInclude(rs => rs.Skill)
            .AsQueryable();

        if (openOnly)
        {
            query = query.Where(r => r.Status == "Open");
        }

        // ⭐ Convert to List BEFORE returning
        return await query.ToListAsync();
    }

    public async Task<List<Requirement>> GetByManagerAsync(int managerId)
    {
        return await _context.Requirements
            .Include(r => r.Team)
            .Include(r => r.RequirementSkills)
                .ThenInclude(rs => rs.Skill)
            .Include(r => r.Applications)
            .Where(r => r.PostedById == managerId)
            .OrderByDescending(r => r.PostedDate)
            .ToListAsync();
    }

    public async Task<List<Requirement>> GetByTeamAsync(int teamId)
    {
        return await _context.Requirements
            .Include(r => r.PostedBy)
            .Include(r => r.RequirementSkills)
                .ThenInclude(rs => rs.Skill)
            .Where(r => r.TeamId == teamId && r.IsActive)
            .OrderByDescending(r => r.PostedDate)
            .ToListAsync();
    }

    public async Task<Requirement> CreateAsync(Requirement requirement)
    {
        // Create a new entity with explicit property mapping to ensure all values are set
        var newRequirement = new Requirement
        {
            Title = requirement.Title,
            Description = requirement.Description,  // ← FIXED: Explicitly set Description
            Location = requirement.Location,
            Duration = requirement.Duration,
            Priority = requirement.Priority,
            Status = requirement.Status ?? "Open",
            StartDate = requirement.StartDate,
            ExpiryDate = requirement.ExpiryDate,
            PostedById = requirement.PostedById,
            TeamId = requirement.TeamId,
            PostedDate = DateTime.UtcNow,
            IsActive = true,
            ViewCount = 0,
            ApplicationCount = 0
        };
        
        _context.Requirements.Add(newRequirement);
        await _context.SaveChangesAsync();
        
        return newRequirement;
    }

    public async Task<Requirement> UpdateAsync(Requirement requirement)
    {
        _context.Requirements.Update(requirement);
        await _context.SaveChangesAsync();
        return requirement;
    }

    public async Task<bool> CloseAsync(int requirementId)
    {
        var requirement = await _context.Requirements.FindAsync(requirementId);
        if (requirement == null) return false;

        requirement.Status = "Closed";
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int requirementId)
    {
        var requirement = await _context.Requirements.FindAsync(requirementId);
        if (requirement == null) return false;

        requirement.IsActive = false;
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<RequirementSkill>> GetRequirementSkillsAsync(int requirementId)
    {
        return await _context.RequirementSkills
            .Include(rs => rs.Skill)
            .Where(rs => rs.RequirementId == requirementId)
            .OrderByDescending(rs => rs.IsMandatory)
            .ThenBy(rs => rs.Skill.SkillName)
            .ToListAsync();
    }

    public async Task<RequirementSkill> AddSkillAsync(RequirementSkill requirementSkill)
    {
        _context.RequirementSkills.Add(requirementSkill);
        await _context.SaveChangesAsync();
        return requirementSkill;
    }

    public async Task<bool> RemoveSkillAsync(int requirementSkillId)
    {
        var skill = await _context.RequirementSkills.FindAsync(requirementSkillId);
        if (skill == null) return false;

        _context.RequirementSkills.Remove(skill);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<EmployeeSearchResult>> FindMatchingEmployeesAsync(int requirementId)
    {
        var requirement = await GetByIdAsync(requirementId);
        if (requirement == null) return new List<EmployeeSearchResult>();

        var skillIds = requirement.RequirementSkills.Select(rs => rs.SkillId).ToList();

        var searchQuery = new SearchQuery
        {
            SkillIds = skillIds,
            Location = requirement.Location,
            RequirementId = requirementId
        };

        var result = await _searchService.SearchEmployeesAsync(searchQuery);
        return result.Employees;
    }

    public async Task<bool> IncrementViewCountAsync(int requirementId)
    {
        var requirement = await _context.Requirements.FindAsync(requirementId);
        if (requirement == null) return false;

        requirement.ViewCount++;
        await _context.SaveChangesAsync();
        return true;
    }

    /// <summary>
    /// Find open requirements that match the given core skills.
    /// Returns requirements where the core skills match at least the specified percentage of required skills.
    /// </summary>
    public async Task<List<Requirement>> FindBySkillsAsync(List<string> coreSkillNames, int minimumMatchPercentage = 70)
    {
        if (!coreSkillNames.Any())
            return new List<Requirement>();

        // Normalize skill names
        var normalizedSkillNames = coreSkillNames
            .Select(s => s.ToLower().Trim())
            .Distinct()
            .ToList();

        // Get all open requirements with their skills
        var openRequirements = await _context.Requirements
            .Include(r => r.RequirementSkills)
                .ThenInclude(rs => rs.Skill)
            .Include(r => r.PostedBy)
            .Include(r => r.Team)
            .Where(r => r.Status == "Open" && r.IsActive)
            .ToListAsync();

        // Filter requirements where at least minimumMatchPercentage of required skills are in coreSkillNames
        var matchedRequirements = new List<Requirement>();

        foreach (var requirement in openRequirements)
        {
            if (!requirement.RequirementSkills.Any())
                continue;

            var requiredSkillNames = requirement.RequirementSkills
                .Select(rs => rs.Skill.SkillName.ToLower().Trim())
                .ToList();

            // Calculate match percentage: how many required skills are in core skills
            var matchedCount = requiredSkillNames
                .Count(rSkill => normalizedSkillNames.Any(cSkill => 
                    rSkill.Contains(cSkill) || cSkill.Contains(rSkill)))
                ;

            var matchPercentage = requiredSkillNames.Count > 0
                ? (matchedCount * 100) / requiredSkillNames.Count
                : 0;

            if (matchPercentage >= minimumMatchPercentage)
            {
                matchedRequirements.Add(requirement);
            }
        }

        // Sort by match percentage (highest first)
        return matchedRequirements
            .OrderByDescending(r => r.RequirementSkills.Count)
            .ToList();
    }
}