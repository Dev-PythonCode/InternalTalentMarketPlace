// IPythonApiService.cs - FIXED
// Uses models from TalentMarketPlace.Models instead of duplicate definitions

using TalentMarketPlace.Models;

namespace TalentMarketPlace.Services.Interfaces
{
    public interface IPythonApiService
    {
        Task<bool> IsHealthyAsync();
        Task<ParseQueryResult> ParseQueryAsync(string query);
        Task<ChatSearchResponse> ChatSearchAsync(string query);
    }
}