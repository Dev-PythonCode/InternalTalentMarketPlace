// PythonApiService.cs
// Implementation of Python API service with enhanced SpaCy NER support

using System.Text.Json;
using System.Text.Json.Serialization;
using TalentMarketPlace.Services.Interfaces;

namespace TalentMarketPlace.Services;

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
        _baseUrl = configuration["PythonApi:BaseUrl"] ?? "http://127.0.0.1:5000";

        _httpClient.BaseAddress = new Uri(_baseUrl);
        _httpClient.Timeout = TimeSpan.FromSeconds(30);
    }

    public async Task<bool> IsHealthyAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync("/health");
            return response.IsSuccessStatusCode;
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

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                Converters = { new JsonStringEnumConverter() }
            };

            var result = await response.Content.ReadFromJsonAsync<ParseQueryResult>(options);

            if (result == null)
            {
                return new ParseQueryResult
                {
                    Error = "Failed to deserialize response"
                };
            }

            _logger.LogInformation("Successfully parsed query. Found {Count} skills",
                result.Parsed.Skills?.Count ?? 0);

            return result;
        }
        catch (Exception ex)
        {
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

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                Converters = { new JsonStringEnumConverter() }
            };

            var result = await response.Content.ReadFromJsonAsync<ChatSearchResponse>(options);

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