using Microsoft.EntityFrameworkCore;
using TalentMarketPlace.Data;
using TalentMarketPlace.Services.Interfaces;

namespace TalentMarketPlace.Services;

public class EmployeeService : IEmployeeService
{
    private readonly TalentMarketplaceDbContext _context;

    public EmployeeService(TalentMarketplaceDbContext context)
    {
        _context = context;
    }

    public async Task<Employee?> GetByIdAsync(int employeeId)
    {
        return await _context.Employees
            .Include(e => e.Team)
            .Include(e => e.EmployeeSkills)
                .ThenInclude(es => es.Skill)
                    .ThenInclude(s => s.Category)
            .Include(e => e.EmployeeProjects)
                .ThenInclude(ep => ep.ProjectSkills)
            .FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
    }

    public async Task<Employee?> GetByUserIdAsync(int userId)
    {
        return await _context.Employees
            .Include(e => e.Team)
            .Include(e => e.EmployeeSkills)
                .ThenInclude(es => es.Skill)
            .FirstOrDefaultAsync(e => e.UserId == userId);
    }

    public async Task<Employee?> GetByEmailAsync(string email)
    {
        return await _context.Employees
            .Include(e => e.Team)
            .FirstOrDefaultAsync(e => e.Email == email);
    }

    public async Task<List<Employee>> GetAllAsync()
    {
        return await _context.Employees
            .Include(e => e.Team)
            .OrderBy(e => e.FullName)
            .ToListAsync();
    }

    public async Task<List<Employee>> SearchAsync(EmployeeSearchCriteria criteria)
    {
        var query = _context.Employees
            .Include(e => e.Team)
            .Include(e => e.EmployeeSkills)
                .ThenInclude(es => es.Skill)
            .AsQueryable();

        // Filter by skills
        if (criteria.SkillIds != null && criteria.SkillIds.Any())
        {
            query = query.Where(e => e.EmployeeSkills
                .Any(es => criteria.SkillIds.Contains(es.SkillId)));
        }

        // Filter by minimum experience
        if (criteria.MinYearsExperience.HasValue)
        {
            query = query.Where(e => e.YearsOfExperience >= criteria.MinYearsExperience.Value);
        }

        // Filter by location
        if (!string.IsNullOrEmpty(criteria.Location))
        {
            query = query.Where(e => e.Location != null &&
                e.Location.ToLower().Contains(criteria.Location.ToLower()));
        }

        // Filter by availability
        if (!string.IsNullOrEmpty(criteria.AvailabilityStatus) &&
            criteria.AvailabilityStatus != "Any")
        {
            query = query.Where(e => e.AvailabilityStatus == criteria.AvailabilityStatus);
        }

        // Filter by team
        if (criteria.TeamId.HasValue)
        {
            query = query.Where(e => e.TeamId == criteria.TeamId.Value);
        }

        // Filter by department
        if (!string.IsNullOrEmpty(criteria.Department))
        {
            query = query.Where(e => e.Team != null &&
                e.Team.Department == criteria.Department);
        }

        // Pagination
        var skipCount = (criteria.PageNumber - 1) * criteria.PageSize;

        return await query
            .OrderBy(e => e.FullName)
            .Skip(skipCount)
            .Take(criteria.PageSize)
            .ToListAsync();
    }

    public async Task<Employee> CreateAsync(Employee employee)
    {
        employee.CreatedDate = DateTime.UtcNow;
        employee.UpdatedDate = DateTime.UtcNow;
        _context.Employees.Add(employee);
        await _context.SaveChangesAsync();
        return employee;
    }

    public async Task<Employee> UpdateAsync(Employee employee)
    {
        employee.UpdatedDate = DateTime.UtcNow;
        _context.Employees.Update(employee);
        await _context.SaveChangesAsync();
        return employee;
    }

    public async Task<bool> UpdateAvailabilityAsync(int employeeId, string availabilityStatus)
    {
        var employee = await _context.Employees.FindAsync(employeeId);
        if (employee == null)
            return false;
        
        employee.AvailabilityStatus = availabilityStatus;
        
        try
        {
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating availability: {ex}");
            return false;
        }
    }

    public async Task<bool> UpdateResumeAsync(int employeeId, string resumeUrl)
    {
        var employee = await _context.Employees.FindAsync(employeeId);
        if (employee == null) return false;

        employee.ResumeUrl = resumeUrl;
        employee.LastResumeUpdate = DateTime.UtcNow;
        employee.UpdatedDate = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<EmployeeSkill>> GetEmployeeSkillsAsync(int employeeId)
    {
        // ⭐ Get data first
        var skills = await _context.EmployeeSkills
            .Include(es => es.Skill)
                .ThenInclude(s => s.Category)
            .Where(es => es.EmployeeId == employeeId)
            .ToListAsync(); // ← Convert to list FIRST
        
        // ⭐ Then sort in-memory if needed
        return skills
            .OrderBy(es => es.Skill.Category?.DisplayOrder ?? 0)
            .ThenBy(es => es.Skill.SkillName)
            .ToList();
    }

    public async Task<EmployeeSkill> AddSkillAsync(EmployeeSkill employeeSkill)
    {
        employeeSkill.CreatedDate = DateTime.UtcNow;
        employeeSkill.UpdatedDate = DateTime.UtcNow;
        _context.EmployeeSkills.Add(employeeSkill);
        await _context.SaveChangesAsync();
        return employeeSkill;
    }

    public async Task<EmployeeSkill> UpdateSkillAsync(EmployeeSkill employeeSkill)
    {
        _context.EmployeeSkills.Update(employeeSkill);
        await _context.SaveChangesAsync();
        return employeeSkill;
    }

    public async Task<bool> DeleteSkillAsync(int employeeSkillId)
    {
        var skill = await _context.EmployeeSkills.FindAsync(employeeSkillId);
        if (skill == null)
            return false;
        
        _context.EmployeeSkills.Remove(skill);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<EmployeeProject>> GetEmployeeProjectsAsync(int employeeId)
    {
        return await _context.EmployeeProjects
            .Include(ep => ep.ProjectSkills)
                .ThenInclude(ps => ps.Skill)
            .Where(ep => ep.EmployeeId == employeeId)
            .OrderByDescending(ep => ep.StartDate)
            .ToListAsync();
    }

    public async Task<EmployeeWithMatchScore> CalculateMatchScoreAsync(int employeeId, int requirementId)
    {
        var employee = await GetByIdAsync(employeeId);
        if (employee == null)
            throw new ArgumentException("Employee not found", nameof(employeeId));

        var requirement = await _context.Requirements
            .Include(r => r.RequirementSkills)
                .ThenInclude(rs => rs.Skill)
            .FirstOrDefaultAsync(r => r.RequirementId == requirementId);

        if (requirement == null)
            throw new ArgumentException("Requirement not found", nameof(requirementId));

        var result = new EmployeeWithMatchScore
        {
            Employee = employee,
            SkillMatches = new List<SkillMatchDetail>(),
            SkillGaps = new List<SkillGap>()
        };

        decimal totalWeightage = 0;
        decimal matchedWeightage = 0;

        foreach (var reqSkill in requirement.RequirementSkills)
        {
            var empSkill = employee.EmployeeSkills
                .FirstOrDefault(es => es.SkillId == reqSkill.SkillId);

            var matchDetail = new SkillMatchDetail
            {
                SkillName = reqSkill.Skill.SkillName,
                RequiredYears = reqSkill.MinYearsRequired,
                IsMandatory = reqSkill.IsMandatory
            };

            var weightage = reqSkill.IsMandatory ? reqSkill.Weightage * 2 : reqSkill.Weightage;
            totalWeightage += weightage;

            if (empSkill != null)
            {
                matchDetail.EmployeeYears = empSkill.YearsOfExperience;

                if (empSkill.YearsOfExperience >= reqSkill.MinYearsRequired)
                {
                    matchDetail.MatchStatus = "Full";
                    matchedWeightage += weightage;
                }
                else if (empSkill.YearsOfExperience >= reqSkill.MinYearsRequired * 0.8m)
                {
                    matchDetail.MatchStatus = "Partial";
                    matchedWeightage += weightage * 0.7m;
                }
                else
                {
                    matchDetail.MatchStatus = "Partial";
                    var ratio = empSkill.YearsOfExperience / reqSkill.MinYearsRequired;
                    matchedWeightage += weightage * ratio * 0.5m;

                    // Add to skill gaps
                    result.SkillGaps.Add(new SkillGap
                    {
                        SkillName = reqSkill.Skill.SkillName,
                        GapYears = reqSkill.MinYearsRequired - empSkill.YearsOfExperience
                    });
                }
            }
            else
            {
                matchDetail.MatchStatus = "Missing";
                matchDetail.EmployeeYears = 0;

                result.SkillGaps.Add(new SkillGap
                {
                    SkillName = reqSkill.Skill.SkillName,
                    GapYears = reqSkill.MinYearsRequired
                });
            }

            result.SkillMatches.Add(matchDetail);
        }

        result.MatchPercentage = totalWeightage > 0
            ? Math.Round((matchedWeightage / totalWeightage) * 100, 2)
            : 0;

        return result;
    }
}