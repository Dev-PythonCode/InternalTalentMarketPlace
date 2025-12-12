using Microsoft.EntityFrameworkCore;
using TalentMarketPlace.Data;
using TalentMarketPlace.Services.Interfaces;

namespace TalentMarketPlace.Services;

public class ApplicationService : IApplicationService
{
    private readonly TalentMarketplaceDbContext _context;
    private readonly IEmployeeService _employeeService;
    private readonly IPythonApiService _pythonApiService;

    public ApplicationService(
        TalentMarketplaceDbContext context,
        IEmployeeService employeeService,
        IPythonApiService pythonApiService)
    {
        _context = context;
        _employeeService = employeeService;
        _pythonApiService = pythonApiService;
    }

    public async Task<Application?> GetByIdAsync(int applicationId)
    {
        return await _context.Applications
            .Include(a => a.Employee)
                .ThenInclude(e => e.EmployeeSkills)
                    .ThenInclude(es => es.Skill)
            .Include(a => a.Requirement)
                .ThenInclude(r => r.RequirementSkills)
                    .ThenInclude(rs => rs.Skill)
            .FirstOrDefaultAsync(a => a.ApplicationId == applicationId);
    }

    public async Task<List<Application>> GetByRequirementAsync(int requirementId)
{
    var applications = await _context.Applications
        .Include(a => a.Employee)
            .ThenInclude(e => e.Team)
        .Include(a => a.Employee.EmployeeSkills)
            .ThenInclude(es => es.Skill)
        .Where(a => a.RequirementId == requirementId)
        .ToListAsync();  // ← Get data first
    
    // Order in memory after retrieval
    return applications
        .OrderByDescending(a => a.AIScore ?? 0)
        .ToList();
}

    public async Task<List<Application>> GetByEmployeeAsync(int employeeId)
    {
        return await _context.Applications
            .Include(a => a.Requirement)
                .ThenInclude(r => r.RequirementSkills)
                    .ThenInclude(rs => rs.Skill)
            .Where(a => a.EmployeeId == employeeId)
            .OrderByDescending(a => a.AppliedDate)
            .ToListAsync();
    }

    public async Task<Application> ApplyAsync(int employeeId, int requirementId, string? coverLetter)
    {
        // Check if already applied
        var existing = await _context.Applications
            .FirstOrDefaultAsync(a => a.EmployeeId == employeeId && a.RequirementId == requirementId);

        if (existing != null)
            throw new InvalidOperationException("You have already applied to this requirement");

        // Validate and calculate scores
        var validation = await ValidateApplicationAsync(employeeId, requirementId);

        var application = new Application
        {
            EmployeeId = employeeId,
            RequirementId = requirementId,
            CoverLetter = coverLetter,
            MatchPercentage = validation.MatchPercentage,
            AIScore = validation.AIScore,
            AIRecommendation = validation.Recommendation,
            Status = "Pending",
            AppliedDate = DateTime.UtcNow
        };

        _context.Applications.Add(application);

        // Update application count on requirement
        var requirement = await _context.Requirements.FindAsync(requirementId);
        if (requirement != null)
        {
            requirement.ApplicationCount++;
        }

        await _context.SaveChangesAsync();
        return application;
    }

    public async Task<Application> UpdateStatusAsync(int applicationId, string status, string? feedback)
    {
        var application = await _context.Applications.FindAsync(applicationId);
        if (application == null)
            throw new ArgumentException("Application not found", nameof(applicationId));

        application.Status = status;
        application.ManagerFeedback = feedback;
        application.ReviewedDate = DateTime.UtcNow;

        await _context.SaveChangesAsync();
        return application;
    }

    public async Task<bool> WithdrawAsync(int applicationId)
    {
        var application = await _context.Applications.FindAsync(applicationId);
        if (application == null) return false;

        _context.Applications.Remove(application);

        // Update application count on requirement
        var requirement = await _context.Requirements.FindAsync(application.RequirementId);
        if (requirement != null && requirement.ApplicationCount > 0)
        {
            requirement.ApplicationCount--;
        }

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> HasAppliedAsync(int employeeId, int requirementId)
    {
        return await _context.Applications
            .AnyAsync(a => a.EmployeeId == employeeId && a.RequirementId == requirementId);
    }

    public async Task<ApplicationValidation> ValidateApplicationAsync(int employeeId, int requirementId)
    {
        var matchResult = await _employeeService.CalculateMatchScoreAsync(employeeId, requirementId);

        var validation = new ApplicationValidation
        {
            MatchPercentage = matchResult.MatchPercentage,
            SkillAnalysis = matchResult.SkillMatches,
            GapAnalysis = matchResult.SkillGaps
        };

        // Calculate AI Score (weighted formula)
        var mandatoryMatches = matchResult.SkillMatches
            .Where(sm => sm.IsMandatory && sm.MatchStatus != "Missing")
            .Count();
        var totalMandatory = matchResult.SkillMatches.Count(sm => sm.IsMandatory);

        if (totalMandatory > 0)
        {
            var mandatoryScore = (decimal)mandatoryMatches / totalMandatory * 100;
            validation.AIScore = Math.Round((validation.MatchPercentage * 0.6m) + (mandatoryScore * 0.4m), 2);
        }
        else
        {
            validation.AIScore = validation.MatchPercentage;
        }

        // Generate recommendation
        if (validation.AIScore >= 80)
        {
            validation.Recommendation = "Good fit";
            validation.RecommendationReason = "Candidate meets or exceeds most skill requirements.";
        }
        else if (validation.AIScore >= 60)
        {
            validation.Recommendation = "Needs training";
            validation.RecommendationReason = "Candidate has foundational skills but would benefit from upskilling.";
        }
        else
        {
            validation.Recommendation = "Not recommended";
            validation.RecommendationReason = "Significant skill gaps exist for this role.";
        }

        // Get learning suggestions for gaps
        if (matchResult.SkillGaps.Any())
        {
            var skillIds = await _context.Skills
                .Where(s => matchResult.SkillGaps.Select(g => g.SkillName).Contains(s.SkillName))
                .Select(s => s.SkillId)
                .ToListAsync();

            validation.SuggestedLearning = await _context.LearningResources
                .Where(lr => skillIds.Contains(lr.SkillId) && lr.IsActive)
                .Take(5)
                .ToListAsync();
        }

        return validation;
    }
}