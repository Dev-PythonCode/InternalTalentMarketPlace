using Microsoft.EntityFrameworkCore;
using TalentMarketPlace.Data;
using TalentMarketPlace.Services.Interfaces;

namespace TalentMarketPlace.Services;

public class SkillService : ISkillService
{
    private readonly TalentMarketplaceDbContext _context;

    public SkillService(TalentMarketplaceDbContext context)
    {
        _context = context;
    }

    public async Task<List<Skill>> GetAllAsync()
    {
        // ⭐ Get data first WITHOUT ordering by decimal
        var skills = await _context.Skills
            .Include(s => s.Category)
            .Include(s => s.SkillAliases)
            .Where(s => s.IsActive)
            .ToListAsync(); // ← Convert to list FIRST
        
        // ⭐ Then sort in-memory (client-side)
        return skills
            .OrderBy(s => s.Category?.DisplayOrder ?? 0)
            .ThenBy(s => s.SkillName)
            .ToList();
    }
    public async Task<List<Skill>> GetByCategoryAsync(int categoryId)
    {
        return await _context.Skills
            .Include(s => s.SkillAliases)
            .Where(s => s.CategoryId == categoryId && s.IsActive)
            .OrderBy(s => s.SkillName)
            .ToListAsync();
    }

    public async Task<Skill?> GetByIdAsync(int skillId)
    {
        return await _context.Skills
            .Include(s => s.Category)
            .Include(s => s.SkillAliases)
            .FirstOrDefaultAsync(s => s.SkillId == skillId);
    }

    public async Task<Skill?> GetByNameAsync(string skillName)
    {
        return await _context.Skills
            .Include(s => s.Category)
            .Include(s => s.SkillAliases)
            .FirstOrDefaultAsync(s => s.SkillName.ToLower() == skillName.ToLower());
    }

    public async Task<Skill?> GetByAliasAsync(string alias)
    {
        var skillAlias = await _context.SkillAliases
            .Include(sa => sa.Skill)
                .ThenInclude(s => s.Category)
            .FirstOrDefaultAsync(sa => sa.AliasName.ToLower() == alias.ToLower());

        return skillAlias?.Skill;
    }

    public async Task<Skill> CreateAsync(Skill skill)
    {
        skill.CreatedDate = DateTime.UtcNow;
        _context.Skills.Add(skill);
        await _context.SaveChangesAsync();
        return skill;
    }

    public async Task<Skill> UpdateAsync(Skill skill)
    {
        _context.Skills.Update(skill);
        await _context.SaveChangesAsync();
        return skill;
    }

    public async Task<bool> DeleteAsync(int skillId)
    {
        var skill = await _context.Skills.FindAsync(skillId);
        if (skill == null) return false;

        // Soft delete
        skill.IsActive = false;
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<SkillCategory>> GetCategoriesAsync()
    {
        return await _context.SkillCategories
            .OrderBy(c => c.DisplayOrder)
            .ToListAsync();
    }

    public async Task<SkillCategory> CreateCategoryAsync(SkillCategory category)
    {
        _context.SkillCategories.Add(category);
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task<SkillAlias> AddAliasAsync(int skillId, string aliasName)
    {
        var alias = new SkillAlias
        {
            SkillId = skillId,
            AliasName = aliasName,
            CreatedDate = DateTime.UtcNow
        };
        _context.SkillAliases.Add(alias);
        await _context.SaveChangesAsync();
        return alias;
    }

    public async Task<bool> DeleteAliasAsync(int aliasId)
    {
        var alias = await _context.SkillAliases.FindAsync(aliasId);
        if (alias == null) return false;

        _context.SkillAliases.Remove(alias);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<Skill>> SearchAsync(string searchTerm)
    {
        var lowerTerm = searchTerm.ToLower();

        return await _context.Skills
            .Include(s => s.Category)
            .Include(s => s.SkillAliases)
            .Where(s => s.IsActive && (
                s.SkillName.ToLower().Contains(lowerTerm) ||
                s.SkillAliases.Any(a => a.AliasName.ToLower().Contains(lowerTerm))))
            .OrderBy(s => s.SkillName)
            .ToListAsync();
    }
}
