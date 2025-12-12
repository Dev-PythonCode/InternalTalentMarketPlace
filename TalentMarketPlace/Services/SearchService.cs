// SearchService.cs - UPDATED
// Enhanced to handle SpaCy NER experience context (tech-specific vs total)

using Microsoft.EntityFrameworkCore;
using TalentMarketPlace.Data;
using TalentMarketPlace.Services.Interfaces;
using System.Text.Json;

namespace TalentMarketPlace.Services
{
    public class SearchService : ISearchService
    {
        private readonly TalentMarketplaceDbContext _context;
        private readonly IPythonApiService _pythonApiService;
        private readonly ILogger<SearchService> _logger;

        public SearchService(
            TalentMarketplaceDbContext context,
            IPythonApiService pythonApiService,
            ILogger<SearchService> logger)
        {
            _context = context;
            _pythonApiService = pythonApiService;
            _logger = logger;
        }

        public async Task<SearchResult> SearchEmployeesAsync(SearchQuery query)
        {
            var employeesQuery = _context.Employees
                .Include(e => e.Team)
                .Include(e => e.User)
                .Include(e => e.EmployeeSkills)
                    .ThenInclude(es => es.Skill)
                .Where(e => e.User.IsActive)
                .AsQueryable();

            // Apply location filter
            if (!string.IsNullOrEmpty(query.Location))
            {
                employeesQuery = employeesQuery.Where(e => e.Location == query.Location);
            }

            // Apply availability filter
            if (!string.IsNullOrEmpty(query.AvailabilityStatus))
            {
                employeesQuery = employeesQuery.Where(e => e.AvailabilityStatus == query.AvailabilityStatus);
            }

            // Apply team filter
            if (query.TeamId.HasValue)
            {
                employeesQuery = employeesQuery.Where(e => e.TeamId == query.TeamId);
            }

            // Apply department filter
            if (!string.IsNullOrEmpty(query.Department))
            {
                employeesQuery = employeesQuery.Where(e => e.Team != null && e.Team.Department == query.Department);
            }

            var employees = await employeesQuery.ToListAsync();

            // Calculate match percentage for each employee
            var results = new List<EmployeeSearchResult>();

            foreach (var employee in employees)
            {
                var matchPercentage = CalculateMatchPercentage(employee, query);

                bool shouldInclude = false;

                if (query.SkillIds != null && query.SkillIds.Any())
                {
                    shouldInclude = matchPercentage > 0;
                }
                else
                {
                    matchPercentage = 0;
                    shouldInclude = true;
                }

                if (shouldInclude)
                {
                    var skillTags = employee.EmployeeSkills.Select(es => new SkillTag
                    {
                        SkillName = es.Skill.SkillName,
                        YearsOfExperience = es.YearsOfExperience,
                        ProficiencyLevel = es.ProficiencyLevel ?? "Unknown",
                        MatchStatus = GetSkillMatchStatus(es, query),
                        LastUsedDate = es.LastUsedDate
                    }).ToList();

                    results.Add(new EmployeeSearchResult
                    {
                        EmployeeId = employee.EmployeeId,
                        FullName = employee.FullName,
                        Email = employee.Email,
                        PhotoUrl = employee.PhotoUrl,
                        Designation = employee.Designation,
                        TeamName = employee.Team?.TeamName,
                        Department = employee.Team?.Department,
                        Location = employee.Location,
                        AvailabilityStatus = employee.AvailabilityStatus,
                        YearsOfExperience = (int)employee.YearsOfExperience,
                        MatchPercentage = matchPercentage,
                        Skills = skillTags
                    });
                }
            }

            // Sort results
            results = query.SortBy switch
            {
                "Name" => query.SortDescending
                    ? results.OrderByDescending(r => r.FullName).ToList()
                    : results.OrderBy(r => r.FullName).ToList(),
                "Experience" => query.SortDescending
                    ? results.OrderByDescending(r => r.YearsOfExperience).ToList()
                    : results.OrderBy(r => r.YearsOfExperience).ToList(),
                _ => results.OrderByDescending(r => r.MatchPercentage).ToList()
            };

            // Apply pagination
            var totalCount = results.Count;
            var pagedResults = results
                .Skip((query.PageNumber - 1) * query.PageSize)
                .Take(query.PageSize)
                .ToList();

            return new SearchResult
            {
                Employees = pagedResults,
                TotalCount = totalCount,
                PageNumber = query.PageNumber,
                PageSize = query.PageSize
            };
        }

        // ⭐ UPDATED: Enhanced natural language search with experience context
        public async Task<SearchResult> NaturalLanguageSearchAsync(string chatQuery)
        {
            try
            {
                _logger.LogInformation("Processing natural language query: {Query}", chatQuery);

                var isHealthy = await _pythonApiService.IsHealthyAsync();
                if (!isHealthy)
                {
                    _logger.LogWarning("Python API is not available, using fallback search");
                    return await FallbackSearchAsync(chatQuery);
                }

                var parseResult = await _pythonApiService.ParseQueryAsync(chatQuery);

                if (!string.IsNullOrEmpty(parseResult.Error))
                {
                    _logger.LogError("Python API error: {Error}", parseResult.Error);
                    return await FallbackSearchAsync(chatQuery);
                }

                // ⭐ CRITICAL: Get required skills FIRST
                var requiredSkills = parseResult.Parsed.Skills?.ToList() ?? new List<string>();
                var categorySkills = parseResult.Parsed.CategorySkills ?? new List<string>();
                var minYears = parseResult.Parsed.MinYearsExperience;
                var expOperator = parseResult.Parsed.ExperienceOperator ?? "gte";
                var experienceContext = parseResult.Parsed.ExperienceContext;

                // ⭐ CRITICAL: If NO skills specified, return empty
                if (!requiredSkills.Any() && !categorySkills.Any())
                {
                    _logger.LogWarning("No skills found in query, returning empty result");
                    return new SearchResult
                    {
                        Employees = new List<EmployeeSearchResult>(),
                        TotalCount = 0,
                        PageNumber = 1,
                        PageSize = 50,
                        AppliedFilters = new List<string> { "No skills detected in query" },
                        ParsedQuery = chatQuery
                    };
                }

                // Combine all target skills
                var allTargetSkills = requiredSkills.Concat(categorySkills).Distinct().ToList();

                _logger.LogInformation("Searching for skills: {Skills}", string.Join(", ", allTargetSkills));

                // ⭐ STEP 1: Query only employees who have AT LEAST ONE of the required skills
                var employeesQuery = _context.Employees
                    .Include(e => e.Team)
                    .Include(e => e.User)
                    .Include(e => e.EmployeeSkills)
                        .ThenInclude(es => es.Skill)
                    .Where(e => e.User.IsActive)
                    .Where(e => e.EmployeeSkills.Any(es =>
                        allTargetSkills.Contains(es.Skill.SkillName)
                    )); // ⭐ THIS IS THE CRITICAL FILTER!

                // Apply location filter
                if (!string.IsNullOrEmpty(parseResult.Parsed.Location))
                {
                    employeesQuery = employeesQuery.Where(e => e.Location == parseResult.Parsed.Location);
                }

                // Apply availability filter
                if (!string.IsNullOrEmpty(parseResult.Parsed.AvailabilityStatus))
                {
                    employeesQuery = employeesQuery.Where(e => e.AvailabilityStatus == parseResult.Parsed.AvailabilityStatus);
                }

                var employees = await employeesQuery.ToListAsync();

                _logger.LogInformation("Found {Count} employees with matching skills (before experience filter)", employees.Count);

                // Build results
                var results = new List<EmployeeSearchResult>();

                foreach (var employee in employees)
                {
                    // ⭐ STEP 2: Check experience requirement
                    bool meetsExperienceRequirement = true;

                    if (minYears.HasValue && minYears.Value > 0)
                    {
                        meetsExperienceRequirement = false;

                        if (experienceContext?.Type == "skill_specific")
                        {
                            // TECH-SPECIFIC: Must have X years OF the specific skill
                            var targetSkill = experienceContext.Skill ?? requiredSkills.FirstOrDefault();

                            if (!string.IsNullOrEmpty(targetSkill))
                            {
                                var employeeSkill = employee.EmployeeSkills
                                    .FirstOrDefault(es => es.Skill.SkillName.Equals(targetSkill, StringComparison.OrdinalIgnoreCase));

                                if (employeeSkill != null)
                                {
                                    meetsExperienceRequirement = CheckExperienceOperator(
                                        employeeSkill.YearsOfExperience,
                                        minYears.Value,
                                        expOperator
                                    );

                                    _logger.LogDebug("Employee {Id}: {Skill} - {Years} years (Required: {MinYears}, Meets: {Meets})",
                                        employee.EmployeeId, targetSkill, employeeSkill.YearsOfExperience, minYears.Value, meetsExperienceRequirement);
                                }
                                else
                                {
                                    _logger.LogDebug("Employee {Id}: Does not have skill {Skill}", employee.EmployeeId, targetSkill);
                                }
                            }
                        }
                        else
                        {
                            // TOTAL EXPERIENCE: Must have X years total + have the skill
                            meetsExperienceRequirement = CheckExperienceOperator(
                                employee.YearsOfExperience,
                                minYears.Value,
                                expOperator
                            );

                            _logger.LogDebug("Employee {Id}: Total experience {Years} years (Required: {MinYears}, Meets: {Meets})",
                                employee.EmployeeId, employee.YearsOfExperience, minYears.Value, meetsExperienceRequirement);
                        }

                        // ⭐ SKIP if doesn't meet experience requirement
                        if (!meetsExperienceRequirement)
                        {
                            _logger.LogDebug("Employee {Id} excluded: Does not meet experience requirement", employee.EmployeeId);
                            continue;
                        }
                    }

                    // ⭐ STEP 3: Calculate match with experience context
                    var matchResult = CalculateAdvancedMatchWithContext(
                        employee,
                        requiredSkills,
                        categorySkills,
                        minYears,
                        expOperator,
                        experienceContext
                    );

                    // ⭐ ONLY include if match percentage > 0
                    if (matchResult.MatchPercentage > 0)
                    {
                        var skillTags = employee.EmployeeSkills.Select(es => new SkillTag
                        {
                            SkillName = es.Skill.SkillName,
                            YearsOfExperience = es.YearsOfExperience,
                            ProficiencyLevel = es.ProficiencyLevel ?? "Unknown",
                            MatchStatus = GetAdvancedSkillMatchStatus(es, requiredSkills, categorySkills, minYears, experienceContext),
                            LastUsedDate = es.LastUsedDate
                        }).ToList();

                        results.Add(new EmployeeSearchResult
                        {
                            EmployeeId = employee.EmployeeId,
                            FullName = employee.FullName,
                            Email = employee.Email,
                            PhotoUrl = employee.PhotoUrl,
                            Designation = employee.Designation,
                            TeamName = employee.Team?.TeamName,
                            Department = employee.Team?.Department,
                            Location = employee.Location,
                            AvailabilityStatus = employee.AvailabilityStatus,
                            YearsOfExperience = (int)employee.YearsOfExperience,
                            MatchPercentage = Math.Round(matchResult.MatchPercentage, 1),
                            Skills = skillTags,
                            ExperienceContext = experienceContext?.Type
                        });

                        _logger.LogInformation("Employee {Id} included with {Match}% match",
                            employee.EmployeeId, matchResult.MatchPercentage);
                    }
                    else
                    {
                        _logger.LogDebug("Employee {Id} excluded: 0% match", employee.EmployeeId);
                    }
                }

                // Sort by match percentage
                results = results.OrderByDescending(r => r.MatchPercentage).ToList();

                _logger.LogInformation("Returning {Count} matching employees", results.Count);

                // Build applied filters
                var appliedFilters = BuildAppliedFilters(parseResult, experienceContext);

                return new SearchResult
                {
                    Employees = results,
                    TotalCount = results.Count,
                    PageNumber = 1,
                    PageSize = 50,
                    AppliedFilters = appliedFilters,
                    ExtractedSkills = parseResult.Parsed.Skills,
                    ParsedQuery = chatQuery
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in natural language search");
                return await FallbackSearchAsync(chatQuery);
            }
        }


        // ⭐ NEW: Helper method to check experience operator
        private bool CheckExperienceOperator(decimal actualYears, decimal requiredYears, string operatorStr)
        {
            return operatorStr switch
            {
                "gt" => actualYears > requiredYears,
                "gte" => actualYears >= requiredYears,
                "lt" => actualYears < requiredYears,
                "lte" => actualYears <= requiredYears,
                "eq" => actualYears == requiredYears,
                _ => actualYears >= requiredYears
            };
        }

        // ⭐ NEW: Build applied filters with experience context
        private List<string> BuildAppliedFilters(ParseQueryResult parseResult, ExperienceContext? expContext)
        {
            var filters = new List<string>();

            if (parseResult.Parsed.Skills?.Any() == true)
            {
                filters.Add($"Skills: {string.Join(", ", parseResult.Parsed.Skills)}");
            }

            if (parseResult.Parsed.Categories?.Any() == true)
            {
                filters.Add($"Categories: {string.Join(", ", parseResult.Parsed.Categories)}");
            }

            if (parseResult.Parsed.MinYearsExperience.HasValue)
            {
                var years = parseResult.Parsed.MinYearsExperience.Value;
                var expType = expContext?.Type == "skill_specific"
                    ? $"in {expContext.Skill}"
                    : "total experience";

                filters.Add($"Experience: {years}+ years {expType}");
            }

            if (!string.IsNullOrEmpty(parseResult.Parsed.Location))
            {
                filters.Add($"Location: {parseResult.Parsed.Location}");
            }

            if (parseResult.Parsed.SkillLevels?.Any() == true)
            {
                filters.Add($"Level: {string.Join(", ", parseResult.Parsed.SkillLevels)}");
            }

            if (parseResult.Parsed.Roles?.Any() == true)
            {
                filters.Add($"Roles: {string.Join(", ", parseResult.Parsed.Roles)}");
            }

            return filters;
        }

        // ⭐ UPDATED: Calculate match with experience context
        private (decimal MatchPercentage, bool MeetsRequirements) CalculateAdvancedMatchWithContext(
            Employee employee,
            List<string> requiredSkills,
            List<string> categorySkills,
            decimal? minYears,
            string experienceOperator,
            ExperienceContext? experienceContext)
        {
            if (!requiredSkills.Any() && !categorySkills.Any())
            {
                return (0, true);
            }

            decimal totalScore = 0;
            decimal maxScore = 0;
            bool meetsAllRequirements = true;

            // Score for required skills
            foreach (var skillName in requiredSkills)
            {
                maxScore += 100;

                var employeeSkill = employee.EmployeeSkills
                    .FirstOrDefault(es => es.Skill.SkillName.Equals(skillName, StringComparison.OrdinalIgnoreCase));

                if (employeeSkill != null)
                {
                    // Check experience requirement based on context
                    if (minYears.HasValue && minYears.Value > 0)
                    {
                        decimal yearsToCheck;

                        // ⭐ Use context to determine which experience to check
                        if (experienceContext?.Type == "skill_specific")
                        {
                            // Check skill-specific experience
                            yearsToCheck = employeeSkill.YearsOfExperience;
                        }
                        else
                        {
                            // Check total experience
                            yearsToCheck = employee.YearsOfExperience;
                        }

                        bool meetsExperience = CheckExperienceOperator(
                            yearsToCheck,
                            minYears.Value,
                            experienceOperator
                        );

                        if (meetsExperience)
                        {
                            totalScore += 100;
                        }
                        else
                        {
                            // Partial score based on ratio
                            var ratio = yearsToCheck / minYears.Value;
                            totalScore += Math.Min(ratio * 100, 70);
                            meetsAllRequirements = false;
                        }
                    }
                    else
                    {
                        totalScore += 100;
                    }
                }
                else
                {
                    meetsAllRequirements = false;
                }
            }

            // Score for category skills
            if (categorySkills.Any())
            {
                maxScore += 100;

                var matchedCategorySkills = employee.EmployeeSkills
                    .Where(es => categorySkills.Contains(es.Skill.SkillName, StringComparer.OrdinalIgnoreCase))
                    .ToList();

                if (matchedCategorySkills.Any())
                {
                    totalScore += 100;
                }
                else
                {
                    meetsAllRequirements = false;
                }
            }

            var matchPercentage = maxScore > 0 ? (totalScore / maxScore) * 100 : 0;
            return (matchPercentage, meetsAllRequirements);
        }

        // ⭐ UPDATED: Get skill match status with experience context
        private string GetAdvancedSkillMatchStatus(
            EmployeeSkill employeeSkill,
            List<string> requiredSkills,
            List<string> categorySkills,
            decimal? minYears,
            ExperienceContext? experienceContext)
        {
            var skillName = employeeSkill.Skill.SkillName;
            bool isRequired = requiredSkills.Contains(skillName, StringComparer.OrdinalIgnoreCase);
            bool isCategory = categorySkills.Contains(skillName, StringComparer.OrdinalIgnoreCase);

            if (!isRequired && !isCategory)
            {
                return "Extra";
            }

            if (minYears.HasValue && minYears.Value > 0)
            {
                // ⭐ Check based on experience context
                if (experienceContext?.Type == "skill_specific")
                {
                    // Check THIS skill's experience
                    if (employeeSkill.YearsOfExperience >= minYears.Value)
                    {
                        return "Match";
                    }
                    else
                    {
                        return "Partial";
                    }
                }
                else
                {
                    // For total experience, just having the skill is a match
                    return "Match";
                }
            }

            return "Match";
        }

        // Keep existing helper methods...
        private async Task<SearchResult> FallbackSearchAsync(string query)
        {
            var queryLower = query.ToLower();
            var searchQuery = new SearchQuery();

            var allSkills = await _context.Skills.ToListAsync();
            var matchedSkillIds = allSkills
                .Where(s => queryLower.Contains(s.SkillName.ToLower()))
                .Select(s => s.SkillId)
                .ToList();

            if (matchedSkillIds.Any())
            {
                searchQuery.SkillIds = matchedSkillIds;
            }

            var yearsMatch = System.Text.RegularExpressions.Regex.Match(queryLower, @"(\d+)\s*(?:years?|yrs?)");
            if (yearsMatch.Success)
            {
                searchQuery.MinYearsExperience = decimal.Parse(yearsMatch.Groups[1].Value);
            }

            var locations = new[] { "bangalore", "chennai", "mumbai", "hyderabad", "delhi", "pune" };
            foreach (var loc in locations)
            {
                if (queryLower.Contains(loc))
                {
                    searchQuery.Location = char.ToUpper(loc[0]) + loc.Substring(1);
                    break;
                }
            }

            if (queryLower.Contains("available") || queryLower.Contains("full time"))
            {
                searchQuery.AvailabilityStatus = "Available";
            }

            var result = await SearchEmployeesAsync(searchQuery);
            result.AppliedFilters = new List<string> { "Fallback search used (Python API unavailable)" };
            result.ParsedQuery = query;
            return result;
        }

        private decimal CalculateMatchPercentage(Employee employee, SearchQuery query)
        {
            if (query.SkillIds == null || !query.SkillIds.Any())
                return 0;

            decimal totalScore = 0;
            decimal maxScore = query.SkillIds.Count * 100;

            foreach (var skillId in query.SkillIds)
            {
                var employeeSkill = employee.EmployeeSkills.FirstOrDefault(es => es.SkillId == skillId);

                if (employeeSkill != null)
                {
                    if (query.MinYearsExperience.HasValue && query.MinYearsExperience.Value > 0)
                    {
                        if (employeeSkill.YearsOfExperience >= query.MinYearsExperience.Value)
                        {
                            totalScore += 100;
                        }
                        else
                        {
                            var ratio = employeeSkill.YearsOfExperience / query.MinYearsExperience.Value;
                            totalScore += Math.Min(ratio * 100, 80);
                        }
                    }
                    else
                    {
                        totalScore += 100;
                    }
                }
            }

            return maxScore > 0 ? Math.Round((totalScore / maxScore) * 100, 1) : 0;
        }

        private string GetSkillMatchStatus(EmployeeSkill employeeSkill, SearchQuery query)
        {
            if (query.SkillIds == null || !query.SkillIds.Contains(employeeSkill.SkillId))
                return "Extra";

            if (query.MinYearsExperience.HasValue && query.MinYearsExperience.Value > 0)
            {
                return employeeSkill.YearsOfExperience >= query.MinYearsExperience.Value ? "Match" : "Partial";
            }

            return "Match";
        }

        // Keep existing search history methods...
        public async Task<List<SearchHistory>> GetSearchHistoryAsync(int userId, int count = 10)
        {
            return await _context.SearchHistories
                .Where(sh => sh.SearchedById == userId)
                .OrderByDescending(sh => sh.SearchDate)
                .Take(count)
                .ToListAsync();
        }

        public async Task<SearchHistory> SaveSearchAsync(int userId, string searchName, SearchQuery query)
        {
            var searchHistory = new SearchHistory
            {
                SearchedById = userId,
                SearchQuery = query.NaturalLanguageQuery ?? "",
                Filters = JsonSerializer.Serialize(query),
                ResultCount = 0,
                SearchDate = DateTime.Now,
                IsSaved = true,
                SavedSearchName = searchName
            };

            _context.SearchHistories.Add(searchHistory);
            await _context.SaveChangesAsync();
            return searchHistory;
        }

        public async Task<List<SearchHistory>> GetSavedSearchesAsync(int userId)
        {
            return await _context.SearchHistories
                .Where(sh => sh.SearchedById == userId && sh.IsSaved)
                .OrderByDescending(sh => sh.SearchDate)
                .ToListAsync();
        }

        public async Task<bool> DeleteSavedSearchAsync(int searchId)
        {
            var search = await _context.SearchHistories.FindAsync(searchId);
            if (search == null)
                return false;

            _context.SearchHistories.Remove(search);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

