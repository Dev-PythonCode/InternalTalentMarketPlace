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
        Task<CareerRoadmapResponse> GetCareerRoadmapAsync(string prompt);
    }

    public class CareerRoadmapResponse
    {
        public string? CareerPath { get; set; }
        public List<string>? RecommendedSkills { get; set; }
        public List<LearningStep>? LearningSteps { get; set; }
        public TimelineInfo? Timeline { get; set; }
        public ResourceInfo? Resources { get; set; }
    }

    public class LearningStep
    {
        public int Step { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<string>? Skills { get; set; }
        public string? Duration { get; set; }
    }

    public class TimelineInfo
    {
        public string? TotalDuration { get; set; }
        public int? EstimatedMonths { get; set; }
    }

    public class ResourceInfo
    {
        public List<CourseResource>? Courses { get; set; }
        public List<string>? Books { get; set; }
        public List<string>? Websites { get; set; }
    }

    public class CourseResource
    {
        public string? Title { get; set; }
        public string? Provider { get; set; }
        public string? Level { get; set; }
        public string? Url { get; set; }
    }
}