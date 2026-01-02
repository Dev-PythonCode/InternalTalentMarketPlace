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
                    Console.WriteLine($"   CategorySkills: {string.Join(", ", parseResult.Parsed.CategorySkills ?? new List<string>())}");
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

                // ⭐ Use skill classifications directly from Python API (now correctly separating mandatory/optional)
                var requiredSkills = parseResult.Parsed.MandatorySkills?.ToList() ?? new List<string>();
                var categorySkills = parseResult.Parsed.OptionalSkills?.ToList() ?? new List<string>();
                
                // ⭐ NEW: Handle mandatory categories - employee needs ANY skill from the category (not ALL)
                var mandatoryCategories = parseResult.Parsed.MandatoryCategories?.ToList() ?? new List<string>();
                var expandedCategorySkills = parseResult.Parsed.CategorySkills ?? new List<string>();
                
                Console.WriteLine($"🔍 DEBUG: mandatoryCategories count: {mandatoryCategories.Count}");
                Console.WriteLine($"🔍 DEBUG: expandedCategorySkills count: {expandedCategorySkills.Count}");
                
                // Store category skills separately - don't add them all to requiredSkills
                // They will be handled specially in filtering and scoring
                var categorySkillsByCategory = new Dictionary<string, List<string>>();
                if (mandatoryCategories.Any() && expandedCategorySkills.Any())
                {
                    Console.WriteLine($"🔍 Mandatory categories detected: {string.Join(", ", mandatoryCategories)}");
                    Console.WriteLine($"🔍 Category skills: {string.Join(", ", expandedCategorySkills)}");
                    
                    // For now, store all category skills together
                    // In a more sophisticated version, we'd map each category to its specific skills
                    foreach (var category in mandatoryCategories)
                    {
                        // Filter out non-category entries (like "any cloud technology")
                        if (!category.ToLower().Contains("any ") && !category.ToLower().Contains(" skill"))
                        {
                            categorySkillsByCategory[category] = expandedCategorySkills.ToList();
                            Console.WriteLine($"🔍 Added category: {category} with {expandedCategorySkills.Count} skills");
                        }
                    }
                }
                
                Console.WriteLine($"🔍 DEBUG: categorySkillsByCategory count: {categorySkillsByCategory.Count}");
                
                // If Python API didn't return separated skills, fall back to old behavior
                if (!requiredSkills.Any() && !categorySkills.Any() && !mandatoryCategories.Any())
                {
                    requiredSkills = parseResult.Parsed.Skills?.ToList() ?? new List<string>();
                    categorySkills = expandedCategorySkills;
                    
                    // ⭐ Parse the original query to separate mandatory from nice-to-have skills (fallback)
                    (requiredSkills, categorySkills) = SeparateMandatoryAndNiceToHaveSkills(
                        chatQuery,
                        requiredSkills,
                        categorySkills
                    );
                }
                
                var minYears = parseResult.Parsed.MinYearsExperience;
                var expOperator = parseResult.Parsed.ExperienceOperator ?? "gte";
                var experienceContext = parseResult.Parsed.ExperienceContext;
                var location = parseResult.Parsed.Location;

                Console.WriteLine($"   requiredSkills (Mandatory): {string.Join(", ", requiredSkills)}");
                Console.WriteLine($"   mandatoryCategories: {string.Join(", ", mandatoryCategories)}");
                Console.WriteLine($"   categorySkills (Nice-to-Have): {string.Join(", ", categorySkills)}");
                Console.WriteLine($"   location: {location ?? "none"}");
                Console.WriteLine($"   minYears: {minYears?.ToString() ?? "none"}");
                Console.WriteLine($"   expOperator: {expOperator}");
                Console.WriteLine($"   experienceContext: {experienceContext?.Type ?? "none"}");
                Console.WriteLine("");

                // ⭐ FIX: Check what criteria we have (include categories)
                var hasSkills = requiredSkills.Any() || categorySkillsByCategory.Any();
                var hasLocation = !string.IsNullOrEmpty(location);
                var hasExperience = minYears.HasValue && minYears.Value > 0;

                // ⭐ Use skill_operator from Python API (defaults to "AND" if not provided)
                var skillOperator = parseResult.Parsed.SkillOperator ?? "AND";
                var skillsAreOr = skillOperator.Equals("OR", StringComparison.OrdinalIgnoreCase);

                Console.WriteLine($"   SkillOperator: {skillOperator}");
                Console.WriteLine($"   SkillsAreOr: {skillsAreOr}");

                Console.WriteLine($"🔍 Search criteria:");
                Console.WriteLine($"   Has mandatory skills: {hasSkills}");
                Console.WriteLine($"   Has nice-to-have skills: {categorySkills.Any()}");
                Console.WriteLine($"   Has location: {hasLocation}");
                Console.WriteLine($"   Has experience: {hasExperience}");
                Console.WriteLine("");

                // ⭐ FIX: Better empty query handling
                if (!hasSkills && !hasLocation)
                {
                    _logger.LogWarning("No mandatory skills or location found in query");
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
                            .ThenInclude(s => s.SkillAliases)
                    .Where(e => e.User.IsActive)
                    .AsQueryable();

                // ⭐ Apply MANDATORY skill filter (employees MUST have at least one mandatory skill)
                // Case-insensitive matching to handle variations like "SQL Server" vs "sql server"
                // Also check skill aliases to handle normalized names (e.g., "SQL" matches "SQL Server")
                if (requiredSkills.Any())
                {
                    Console.WriteLine($"🔍 DEBUG: Looking for required skills: {string.Join(", ", requiredSkills)}");
                    
                    employeesQuery = employeesQuery.Where(e => e.EmployeeSkills.Any(es =>
                        requiredSkills.Any(rs => 
                            // Match skill name directly (case-insensitive using ToUpper for SQL translation)
                            rs.ToUpper() == es.Skill.SkillName.ToUpper() ||
                            // Also match against skill aliases
                            es.Skill.SkillAliases.Any(sa => rs.ToUpper() == sa.AliasName.ToUpper())
                        )
                    ));
                    Console.WriteLine($"🔍 Mandatory skill filter applied: {string.Join(", ", requiredSkills)}");
                }
                
                // ⭐ Apply MANDATORY CATEGORY filter (employees MUST have at least ONE skill from category)
                if (categorySkillsByCategory.Any())
                {
                    foreach (var categoryEntry in categorySkillsByCategory)
                    {
                        var categoryName = categoryEntry.Key;
                        var categorySkillList = categoryEntry.Value;
                        
                        Console.WriteLine($"🔍 DEBUG: Looking for at least one skill from category '{categoryName}': {string.Join(", ", categorySkillList)}");
                        
                        employeesQuery = employeesQuery.Where(e => e.EmployeeSkills.Any(es =>
                            categorySkillList.Any(cs => 
                                cs.ToUpper() == es.Skill.SkillName.ToUpper() ||
                                es.Skill.SkillAliases.Any(sa => cs.ToUpper() == sa.AliasName.ToUpper())
                            )
                        ));
                        
                        Console.WriteLine($"🔍 Category filter applied: {categoryName} (any of {categorySkillList.Count} skills)");
                    }
                }

                // ⭐ Apply location filter with case-insensitive comparison
                if (hasLocation)
                {
                    var searchLocation = location!.Trim();
                    employeesQuery = employeesQuery.Where(e =>
                        e.Location != null &&
                        e.Location.ToLower() == searchLocation.ToLower()
                    );
                    Console.WriteLine($"🔍 Location filter applied: {searchLocation}");
                }

                // ⭐ Apply availability filter
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

                // Build results with scoring
                var results = new List<EmployeeSearchResult>();

                foreach (var employee in employees)
                {
                    // ⭐ UNIFIED: Calculate match score using the same logic as EmployeeService
                    // Mandatory skills AND category matches count toward the score
                    var matchResult = CalculateUnifiedMatchScoreWithCategories(
                        employee,
                        requiredSkills,
                        categorySkillsByCategory,
                        categorySkills,
                        minYears,
                        expOperator,
                        skillsAreOr  // ⭐ NEW: Pass OR operator flag
                    );

                    // Include employee if they have at least one mandatory skill match
                    // If no skills were specified but location/availability filters were applied, include employees that match those
                    bool shouldInclude = hasSkills 
                        ? (matchResult.MatchPercentage > 0)  // Must have skill match if skills were specified
                        : (hasLocation || hasExperience || !string.IsNullOrEmpty(location) || !string.IsNullOrEmpty(avail));  // Otherwise just check if other filters were applied
                    
                    Console.WriteLine($"   {employee.FullName}: MatchScore={matchResult.MatchPercentage}%, ShouldInclude={shouldInclude}");

                    if (shouldInclude)
                    {
                        var skillTags = employee.EmployeeSkills.Select(es =>
                        {
                            var matchStatus = hasSkills
                                ? GetUnifiedSkillMatchStatus(es, requiredSkills, categorySkills, minYears)
                                : "Available";
                            
                            // ⭐ If "Extra", check if skill is in any category
                            if (matchStatus == "Extra" && categorySkillsByCategory.Any())
                            {
                                var skillNameUpper = es.Skill.SkillName.ToUpper();
                                foreach (var categoryEntry in categorySkillsByCategory)
                                {
                                    if (categoryEntry.Value.Any(cs => cs.ToUpper() == skillNameUpper || 
                                        es.Skill.SkillAliases.Any(sa => sa.AliasName.ToUpper() == cs.ToUpper())))
                                    {
                                        matchStatus = "Match"; // Skill is in category, mark as Match
                                        break;
                                    }
                                }
                            }
                            
                            return new SkillTag
                            {
                                SkillName = es.Skill.SkillName,
                                YearsOfExperience = es.YearsOfExperience,
                                ProficiencyLevel = es.ProficiencyLevel ?? "Unknown",
                                MatchStatus = matchStatus,
                                LastUsedDate = es.LastUsedDate
                            };
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

                // Build applied filters showing categories and explicit skills separately
                var appliedFilters = BuildAppliedFiltersWithCategories(
                    requiredSkills, 
                    mandatoryCategories,
                    expandedCategorySkills,
                    categorySkills, 
                    minYears, 
                    experienceContext, 
                    location
                );

                return new SearchResult
                {
                    Employees = results,
                    TotalCount = results.Count,
                    PageNumber = 1,
                    PageSize = 50,
                    AppliedFilters = appliedFilters,
                    ExtractedSkills = parseResult.Parsed.Skills,
                    ParsedQuery = chatQuery,
                    CategorySkills = categorySkillsByCategory.Any() ? categorySkillsByCategory : null, // ⭐ NEW: Pass category skills to UI
                    Message = results.Any() ? null : "No employees found matching your criteria. Try adjusting your search."
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in natural language search: {Message}", ex.Message);
                Console.WriteLine($"❌ EXCEPTION in NaturalLanguageSearchAsync: {ex.Message}");
                Console.WriteLine($"   Stack trace: {ex.StackTrace}");
                
                // Return a more appropriate error message instead of "API unavailable"
                return new SearchResult
                {
                    Employees = new List<EmployeeSearchResult>(),
                    TotalCount = 0,
                    PageNumber = 1,
                    PageSize = 50,
                    AppliedFilters = new List<string>(),
                    ExtractedSkills = new List<string>(),
                    ParsedQuery = chatQuery,
                    Message = $"An error occurred while processing your search: {ex.Message}. Please try again or use different keywords."
                };
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

        // ⭐ NEW: Build applied filters showing categories separately from explicit skills
        private List<string> BuildAppliedFiltersWithCategories(
            List<string> mandatorySkills,
            List<string> mandatoryCategories,
            List<string> expandedCategorySkills,
            List<string> optionalSkills,
            decimal? minYears,
            ExperienceContext? expContext,
            string? location)
        {
            var filters = new List<string>();

            // Show mandatory explicit skills
            if (mandatorySkills?.Any() == true)
            {
                filters.Add($"Mandatory Skills: {string.Join(", ", mandatorySkills)}");
            }

            // Show mandatory categories with expanded skills
            if (mandatoryCategories?.Any() == true)
            {
                foreach (var category in mandatoryCategories)
                {
                    // Show category with some example skills (limit to first 3-4 for readability)
                    var exampleSkills = expandedCategorySkills.Take(4).ToList();
                    var skillsText = string.Join(", ", exampleSkills);
                    if (expandedCategorySkills.Count > 4)
                    {
                        skillsText += $" (any {category} skill)";
                    }
                    filters.Add($"{category}: {skillsText}");
                }
            }

            // Show nice-to-have skills
            if (optionalSkills?.Any() == true)
            {
                filters.Add($"Nice-to-Have Skills: {string.Join(", ", optionalSkills)}");
            }

            if (minYears.HasValue)
            {
                var years = minYears.Value;
                var expType = expContext?.Type == "skill_specific"
                    ? $"in {expContext.Skill}"
                    : "total experience";
                filters.Add($"Experience: {years}+ years {expType}");
            }

            if (!string.IsNullOrEmpty(location))
            {
                filters.Add($"Location: {location}");
            }

            return filters;
        }

        // ⭐ UPDATED: Build applied filters - show mandatory and nice-to-have separately
        private List<string> BuildAppliedFilters(
            List<string> mandatorySkills,
            List<string> optionalSkills,
            decimal? minYears,
            ExperienceContext? expContext,
            string? location)
        {
            var filters = new List<string>();

            // Show mandatory skills (properly labeled)
            if (mandatorySkills?.Any() == true)
            {
                filters.Add($"Mandatory Skills: {string.Join(", ", mandatorySkills)}");
            }

            // Show nice-to-have skills (properly labeled)
            if (optionalSkills?.Any() == true)
            {
                filters.Add($"Nice-to-Have Skills: {string.Join(", ", optionalSkills)}");
            }

            if (minYears.HasValue)
            {
                var years = minYears.Value;
                var expType = expContext?.Type == "skill_specific"
                    ? $"in {expContext.Skill}"
                    : "total experience";
                filters.Add($"Experience: {years}+ years {expType}");
            }

            if (!string.IsNullOrEmpty(location))
            {
                filters.Add($"Location: {location}");
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
            Console.WriteLine($"");
            Console.WriteLine($"🔍 === CALCULATING MATCH FOR {employee.FullName} ===");
            Console.WriteLine($"   Required Skills (Mandatory): {string.Join(", ", requiredSkills)}");
            Console.WriteLine($"   Nice-to-Have Skills (Category): {string.Join(", ", categorySkills)}");
            Console.WriteLine($"   Min Years: {minYears?.ToString() ?? ""}");
            Console.WriteLine($"   Experience Context: {experienceContext?.Type ?? "none"}");
            Console.WriteLine($"   Operator: {experienceOperator}");

            if (!requiredSkills.Any())
            {
                Console.WriteLine($"   ⚠️ No mandatory skills required, returning 0%");
                return (0, true);
            }

            decimal totalScore = 0;
            decimal maxScore = 0;
            bool meetsAllRequirements = true;

            // ⭐ REFINED: Only consider MANDATORY skills for scoring
            // Category/Nice-to-have skills are IGNORED in scoring calculation

            Console.WriteLine($"   ⚖️ Scoring ONLY mandatory skills (nice-to-have skills ignored)");

            foreach (var skillName in requiredSkills)
            {
                maxScore += 100;
                Console.WriteLine($"   📊 Checking MANDATORY skill: {skillName}");

                var employeeSkill = employee.EmployeeSkills
                    .FirstOrDefault(es => es.Skill.SkillName.Equals(skillName, StringComparison.OrdinalIgnoreCase));

                if (employeeSkill != null)
                {
                    Console.WriteLine($"      ✅ Employee has {skillName}: {employeeSkill.YearsOfExperience} years");

                    if (minYears.HasValue && minYears.Value > 0)
                    {
                        decimal yearsToCheck;

                        if (experienceContext?.Type == "skill_specific")
                        {
                            yearsToCheck = employeeSkill.YearsOfExperience;
                            Console.WriteLine($"      📌 Using SKILL-SPECIFIC experience: {yearsToCheck} years");
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
                            totalScore += 100;
                            Console.WriteLine($"      ✅ MEETS requirement ({yearsToCheck} >= {minYears}) → +100 points");
                        }
                        else
                        {
                            var ratio = yearsToCheck / minYears.Value;
                            decimal points = 0;

                            Console.WriteLine($"      ⚠️ Does NOT meet requirement ({yearsToCheck} < {minYears})");
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
                        totalScore += 100;
                        Console.WriteLine($"      ✅ No experience requirement → +100 points");
                    }
                }
                else
                {
                    Console.WriteLine($"      ❌ Employee does NOT have {skillName} → +0 points");
                    meetsAllRequirements = false;
                }
            }

            var matchPercentage = maxScore > 0 ? (totalScore / maxScore) * 100 : 0;

            Console.WriteLine($"   ");
            Console.WriteLine($"   📊 FINAL SCORE (Mandatory Skills Only): {totalScore}/{maxScore} = {matchPercentage:F1}%");
            Console.WriteLine($"   ℹ️  Nice-to-have skills IGNORED in scoring");
            Console.WriteLine($"   ✅ Meets all mandatory requirements: {meetsAllRequirements}");
            Console.WriteLine($"===========================================");

            return (matchPercentage, meetsAllRequirements);
        }

        // ⭐ UPDATED: Get skill match status with experience context
        // ⭐ NEW: Unified skill match status (simpler, consistent with EmployeeService)
        private string GetUnifiedSkillMatchStatus(
            EmployeeSkill employeeSkill,
            List<string> mandatorySkills,
            List<string> optionalSkills,
            decimal? minYears)
        {
            var skillName = employeeSkill.Skill.SkillName;
            var skillNameUpper = skillName.ToUpper();
            
            // Check both skill name and aliases for matching (case-insensitive)
            bool isMandatory = mandatorySkills.Any(ms => ms.ToUpper() == skillNameUpper) ||
                               mandatorySkills.Any(ms => employeeSkill.Skill.SkillAliases.Any(sa => sa.AliasName.ToUpper() == ms.ToUpper()));
            bool isOptional = optionalSkills.Any(os => os.ToUpper() == skillNameUpper) ||
                              optionalSkills.Any(os => employeeSkill.Skill.SkillAliases.Any(sa => sa.AliasName.ToUpper() == os.ToUpper()));

            // ⭐ If not in explicit lists, it's extra (will be checked by caller if in category)
            if (!isMandatory && !isOptional)
                return "Extra";

            if (!isMandatory && isOptional)
                return "Optional";

            // For mandatory skills, check experience
            if (minYears.HasValue && minYears.Value > 0)
            {
                if (employeeSkill.YearsOfExperience >= minYears.Value)
                    return "Match";
                else
                    return "Partial";
            }

            return "Match";
        }

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
            // ⭐ DO NOT RETURN INCORRECT DATA
            // Instead, show a user-friendly message about AI service being down
            
            _logger.LogWarning("Fallback search triggered - returning error message instead of incorrect results");
            Console.WriteLine("⚠️ FALLBACK SEARCH: Returning service unavailable message");

            return new SearchResult
            {
                Employees = new List<EmployeeSearchResult>(),
                TotalCount = 0,
                PageNumber = 1,
                PageSize = 50,
                AppliedFilters = new List<string>(),
                ExtractedSkills = new List<string>(),
                ParsedQuery = query,
                Message = "🔧 AI Service Unavailable - The Python API is temporarily down. Please try again in a few moments. We recommend using the basic search filters while the service is being restored."
            };
        }

        // ⭐ NEW: Unified scoring method with category support
        // For categories: employee needs ANY skill from the category to match (weight 1)
        // For explicit skills: employee needs that specific skill to match (weight 1)
        private (decimal MatchPercentage, bool MeetsRequirements) CalculateUnifiedMatchScoreWithCategories(
            Employee employee,
            List<string> mandatorySkillNames,
            Dictionary<string, List<string>> categorySkillsByCategory,
            List<string> optionalSkillNames,
            decimal? minYears,
            string experienceOperator,
            bool skillsAreOr = false)
        {
            Console.WriteLine($"🔍 UNIFIED SCORE CALC WITH CATEGORIES: {employee.FullName}");
            Console.WriteLine($"   Mandatory Skills: {string.Join(", ", mandatorySkillNames)}");
            Console.WriteLine($"   Mandatory Categories: {string.Join(", ", categorySkillsByCategory.Keys)}");
            Console.WriteLine($"   Optional: {string.Join(", ", optionalSkillNames)}");
            Console.WriteLine($"   Min Years: {minYears}");
            Console.WriteLine($"   Skill Operator: {(skillsAreOr ? "OR" : "AND")}");

            // Total weight = number of explicit skills + number of categories
            decimal totalMandatoryWeight = mandatorySkillNames.Count + categorySkillsByCategory.Count;
            decimal earnedMandatoryWeight = 0;
            bool meetsAllRequirements = true;
            bool hasAnySkill = false;

            if (totalMandatoryWeight == 0)
                return (0, true);

            // Process explicit mandatory skills
            foreach (var skillName in mandatorySkillNames)
            {
                var skillNameUpper = skillName.ToUpper();
                var empSkill = employee.EmployeeSkills
                    .FirstOrDefault(es => 
                        es.Skill.SkillName.ToUpper() == skillNameUpper ||
                        es.Skill.SkillAliases.Any(sa => sa.AliasName.ToUpper() == skillNameUpper)
                    );

                if (empSkill != null)
                {
                    hasAnySkill = true;
                    
                    if (minYears.HasValue && minYears.Value > 0)
                    {
                        if (empSkill.YearsOfExperience >= minYears.Value)
                        {
                            earnedMandatoryWeight += 1;
                            Console.WriteLine($"   ✅ {skillName}: {empSkill.YearsOfExperience} >= {minYears} → +1");
                        }
                        else if (empSkill.YearsOfExperience >= minYears.Value * 0.8m)
                        {
                            earnedMandatoryWeight += 0.7m;
                            Console.WriteLine($"   ⚠️  {skillName}: {empSkill.YearsOfExperience} >= 80% of {minYears} → +0.7");
                        }
                        else
                        {
                            var ratio = empSkill.YearsOfExperience / minYears.Value;
                            var points = ratio * 0.5m;
                            earnedMandatoryWeight += points;
                            Console.WriteLine($"   ⚠️  {skillName}: {empSkill.YearsOfExperience}/{minYears} = {ratio:P0} → +{points:F2}");
                        }
                    }
                    else
                    {
                        earnedMandatoryWeight += 1;
                        Console.WriteLine($"   ✅ {skillName}: no requirement → +1");
                    }
                }
                else
                {
                    meetsAllRequirements = false;
                    Console.WriteLine($"   ❌ {skillName}: missing → +0");
                }
            }

            // Process mandatory categories - employee needs ANY skill from each category
            foreach (var categoryEntry in categorySkillsByCategory)
            {
                var categoryName = categoryEntry.Key;
                var categorySkillList = categoryEntry.Value;
                
                // Check if employee has ANY skill from this category
                var matchedCategorySkills = employee.EmployeeSkills
                    .Where(es => categorySkillList.Any(cs => 
                        cs.ToUpper() == es.Skill.SkillName.ToUpper() ||
                        es.Skill.SkillAliases.Any(sa => cs.ToUpper() == sa.AliasName.ToUpper())
                    ))
                    .ToList();

                if (matchedCategorySkills.Any())
                {
                    hasAnySkill = true;
                    
                    // Find the best matching skill from this category (highest experience)
                    var bestMatch = matchedCategorySkills.OrderByDescending(es => es.YearsOfExperience).First();
                    var bestSkillName = bestMatch.Skill.SkillName;
                    
                    if (minYears.HasValue && minYears.Value > 0)
                    {
                        if (bestMatch.YearsOfExperience >= minYears.Value)
                        {
                            earnedMandatoryWeight += 1;
                            Console.WriteLine($"   ✅ {categoryName} (via {bestSkillName}): {bestMatch.YearsOfExperience} >= {minYears} → +1");
                        }
                        else if (bestMatch.YearsOfExperience >= minYears.Value * 0.8m)
                        {
                            earnedMandatoryWeight += 0.7m;
                            Console.WriteLine($"   ⚠️  {categoryName} (via {bestSkillName}): {bestMatch.YearsOfExperience} >= 80% of {minYears} → +0.7");
                        }
                        else
                        {
                            var ratio = bestMatch.YearsOfExperience / minYears.Value;
                            var points = ratio * 0.5m;
                            earnedMandatoryWeight += points;
                            Console.WriteLine($"   ⚠️  {categoryName} (via {bestSkillName}): {bestMatch.YearsOfExperience}/{minYears} = {ratio:P0} → +{points:F2}");
                        }
                    }
                    else
                    {
                        earnedMandatoryWeight += 1;
                        Console.WriteLine($"   ✅ {categoryName} (via {bestSkillName}): no requirement → +1");
                    }
                }
                else
                {
                    meetsAllRequirements = false;
                    Console.WriteLine($"   ❌ {categoryName}: no matching skills from category → +0");
                }
            }

            // Calculate final percentage
            decimal matchPercentage;
            if (skillsAreOr)
            {
                matchPercentage = hasAnySkill ? 100 : 0;
                Console.WriteLine($"   🔀 OR OPERATOR: Employee has {(hasAnySkill ? "at least one" : "none")} of the required skills/categories → {matchPercentage}%");
            }
            else
            {
                matchPercentage = totalMandatoryWeight > 0 
                    ? Math.Round((earnedMandatoryWeight / totalMandatoryWeight) * 100, 2) 
                    : 0;
            }

            Console.WriteLine($"   SCORE: {earnedMandatoryWeight}/{totalMandatoryWeight} = {matchPercentage}%");
            Console.WriteLine($"   Optional skills ({string.Join(", ", optionalSkillNames)}) IGNORED in scoring");

            return (matchPercentage, meetsAllRequirements);
        }

        // ⭐ NEW: Unified scoring method matching EmployeeService logic
        // Only mandatory skills count toward the score
        private (decimal MatchPercentage, bool MeetsRequirements) CalculateUnifiedMatchScore(
            Employee employee,
            List<string> mandatorySkillNames,
            List<string> optionalSkillNames,
            decimal? minYears,
            string experienceOperator,
            bool skillsAreOr = false)
        {
            if (!mandatorySkillNames.Any())
                return (0, true);

            Console.WriteLine($"🔍 UNIFIED SCORE CALC: {employee.FullName}");
            Console.WriteLine($"   Mandatory: {string.Join(", ", mandatorySkillNames)}");
            Console.WriteLine($"   Optional: {string.Join(", ", optionalSkillNames)}");
            Console.WriteLine($"   Min Years: {minYears}");
            Console.WriteLine($"   Skill Operator: {(skillsAreOr ? "OR" : "AND")}");

            decimal totalMandatoryWeight = mandatorySkillNames.Count; // Each skill has weight 1
            decimal earnedMandatoryWeight = 0;
            bool meetsAllRequirements = true;
            bool hasAnySkill = false; // Track if employee has at least one skill (for OR logic)

            foreach (var skillName in mandatorySkillNames)
            {
                // Check both skill name and aliases (case-insensitive using ToUpper)
                var skillNameUpper = skillName.ToUpper();
                var empSkill = employee.EmployeeSkills
                    .FirstOrDefault(es => 
                        es.Skill.SkillName.ToUpper() == skillNameUpper ||
                        es.Skill.SkillAliases.Any(sa => sa.AliasName.ToUpper() == skillNameUpper)
                    );

                if (empSkill != null)
                {
                    hasAnySkill = true; // Employee has at least one skill
                    
                    if (minYears.HasValue && minYears.Value > 0)
                    {
                        if (empSkill.YearsOfExperience >= minYears.Value)
                        {
                            earnedMandatoryWeight += 1; // Full match = 100% weight
                            Console.WriteLine($"   ✅ {skillName}: {empSkill.YearsOfExperience} >= {minYears} → +1");
                        }
                        else if (empSkill.YearsOfExperience >= minYears.Value * 0.8m)
                        {
                            earnedMandatoryWeight += 0.7m; // Good match = 70% weight
                            Console.WriteLine($"   ⚠️  {skillName}: {empSkill.YearsOfExperience} >= 80% of {minYears} → +0.7");
                        }
                        else
                        {
                            var ratio = empSkill.YearsOfExperience / minYears.Value;
                            var points = ratio * 0.5m; // Partial match
                            earnedMandatoryWeight += points;
                            Console.WriteLine($"   ⚠️  {skillName}: {empSkill.YearsOfExperience}/{minYears} = {ratio:P0} → +{points:F2}");
                        }
                    }
                    else
                    {
                        earnedMandatoryWeight += 1; // No requirement = full match
                        Console.WriteLine($"   ✅ {skillName}: no requirement → +1");
                    }
                }
                else
                {
                    meetsAllRequirements = false;
                    Console.WriteLine($"   ❌ {skillName}: missing → +0");
                }
            }

            // ⭐ OR LOGIC: If operator is OR and employee has ANY skill, score is 100%
            decimal matchPercentage;
            if (skillsAreOr)
            {
                matchPercentage = hasAnySkill ? 100 : 0;
                Console.WriteLine($"   🔀 OR OPERATOR: Employee has {(hasAnySkill ? "at least one" : "none")} of the required skills → {matchPercentage}%");
            }
            else
            {
                // AND LOGIC: Score based on percentage of matched skills
                matchPercentage = totalMandatoryWeight > 0 
                    ? Math.Round((earnedMandatoryWeight / totalMandatoryWeight) * 100, 2) 
                    : 0;
            }

            Console.WriteLine($"   SCORE: {earnedMandatoryWeight}/{totalMandatoryWeight} = {matchPercentage}%");
            Console.WriteLine($"   Optional skills ({string.Join(", ", optionalSkillNames)}) IGNORED in scoring");

            return (matchPercentage, meetsAllRequirements);
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

        // ⭐ NEW: Separate mandatory and nice-to-have skills based on the original query text
        private (List<string> mandatory, List<string> niceToHave) SeparateMandatoryAndNiceToHaveSkills(
            string originalQuery,
            List<string> requiredSkills,
            List<string> categorySkills)
        {
            var mandatorySkills = new List<string>();
            var niceToHaveSkills = new List<string>();

            var queryLower = originalQuery.ToLower();
            var hasNiceToHaveMarker = queryLower.Contains("nice to have") || queryLower.Contains("good to have");

            if (hasNiceToHaveMarker)
            {
                // Parse based on explicit markers in the query
                var parts = System.Text.RegularExpressions.Regex.Split(
                    originalQuery,
                    @"\b(mandatory|nice to have|good to have)\b",
                    System.Text.RegularExpressions.RegexOptions.IgnoreCase
                );

                string currentContext = "mandatory";

                for (int i = 0; i < parts.Length; i++)
                {
                    var part = parts[i].Trim();

                    if (part.Equals("mandatory", StringComparison.OrdinalIgnoreCase))
                    {
                        currentContext = "mandatory";
                        continue;
                    }
                    else if (part.Equals("nice to have", StringComparison.OrdinalIgnoreCase) ||
                             part.Equals("good to have", StringComparison.OrdinalIgnoreCase))
                    {
                        currentContext = "nice_to_have";
                        continue;
                    }

                    if (string.IsNullOrWhiteSpace(part)) continue;

                    foreach (var skill in requiredSkills)
                    {
                        if (part.Contains(skill, StringComparison.OrdinalIgnoreCase))
                        {
                            if (currentContext == "mandatory" && !mandatorySkills.Contains(skill))
                            {
                                mandatorySkills.Add(skill);
                            }
                            else if (currentContext == "nice_to_have" && !niceToHaveSkills.Contains(skill))
                            {
                                niceToHaveSkills.Add(skill);
                            }
                        }
                    }
                }
            }
            else
            {
                // No explicit markers, all are mandatory
                mandatorySkills = requiredSkills.ToList();
                niceToHaveSkills = categorySkills.ToList();
            }

            return (mandatorySkills, niceToHaveSkills);
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