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
            var result = JsonSerializer.Deserialize<ParseQueryResult>(rawJson, options);

            // ⭐ CRITICAL: Log what we deserialized
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