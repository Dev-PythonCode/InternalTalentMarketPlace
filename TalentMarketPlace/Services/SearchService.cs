// SearchService.cs - WITH COMPREHENSIVE DEBUG LOGGING
// Enhanced to handle SpaCy NER experience context (tech-specific vs total)

using Microsoft.EntityFrameworkCore;
using TalentMarketPlace.Data;
using TalentMarketPlace.Services.Interfaces;
using System.Text.Json;
using TalentMarketPlace.Models;

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

       // ⭐ COMPLETE FIXED: NaturalLanguageSearchAsync method
        // Fixes: Location filtering, No-experience searches, Better user guidance

        public async Task<SearchResult> NaturalLanguageSearchAsync(string chatQuery)
        {
            Console.WriteLine("");
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║  NATURAL LANGUAGE SEARCH STARTED       ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.WriteLine($"Query: {chatQuery}");
            Console.WriteLine("");

            try
            {
                _logger.LogInformation("Processing natural language query: {Query}", chatQuery);

                Console.WriteLine("🔍 Step 1: Checking Python API health...");
                var isHealthy = await _pythonApiService.IsHealthyAsync();
                Console.WriteLine($"   Result: {(isHealthy ? "✅ HEALTHY" : "❌ UNHEALTHY")}");

                if (!isHealthy)
                {
                    Console.WriteLine("⚠️ Using fallback search (Python API unavailable)");
                    _logger.LogWarning("Python API is not available, using fallback search");
                    return await FallbackSearchAsync(chatQuery);
                }

                Console.WriteLine("🔍 Step 2: Calling Python API to parse query...");
                var parseResult = await _pythonApiService.ParseQueryAsync(chatQuery);

                Console.WriteLine("🔍 Step 3: Python API response received");
                Console.WriteLine($"   Error: {parseResult.Error ?? "none"}");
                Console.WriteLine($"   Parsed is null: {parseResult.Parsed == null}");

                if (parseResult.Parsed != null)
                {
                    Console.WriteLine($"   Skills: {string.Join(", ", parseResult.Parsed.Skills ?? new List<string>())}");
                    Console.WriteLine($"   Location: {parseResult.Parsed.Location ?? "none"}");
                    Console.WriteLine($"   MinYearsExperience: {parseResult.Parsed.MinYearsExperience?.ToString() ?? "none"}");
                    Console.WriteLine($"   ExperienceContext: {parseResult.Parsed.ExperienceContext?.Type ?? "none"}");
                }

                if (!string.IsNullOrEmpty(parseResult.Error))
                {
                    _logger.LogError("Python API error: {Error}", parseResult.Error);
                    return await FallbackSearchAsync(chatQuery);
                }

                Console.WriteLine("🔍 Step 4: Extracting values from parse result...");

                // ⭐ Extract all criteria
                var requiredSkills = parseResult.Parsed.Skills?.ToList() ?? new List<string>();
                var categorySkills = parseResult.Parsed.CategorySkills ?? new List<string>();
                var minYears = parseResult.Parsed.MinYearsExperience;
                var expOperator = parseResult.Parsed.ExperienceOperator ?? "gte";
                var experienceContext = parseResult.Parsed.ExperienceContext;
                var location = parseResult.Parsed.Location;

                Console.WriteLine($"   requiredSkills: {string.Join(", ", requiredSkills)}");
                Console.WriteLine($"   location: {location ?? "none"}");
                Console.WriteLine($"   minYears: {minYears?.ToString() ?? "none"}");
                Console.WriteLine($"   expOperator: {expOperator}");
                Console.WriteLine($"   experienceContext: {experienceContext?.Type ?? "none"}");
                Console.WriteLine("");

                // ⭐ FIX 3: Check what criteria we have
                var hasSkills = requiredSkills.Any() || categorySkills.Any();
                var hasLocation = !string.IsNullOrEmpty(location);
                var hasExperience = minYears.HasValue && minYears.Value > 0;

                // Determine whether skills should be treated as OR (either) or AND (all)
                var skillsAreOr = false;
                if (!string.IsNullOrEmpty(parseResult.OriginalQuery))
                {
                    var oq = parseResult.OriginalQuery;
                    if (oq.IndexOf(" or ", StringComparison.OrdinalIgnoreCase) >= 0 || oq.IndexOf(" either ", StringComparison.OrdinalIgnoreCase) >= 0 || oq.Contains("/"))
                    {
                        skillsAreOr = true;
                    }
                }

                Console.WriteLine($"   SkillsAreOr: {skillsAreOr}");

                Console.WriteLine($"🔍 Search criteria:");
                Console.WriteLine($"   Has skills: {hasSkills}");
                Console.WriteLine($"   Has location: {hasLocation}");
                Console.WriteLine($"   Has experience: {hasExperience}");
                Console.WriteLine("");

                // ⭐ FIX 3: Better empty query handling
                if (!hasSkills && !hasLocation)
                {
                    _logger.LogWarning("No skills or location found in query");
                    return new SearchResult
                    {
                        Employees = new List<EmployeeSearchResult>(),
                        TotalCount = 0,
                        PageNumber = 1,
                        PageSize = 50,
                        AppliedFilters = new List<string> { "No search criteria detected" },
                        ParsedQuery = chatQuery,
                        Message = "💡 Please specify skills (e.g., 'Python developers'), location (e.g., 'in Chennai'), or experience (e.g., '5 years')"
                    };
                }

                // ⭐ Build query based on available criteria
                var employeesQuery = _context.Employees
                    .Include(e => e.Team)
                    .Include(e => e.User)
                    .Include(e => e.EmployeeSkills)
                        .ThenInclude(es => es.Skill)
                    .Where(e => e.User.IsActive)
                    .AsQueryable();

                // ⭐ Apply skill filter (if skills specified)
                if (hasSkills)
                {
                    var allTargetSkills = requiredSkills.Concat(categorySkills).Distinct().ToList();
                    employeesQuery = employeesQuery.Where(e => e.EmployeeSkills.Any(es =>
                        allTargetSkills.Contains(es.Skill.SkillName)
                    ));
                    Console.WriteLine($"🔍 Skill filter applied: {string.Join(", ", allTargetSkills)}");
                }

                // ⭐ FIX 1: Apply location filter with case-insensitive comparison
                if (hasLocation)
                {
                    var searchLocation = location!.Trim();
                    employeesQuery = employeesQuery.Where(e =>
                        e.Location != null &&
                        e.Location.ToLower() == searchLocation.ToLower()
                    );
                    Console.WriteLine($"🔍 Location filter applied: {searchLocation}");
                }

                // ⭐ Apply availability filter (now supports structured availability_status)
                var avail = parseResult.Parsed.AvailabilityStatus?.Status;
                if (!string.IsNullOrEmpty(avail))
                {
                    employeesQuery = employeesQuery.Where(e => e.AvailabilityStatus == avail);
                    Console.WriteLine($"🔍 Availability filter applied: {avail}");
                }

                var employees = await employeesQuery.ToListAsync();
                _logger.LogInformation("Found {Count} employees matching filters", employees.Count);
                Console.WriteLine($"🔍 Found {employees.Count} employees after applying filters");
                Console.WriteLine("");

                // ⭐ FIX 2: Don't pre-filter by experience - let scoring handle it
                // Build results with scoring
                var results = new List<EmployeeSearchResult>();
                
                foreach (var employee in employees)
                {
                    // Calculate match score (handles experience requirements internally)
                    var matchResult = CalculateAdvancedMatchWithContext(
                        employee,
                        requiredSkills,
                        categorySkills,
                        minYears,
                        expOperator,
                        experienceContext,
                        skillsAreOr
                    );

                    // ⭐ Include employee if:
                    // 1. They have a match > 0 when skills are required, OR
                    // 2. No skills required (location-only search)
                    bool shouldInclude = hasSkills ? (matchResult.MatchPercentage > 0) : true;

                    if (shouldInclude)
                    {
                        var skillTags = employee.EmployeeSkills.Select(es => new SkillTag
                        {
                            SkillName = es.Skill.SkillName,
                            YearsOfExperience = es.YearsOfExperience,
                            ProficiencyLevel = es.ProficiencyLevel ?? "Unknown",
                            MatchStatus = hasSkills 
                                ? GetAdvancedSkillMatchStatus(es, requiredSkills, categorySkills, minYears, experienceContext)
                                : "Available",
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

                        _logger.LogInformation("Employee {Id} ({Name}) included with {Match}% match",
                            employee.EmployeeId, employee.FullName, matchResult.MatchPercentage);
                    }
                }

                // Sort by match percentage (or name if no skills)
                results = hasSkills 
                    ? results.OrderByDescending(r => r.MatchPercentage).ToList()
                    : results.OrderBy(r => r.FullName).ToList();

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
                    ParsedQuery = chatQuery,
                    Message = results.Any() ? null : "No employees found matching your criteria. Try adjusting your search."
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

        // ⭐ COMPLETE UPDATED METHOD with Debug Logging
        private (decimal MatchPercentage, bool MeetsRequirements) CalculateAdvancedMatchWithContext(
            Employee employee,
            List<string> requiredSkills,
            List<string> categorySkills,
            decimal? minYears,
            string experienceOperator,
            ExperienceContext? experienceContext,
            bool skillsAreOr)
        {
            // Debug logging
            Console.WriteLine($"");
            Console.WriteLine($"🔍 === CALCULATING MATCH FOR {employee.FullName} ===");
            Console.WriteLine($"   Required Skills: {string.Join(", ", requiredSkills)}");
            Console.WriteLine($"   Min Years: {minYears?.ToString() ?? ""}");
            Console.WriteLine($"   Experience Context: {experienceContext?.Type ?? "none"}");
            Console.WriteLine($"   Operator: {experienceOperator}");

            if (!requiredSkills.Any() && !categorySkills.Any())
            {
                Console.WriteLine($"   ⚠️ No skills required, returning 0%");
                return (0, true);
            }
            decimal totalScore = 0;
            decimal maxScore = 0;
            bool meetsAllRequirements = true;

            if (skillsAreOr)
            {
                // OR semantics: best single-skill match wins (max of per-skill scores)
                Console.WriteLine($"   ⚖️ Applying OR semantics for skills (best match wins)");
                decimal bestSkillScore = 0;
                foreach (var skillName in requiredSkills)
                {
                    Console.WriteLine($"   📊 Checking skill (OR): {skillName}");
                    var employeeSkill = employee.EmployeeSkills
                        .FirstOrDefault(es => es.Skill.SkillName.Equals(skillName, StringComparison.OrdinalIgnoreCase));

                    decimal skillScore = 0;

                    if (employeeSkill != null)
                    {
                        Console.WriteLine($"      ✅ Employee has {skillName}: {employeeSkill.YearsOfExperience} years");

                        if (minYears.HasValue && minYears.Value > 0)
                        {
                            decimal yearsToCheck = experienceContext?.Type == "skill_specific"
                                ? employeeSkill.YearsOfExperience
                                : employee.YearsOfExperience;

                            Console.WriteLine($"      📌 Using {(experienceContext?.Type == "skill_specific" ? "SKILL-SPECIFIC" : "TOTAL")} experience: {yearsToCheck} years");

                            bool meetsExperience = CheckExperienceOperator(yearsToCheck, minYears.Value, experienceOperator);
                            if (meetsExperience)
                            {
                                skillScore = 100;
                                Console.WriteLine($"      ✅ MEETS requirement ({yearsToCheck} >= {minYears}) → 100 points");
                            }
                            else
                            {
                                var ratio = yearsToCheck / minYears.Value;
                                if (experienceContext?.Type == "skill_specific")
                                {
                                    if (ratio >= 0.8m) skillScore = 70;
                                    else if (ratio >= 0.6m) skillScore = 50;
                                    else if (ratio >= 0.4m) skillScore = 30;
                                    else skillScore = 10;
                                }
                                else
                                {
                                    if (ratio >= 0.7m) skillScore = 60;
                                    else if (ratio >= 0.5m) skillScore = 40;
                                    else skillScore = 20;
                                }
                                Console.WriteLine($"      ⚠️ Partial experience → {skillScore} points (ratio {ratio:P1})");
                            }
                        }
                        else
                        {
                            skillScore = 100;
                            Console.WriteLine($"      ✅ No experience requirement → 100 points");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"      ❌ Employee does NOT have {skillName} → 0 points");
                    }

                    if (skillScore > bestSkillScore) bestSkillScore = skillScore;
                }

                totalScore += bestSkillScore;
                maxScore += 100;

                // Category skills can still add value; treat them separately and combine by taking max
                if (categorySkills.Any())
                {
                    Console.WriteLine($"   📊 Checking category skills: {string.Join(", ", categorySkills)}");
                    var matchedCategorySkills = employee.EmployeeSkills
                        .Where(es => categorySkills.Contains(es.Skill.SkillName, StringComparer.OrdinalIgnoreCase))
                        .ToList();

                    if (matchedCategorySkills.Any())
                    {
                        Console.WriteLine($"      ✅ Has category skills: {string.Join(", ", matchedCategorySkills.Select(s => s.Skill.SkillName))}");

                        // ⭐ FIX: Check experience requirement for category skills too
                        decimal categoryScore = 0;
                        if (minYears.HasValue && minYears.Value > 0)
                        {
                            decimal yearsToCheck;

                            if (experienceContext?.Type == "skill_specific")
                            {
                                yearsToCheck = matchedCategorySkills.Max(cs => cs.YearsOfExperience);
                                Console.WriteLine($"      📌 Using SKILL-SPECIFIC experience: {yearsToCheck} years (max from category skills)");
                            }
                            else
                            {
                                yearsToCheck = employee.YearsOfExperience;
                                Console.WriteLine($"      📌 Using TOTAL experience: {yearsToCheck} years");
                            }

                            bool meetsExperience = CheckExperienceOperator(
                                yearsToCheck,
                                minYears.Value,
                                experienceOperator
                            );

                            if (meetsExperience)
                            {
                                categoryScore = 100;
                                Console.WriteLine($"      ✅ MEETS experience requirement ({yearsToCheck} >= {minYears}) → 100 points");
                            }
                            else
                            {
                                var ratio = yearsToCheck / minYears.Value;

                                if (experienceContext?.Type == "skill_specific")
                                {
                                    if (ratio >= 0.8m) categoryScore = 70;
                                    else if (ratio >= 0.6m) categoryScore = 50;
                                    else if (ratio >= 0.4m) categoryScore = 30;
                                    else categoryScore = 10;
                                }
                                else
                                {
                                    if (ratio >= 0.7m) categoryScore = 60;
                                    else if (ratio >= 0.5m) categoryScore = 40;
                                    else categoryScore = 20;
                                }

                                Console.WriteLine($"      ⚠️ Partial experience → {categoryScore} points (ratio {ratio:P1})");
                            }
                        }
                        else
                        {
                            categoryScore = 100;
                            Console.WriteLine($"      ✅ No experience requirement → 100 points");
                        }

                        // Take the better of skill match vs category match
                        totalScore = Math.Max(totalScore, categoryScore);
                        Console.WriteLine($"      📊 Combined score (max): {totalScore}");
                    }
                    else
                    {
                        Console.WriteLine($"      ❌ No category skills → +0 points");
                    }
                }
            }
            else
            {
                // AND semantics (original behavior): sum across skills
                // Score for required skills
                foreach (var skillName in requiredSkills)
                {
                    maxScore += 100;
                    Console.WriteLine($"   📊 Checking skill: {skillName}");

                    var employeeSkill = employee.EmployeeSkills
                        .FirstOrDefault(es => es.Skill.SkillName.Equals(skillName, StringComparison.OrdinalIgnoreCase));

                    if (employeeSkill != null)
                    {
                        Console.WriteLine($"      ✅ Employee has {skillName}: {employeeSkill.YearsOfExperience} years");

                        // Check experience requirement based on context
                        if (minYears.HasValue && minYears.Value > 0)
                        {
                            decimal yearsToCheck;

                            // ⭐ Use context to determine which experience to check
                            if (experienceContext?.Type == "skill_specific")
                            {
                                // Check skill-specific experience
                                yearsToCheck = employeeSkill.YearsOfExperience;
                                Console.WriteLine($"      📌 Using SKILL-SPECIFIC experience: {yearsToCheck} years");
                            }
                            else
                            {
                                // Check total experience
                                yearsToCheck = employee.YearsOfExperience;
                                Console.WriteLine($"      📌 Using TOTAL experience: {yearsToCheck} years");
                            }

                            bool meetsExperience = CheckExperienceOperator(
                                yearsToCheck,
                                minYears.Value,
                                experienceOperator
                            );

                            if (meetsExperience)
                            {
                                // Perfect match - meets or exceeds requirement
                                totalScore += 100;
                                Console.WriteLine($"      ✅ MEETS requirement ({yearsToCheck} >= {minYears}) → +100 points");
                            }
                            else
                            {
                                // ⭐ STRICTER partial scoring based on experience gap
                                var ratio = yearsToCheck / minYears.Value;
                                decimal points = 0;

                                Console.WriteLine($"      ⚠️ Does NOT meet requirement ({yearsToCheck} < {minYears})");
                                Console.WriteLine($"      📊 Ratio: {ratio:P1} ({yearsToCheck}/{minYears})");

                                if (experienceContext?.Type == "skill_specific")
                                {
                                    Console.WriteLine($"      🎯 Applying STRICT skill-specific penalties:");

                                    // For skill-specific: MUCH stricter penalties
                                    if (ratio >= 0.8m) // 80-99% (e.g., 4 out of 5 years)
                                    {
                                        points = 70;
                                        Console.WriteLine($"         80-99% of required → 70 points");
                                    }
                                    else if (ratio >= 0.6m) // 60-79% (e.g., 3 out of 5 years)
                                    {
                                        points = 50;
                                        Console.WriteLine($"         60-79% of required → 50 points");
                                    }
                                    else if (ratio >= 0.4m) // 40-59% (e.g., 2 out of 5 years)
                                    {
                                        points = 30;
                                        Console.WriteLine($"         40-59% of required → 30 points");
                                    }
                                    else // < 40% (e.g., 1 out of 5 years)
                                    {
                                        points = 10;
                                        Console.WriteLine($"         <40% of required → 10 points");
                                    }

                                    totalScore += points;
                                    Console.WriteLine($"      ➕ Added {points} points (total so far: {totalScore}/{maxScore})");
                                }
                                else
                                {
                                    Console.WriteLine($"      🎯 Applying LENIENT total experience scoring:");

                                    // For total experience: slightly more lenient
                                    if (ratio >= 0.7m)
                                    {
                                        points = 60;
                                        Console.WriteLine($"         70%+ of required → 60 points");
                                    }
                                    else if (ratio >= 0.5m)
                                    {
                                        points = 40;
                                        Console.WriteLine($"         50-69% of required → 40 points");
                                    }
                                    else
                                    {
                                        points = 20;
                                        Console.WriteLine($"         <50% of required → 20 points");
                                    }

                                    totalScore += points;
                                    Console.WriteLine($"      ➕ Added {points} points (total so far: {totalScore}/{maxScore})");
                                }

                                meetsAllRequirements = false;
                            }
                        }
                        else
                        {
                            // No experience requirement - just having the skill is 100%
                            totalScore += 100;
                            Console.WriteLine($"      ✅ No experience requirement → +100 points");
                        }
                    }
                    else
                    {
                        // Doesn't have the skill at all - 0 points
                        Console.WriteLine($"      ❌ Employee does NOT have {skillName} → +0 points");
                        meetsAllRequirements = false;
                    }
                }

                // Score for category skills
                // ⭐ FIX: Only score category skills if:
                //   1. No required skills were specified, OR
                //   2. At least one required skill was found
                bool shouldScoreCategorySkills = !requiredSkills.Any() || (totalScore > 0);
                
                if (categorySkills.Any() && shouldScoreCategorySkills)
                {
                    maxScore += 100;
                    Console.WriteLine($"   📊 Checking category skills: {string.Join(", ", categorySkills)}");
                }
                else if (categorySkills.Any() && !shouldScoreCategorySkills)
                {
                    // ⭐ Skip category skills if required skills were specified but not found
                    Console.WriteLine($"   ⚠️ Skipping category skills: required skill(s) not found (requiredSkills: {string.Join(", ", requiredSkills)})");
                }

                if (categorySkills.Any() && shouldScoreCategorySkills)
                {
                    var matchedCategorySkills = employee.EmployeeSkills
                        .Where(es => categorySkills.Contains(es.Skill.SkillName, StringComparer.OrdinalIgnoreCase))
                        .ToList();

                    if (matchedCategorySkills.Any())
                    {
                        Console.WriteLine($"      ✅ Has category skills: {string.Join(", ", matchedCategorySkills.Select(s => s.Skill.SkillName))}");

                        // ⭐ FIX: Check experience requirement for category skills too
                        if (minYears.HasValue && minYears.Value > 0)
                        {
                            decimal yearsToCheck;

                            // Use context to determine which experience to check
                            if (experienceContext?.Type == "skill_specific")
                            {
                                // For category skills, use the max years from any matching skill
                                yearsToCheck = matchedCategorySkills.Max(cs => cs.YearsOfExperience);
                                Console.WriteLine($"      📌 Using SKILL-SPECIFIC experience: {yearsToCheck} years (max from category skills)");
                            }
                            else
                            {
                                // Check total experience
                                yearsToCheck = employee.YearsOfExperience;
                                Console.WriteLine($"      📌 Using TOTAL experience: {yearsToCheck} years");
                            }

                            bool meetsExperience = CheckExperienceOperator(
                                yearsToCheck,
                                minYears.Value,
                                experienceOperator
                            );

                            if (meetsExperience)
                            {
                                // Perfect match - meets or exceeds requirement
                                totalScore += 100;
                                Console.WriteLine($"      ✅ MEETS experience requirement ({yearsToCheck} >= {minYears}) → +100 points");
                            }
                            else
                            {
                                // ⭐ Apply partial scoring based on experience gap
                                var ratio = yearsToCheck / minYears.Value;
                                decimal points = 0;

                                Console.WriteLine($"      ⚠️ Does NOT meet experience requirement ({yearsToCheck} < {minYears})");
                                Console.WriteLine($"      📊 Ratio: {ratio:P1} ({yearsToCheck}/{minYears})");

                                if (experienceContext?.Type == "skill_specific")
                                {
                                    Console.WriteLine($"      🎯 Applying STRICT skill-specific penalties:");

                                    if (ratio >= 0.8m)
                                    {
                                        points = 70;
                                        Console.WriteLine($"         80-99% of required → 70 points");
                                    }
                                    else if (ratio >= 0.6m)
                                    {
                                        points = 50;
                                        Console.WriteLine($"         60-79% of required → 50 points");
                                    }
                                    else if (ratio >= 0.4m)
                                    {
                                        points = 30;
                                        Console.WriteLine($"         40-59% of required → 30 points");
                                    }
                                    else
                                    {
                                        points = 10;
                                        Console.WriteLine($"         <40% of required → 10 points");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"      🎯 Applying LENIENT total experience scoring:");

                                    if (ratio >= 0.7m)
                                    {
                                        points = 60;
                                        Console.WriteLine($"         70%+ of required → 60 points");
                                    }
                                    else if (ratio >= 0.5m)
                                    {
                                        points = 40;
                                        Console.WriteLine($"         50-69% of required → 40 points");
                                    }
                                    else
                                    {
                                        points = 20;
                                        Console.WriteLine($"         <50% of required → 20 points");
                                    }
                                }

                                totalScore += points;
                                Console.WriteLine($"      ➕ Added {points} points (total so far: {totalScore}/{maxScore})");
                                meetsAllRequirements = false;
                            }
                        }
                        else
                        {
                            // No experience requirement - just having the skill is 100%
                            totalScore += 100;
                            Console.WriteLine($"      ✅ No experience requirement → +100 points");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"      ❌ No category skills → +0 points");
                        meetsAllRequirements = false;
                    }
                }

                var matchPercentage = maxScore > 0 ? (totalScore / maxScore) * 100 : 0;

                Console.WriteLine($"   ");
                Console.WriteLine($"   📊 FINAL SCORE: {totalScore}/{maxScore} = {matchPercentage:F1}%");
                Console.WriteLine($"   ✅ Meets all requirements: {meetsAllRequirements}");
                Console.WriteLine($"===========================================");

                return (matchPercentage, meetsAllRequirements);
            }

            // For OR branch, compute final percentage
            var finalMatchPercentage = maxScore > 0 ? (totalScore / maxScore) * 100 : 0;

            Console.WriteLine($"   ");
            Console.WriteLine($"   📊 FINAL SCORE: {totalScore}/{maxScore} = {finalMatchPercentage:F1}%");
            Console.WriteLine($"   ✅ Meets all requirements: {meetsAllRequirements}");
            Console.WriteLine($"===========================================");

            return (finalMatchPercentage, meetsAllRequirements);
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