namespace TalentMarketPlace.Services.Interfaces;

public interface ISkillService
{
    Task<List<Skill>> GetAllAsync();
    Task<List<Skill>> GetByCategoryAsync(int categoryId);
    Task<Skill?> GetByIdAsync(int skillId);
    Task<Skill?> GetByNameAsync(string skillName);
    Task<Skill?> GetByAliasAsync(string alias);
    Task<Skill> CreateAsync(Skill skill);
    Task<Skill> UpdateAsync(Skill skill);
    Task<bool> DeleteAsync(int skillId);
    Task<List<SkillCategory>> GetCategoriesAsync();
    Task<SkillCategory> CreateCategoryAsync(SkillCategory category);
    Task<SkillAlias> AddAliasAsync(int skillId, string aliasName);
    Task<bool> DeleteAliasAsync(int aliasId);
    Task<List<Skill>> SearchAsync(string searchTerm);
}