using Microsoft.EntityFrameworkCore;
using TalentMarketPlace.Data;
using TalentMarketPlace.Models;
using TalentMarketPlace.Services.Interfaces;

namespace TalentMarketPlace.Services
{
    public class LevelReminderService : ILevelReminderService
    {
        private readonly TalentMarketplaceDbContext _context;

        public LevelReminderService(TalentMarketplaceDbContext context)
        {
            _context = context;
        }

        public async Task<List<LevelReminderSetting>> GetAllSettingsAsync()
        {
            return await _context.LevelReminderSettings
                .Where(s => s.IsActive)
                .OrderBy(s => s.EmployeeLevel)
                .ToListAsync();
        }

        public async Task<LevelReminderSetting?> GetSettingByLevelAsync(string level)
        {
            return await _context.LevelReminderSettings
                .FirstOrDefaultAsync(s => s.EmployeeLevel == level && s.IsActive);
        }

        public async Task<LevelReminderSetting> CreateSettingAsync(LevelReminderSetting setting)
        {
            // Check if level already exists
            var exists = await LevelExistsAsync(setting.EmployeeLevel);
            if (exists)
            {
                throw new InvalidOperationException($"Setting for level {setting.EmployeeLevel} already exists. Please edit the existing setting.");
            }

            setting.CreatedDate = DateTime.UtcNow;
            setting.IsActive = true;

            _context.LevelReminderSettings.Add(setting);
            await _context.SaveChangesAsync();
            return setting;
        }

        public async Task<LevelReminderSetting> UpdateSettingAsync(LevelReminderSetting setting)
        {
            var existing = await _context.LevelReminderSettings.FindAsync(setting.Id);
            if (existing == null)
            {
                throw new InvalidOperationException("Setting not found");
            }

            // Check if changing to a level that already exists
            if (existing.EmployeeLevel != setting.EmployeeLevel)
            {
                var levelExists = await _context.LevelReminderSettings
                    .AnyAsync(s => s.EmployeeLevel == setting.EmployeeLevel && s.Id != setting.Id && s.IsActive);
                
                if (levelExists)
                {
                    throw new InvalidOperationException($"Setting for level {setting.EmployeeLevel} already exists.");
                }
            }

            existing.EmployeeLevel = setting.EmployeeLevel;
            existing.Duration = setting.Duration;
            existing.DefaultEmailCount = setting.DefaultEmailCount;
            existing.LastModifiedDate = DateTime.UtcNow;
            existing.ModifiedBy = setting.ModifiedBy;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task DeleteSettingAsync(int id)
        {
            var setting = await _context.LevelReminderSettings.FindAsync(id);
            if (setting != null)
            {
                setting.IsActive = false;
                setting.LastModifiedDate = DateTime.UtcNow;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> LevelExistsAsync(string level)
        {
            return await _context.LevelReminderSettings
                .AnyAsync(s => s.EmployeeLevel == level && s.IsActive);
        }
    }
}
