using TalentMarketPlace.Models;

namespace TalentMarketPlace.Services.Interfaces
{
    public interface ILevelReminderService
    {
        Task<List<LevelReminderSetting>> GetAllSettingsAsync();
        Task<LevelReminderSetting?> GetSettingByLevelAsync(string level);
        Task<LevelReminderSetting> CreateSettingAsync(LevelReminderSetting setting);
        Task<LevelReminderSetting> UpdateSettingAsync(LevelReminderSetting setting);
        Task DeleteSettingAsync(int id);
        Task<bool> LevelExistsAsync(string level);
    }
}
