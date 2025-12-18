// PythonApiService.cs - FIXED DESERIALIZATION
// Implementation of Python API service with CORRECT JSON deserialization

using System.Text.Json;
using System.Text.Json.Serialization;
using TalentMarketPlace.Services.Interfaces;

namespace TalentMarketPlace.Services;
using TalentMarketPlace.Models;

public class PythonApiService : IPythonApiService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<PythonApiService> _logger;
    private readonly string _baseUrl;

    public PythonApiService(
        HttpClient httpClient,
        ILogger<PythonApiService> logger,
        IConfiguration configuration)
    {
        _httpClient = httpClient;
        _logger = logger;
        
        // ✅ FIXED: Use correct config key matching appsettings.json
        _baseUrl = configuration["PythonAI:ApiUrl"] ?? "http://localhost:5000";
        
        _logger.LogInformation("PythonApiService initialized with base URL: {BaseUrl}", _baseUrl);

        _httpClient.BaseAddress = new Uri(_baseUrl);
        _httpClient.Timeout = TimeSpan.FromSeconds(30);
    }

    public async Task<bool> IsHealthyAsync()
    {
        try
        {
            _logger.LogDebug("Checking Python API health at {BaseUrl}/health", _baseUrl);
            
            var response = await _httpClient.GetAsync("/health");
            var isHealthy = response.IsSuccessStatusCode;
            
            _logger.LogInformation("Python API health check result: {IsHealthy}", isHealthy);
            
            return isHealthy;
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Python API health check failed");
            return false;
        }
    }

    public async Task<ParseQueryResult> ParseQueryAsync(string query)
    {
        try
        {
            _logger.LogInformation("Parsing query with Python API: {Query}", query);

            var requestBody = new { query };
            
            _logger.LogDebug("Calling {BaseUrl}/parse", _baseUrl);
            
            var response = await _httpClient.PostAsJsonAsync("/parse", requestBody);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError("Python API parse error: {StatusCode} - {Error}",
                    response.StatusCode, errorContent);

                return new ParseQueryResult
                {
                    Error = $"API returned {response.StatusCode}: {errorContent}"
                };
            }

            // ⭐ CRITICAL: Get raw JSON response for debugging
            var rawJson = await response.Content.ReadAsStringAsync();
            
            Console.WriteLine("");
            Console.WriteLine("========================================");
            Console.WriteLine("=== RAW PYTHON API RESPONSE ===");
            Console.WriteLine(rawJson);
            Console.WriteLine("========================================");
            Console.WriteLine("");

            // ⭐ CRITICAL FIX: Configure JsonSerializerOptions correctly
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = false,  // Don't use case-insensitive matching
                PropertyNamingPolicy = null,  // Don't apply any automatic naming policy
                WriteIndented = false,
                DefaultIgnoreCondition = JsonIgnoreCondition.Never,
                NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString
            };
            
            // Add enum converter
            options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));

            // Deserialize from the raw JSON string
            ParseQueryResult? result = null;
            try
            {
                result = JsonSerializer.Deserialize<ParseQueryResult>(rawJson, options);
            }
            catch (JsonException jex)
            {
                _logger.LogWarning(jex, "Primary deserialization failed, attempting tolerant mapping");
                // Try tolerant mapping when strict deserialization fails due to type mismatches
                result = MapJsonToParseQueryResult(rawJson);
            }

            // ⭐ CRITICAL: Log what we deserialized or mapped
            Console.WriteLine("========================================");
            Console.WriteLine("=== DESERIALIZED RESULT ===");
            Console.WriteLine($"Result is null: {result == null}");
            
            if (result != null)
            {
                Console.WriteLine($"OriginalQuery: '{result.OriginalQuery}'");
                Console.WriteLine($"Error: {result.Error ?? "null"}");
                Console.WriteLine($"SkillsFound: {result.SkillsFound}");
                
                if (result.Parsed != null)
                {
                    Console.WriteLine($"Parsed is not null: TRUE");
                    Console.WriteLine($"  Skills count: {result.Parsed.Skills?.Count ?? 0}");
                    Console.WriteLine($"  Skills: {string.Join(", ", result.Parsed.Skills ?? new List<string>())}");
                    Console.WriteLine($"  MinYearsExperience: {result.Parsed.MinYearsExperience?.ToString() ?? "NULL"}");
                    Console.WriteLine($"  MaxYearsExperience: {result.Parsed.MaxYearsExperience?.ToString() ?? "NULL"}");
                    Console.WriteLine($"  ExperienceOperator: '{result.Parsed.ExperienceOperator}'");
                    
                    if (result.Parsed.ExperienceContext != null)
                    {
                        Console.WriteLine($"  ExperienceContext is not null: TRUE");
                        Console.WriteLine($"    Type: '{result.Parsed.ExperienceContext.Type}'");
                        Console.WriteLine($"    Skill: '{result.Parsed.ExperienceContext.Skill ?? "null"}'");
                        Console.WriteLine($"    Reason: '{result.Parsed.ExperienceContext.Reason ?? "null"}'");
                    }
                    else
                    {
                        Console.WriteLine($"  ExperienceContext: NULL");
                    }
                }
                else
                {
                    Console.WriteLine($"Parsed: NULL");
                }
            }
            
            Console.WriteLine("========================================");
            Console.WriteLine("");

            if (result == null)
            {
                return new ParseQueryResult
                {
                    Error = "Failed to deserialize response"
                };
            }

            _logger.LogInformation("Successfully parsed query. Found {SkillCount} skills, MinYears: {MinYears}",
                result.Parsed?.Skills?.Count ?? 0,
                result.Parsed?.MinYearsExperience);

            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine("");
            Console.WriteLine("========================================");
            Console.WriteLine($"❌ EXCEPTION in ParseQueryAsync");
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine($"Type: {ex.GetType().Name}");
            Console.WriteLine($"Stack trace:");
            Console.WriteLine(ex.StackTrace);
            Console.WriteLine("========================================");
            Console.WriteLine("");
            
            _logger.LogError(ex, "Exception calling Python API parse endpoint");
            
            return new ParseQueryResult
            {
                Error = $"Exception: {ex.Message}"
            };
        }
    }

    // Attempt to map raw JSON into ParseQueryResult tolerantly (handles snake_case and camelCase)
    private ParseQueryResult? MapJsonToParseQueryResult(string rawJson)
    {
        using var doc = JsonDocument.Parse(rawJson);
        var root = doc.RootElement;

        string GetString(JsonElement obj, params string[] keys)
        {
            foreach (var k in keys)
            {
                if (obj.TryGetProperty(k, out var v) && v.ValueKind == JsonValueKind.String)
                    return v.GetString() ?? string.Empty;
            }
            return string.Empty;
        }

        List<string> GetStringList(JsonElement obj, params string[] keys)
        {
            foreach (var k in keys)
            {
                if (obj.TryGetProperty(k, out var v) && v.ValueKind == JsonValueKind.Array)
                {
                    var list = new List<string>();
                    foreach (var item in v.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.String)
                            list.Add(item.GetString() ?? string.Empty);
                    }
                    return list;
                }
            }
            return new List<string>();
        }

        try
        {
            var parsedResult = new ParseQueryResult();

            // original query
            parsedResult.OriginalQuery = GetString(root, "original_query", "originalQuery", "originalquery");

            // top-level skills_found
            if (root.TryGetProperty("skills_found", out var sf) && sf.ValueKind == JsonValueKind.Number)
                parsedResult.SkillsFound = sf.GetInt32();

            // applied_filters
            parsedResult.AppliedFilters = GetStringList(root, "applied_filters", "appliedFilters");

            // parsed object
                if (root.TryGetProperty("parsed", out var parsedEl) && parsedEl.ValueKind == JsonValueKind.Object)
            {
                var p = new ParsedQuery();
                p.Skills = GetStringList(parsedEl, "skills", "skillList", "skill_list");
                p.Categories = GetStringList(parsedEl, "categories", "categoryList", "category_list");
                p.CategorySkills = GetStringList(parsedEl, "category_skills", "categorySkills");

                if (parsedEl.TryGetProperty("min_years_experience", out var myn) && myn.ValueKind == JsonValueKind.Number)
                    p.MinYearsExperience = myn.GetDecimal();
                else if (parsedEl.TryGetProperty("minYearsExperience", out var myn2) && myn2.ValueKind == JsonValueKind.Number)
                    p.MinYearsExperience = myn2.GetDecimal();

                if (parsedEl.TryGetProperty("max_years_experience", out var mxn) && mxn.ValueKind == JsonValueKind.Number)
                    p.MaxYearsExperience = mxn.GetDecimal();
                else if (parsedEl.TryGetProperty("maxYearsExperience", out var mxn2) && mxn2.ValueKind == JsonValueKind.Number)
                    p.MaxYearsExperience = mxn2.GetDecimal();

                p.ExperienceOperator = GetString(parsedEl, "experience_operator", "experienceOperator");
                p.Location = GetString(parsedEl, "location", "Location", "location");
                // availability_status may be an object; if so, store its raw JSON representation
                if (parsedEl.TryGetProperty("availability_status", out var av))
                {
                    // Map availability_status into structured AvailabilityStatus model
                    if (av.ValueKind == JsonValueKind.Object)
                    {
                        var asObj = new AvailabilityStatus();
                        asObj.Status = GetString(av, "status", "Status");
                        asObj.Keywords = GetStringList(av, "keywords", "keyword_list", "keywords");
                        var details = GetString(av, "details", "Details");
                        asObj.Details = string.IsNullOrEmpty(details) ? null : details;
                        p.AvailabilityStatus = asObj;
                    }
                    else if (av.ValueKind == JsonValueKind.String)
                    {
                        p.AvailabilityStatus = new AvailabilityStatus { Status = av.GetString() };
                    }
                    else
                    {
                        p.AvailabilityStatus = null;
                    }
                }
                p.SkillLevels = GetStringList(parsedEl, "skill_levels", "skillLevels");
                p.Roles = GetStringList(parsedEl, "roles", "roleList", "roles");

                // Map experience_context if present
                if (parsedEl.TryGetProperty("experience_context", out var ec) && ec.ValueKind == JsonValueKind.Object)
                {
                    var expCtx = new ExperienceContext();
                    expCtx.Type = GetString(ec, "type", "Type");
                    var skillStr = GetString(ec, "skill", "Skill");
                    expCtx.Skill = string.IsNullOrEmpty(skillStr) ? null : skillStr;
                    expCtx.Reason = GetString(ec, "reason", "Reason");
                    p.ExperienceContext = expCtx;
                }

                // Map skill_requirements array if present
                if (parsedEl.TryGetProperty("skill_requirements", out var sr) && sr.ValueKind == JsonValueKind.Array)
                {
                    var list = new List<SkillRequirement>();
                    foreach (var item in sr.EnumerateArray())
                    {
                        if (item.ValueKind != JsonValueKind.Object) continue;
                        var req = new SkillRequirement();
                        req.Skill = GetString(item, "skill", "Skill");

                        if (item.TryGetProperty("min_years", out var minY) && minY.ValueKind == JsonValueKind.Number)
                            req.MinYears = minY.GetDecimal();
                        else if (item.TryGetProperty("minYears", out var minY2) && minY2.ValueKind == JsonValueKind.Number)
                            req.MinYears = minY2.GetDecimal();

                        if (item.TryGetProperty("max_years", out var maxY) && maxY.ValueKind == JsonValueKind.Number)
                            req.MaxYears = maxY.GetDecimal();
                        else if (item.TryGetProperty("maxYears", out var maxY2) && maxY2.ValueKind == JsonValueKind.Number)
                            req.MaxYears = maxY2.GetDecimal();

                        req.Operator = GetString(item, "operator", "Operator");
                        req.ExperienceType = GetString(item, "experience_type", "experienceType");
                        list.Add(req);
                    }
                    p.SkillRequirements = list;
                }

                parsedResult.Parsed = p;
            }

            // error
            parsedResult.Error = GetString(root, "error", "Error", "errorMessage");

            return parsedResult;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error mapping JSON to ParseQueryResult");
            return null;
        }
    }

    public async Task<ChatSearchResponse> ChatSearchAsync(string query)
    {
        try
        {
            _logger.LogInformation("Performing chat search with Python API: {Query}", query);

            var requestBody = new { query };
            var response = await _httpClient.PostAsJsonAsync("/chat", requestBody);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError("Python API chat search error: {StatusCode} - {Error}",
                    response.StatusCode, errorContent);

                throw new Exception($"API returned {response.StatusCode}: {errorContent}");
            }

            var rawJson = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = false,
                PropertyNamingPolicy = null,
                DefaultIgnoreCondition = JsonIgnoreCondition.Never,
                NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString
            };
            
            options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));

            var result = JsonSerializer.Deserialize<ChatSearchResponse>(rawJson, options);

            if (result == null)
            {
                throw new Exception("Failed to deserialize response");
            }

            _logger.LogInformation("Chat search completed. Found {Count} results",
                result.TotalResults);

            return result;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Exception calling Python API chat endpoint");
            throw;
        }
    }
}