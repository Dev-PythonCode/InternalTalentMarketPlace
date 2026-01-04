using TalentMarketPlace.Services.Interfaces;

namespace TalentMarketPlace.Services;

/// <summary>
/// Mock Skill Service for Testing on Mac (without SQL Server)
/// Returns a hardcoded list of common programming skills
/// </summary>
public class MockSkillService : ISkillService
{
    private readonly List<Skill> _skills;
    private readonly List<SkillCategory> _categories;

    public MockSkillService()
    {
        // Initialize categories
        _categories = new List<SkillCategory>
        {
            new SkillCategory { CategoryId = 1, CategoryName = "Programming Languages" },
            new SkillCategory { CategoryId = 2, CategoryName = "Web Frameworks" },
            new SkillCategory { CategoryId = 3, CategoryName = "Databases" },
            new SkillCategory { CategoryId = 4, CategoryName = "Cloud Platforms" },
            new SkillCategory { CategoryId = 5, CategoryName = "DevOps Tools" }
        };

        // Initialize common skills
        _skills = new List<Skill>
        {
            // Programming Languages
            new Skill { SkillId = 1, SkillName = "Python", CategoryId = 1, Category = _categories[0] },
            new Skill { SkillId = 2, SkillName = "Java", CategoryId = 1, Category = _categories[0] },
            new Skill { SkillId = 3, SkillName = "JavaScript", CategoryId = 1, Category = _categories[0] },
            new Skill { SkillId = 4, SkillName = "C#", CategoryId = 1, Category = _categories[0] },
            new Skill { SkillId = 5, SkillName = "TypeScript", CategoryId = 1, Category = _categories[0] },
            new Skill { SkillId = 6, SkillName = "Go", CategoryId = 1, Category = _categories[0] },
            new Skill { SkillId = 7, SkillName = "Ruby", CategoryId = 1, Category = _categories[0] },
            new Skill { SkillId = 8, SkillName = "PHP", CategoryId = 1, Category = _categories[0] },
            new Skill { SkillId = 9, SkillName = "Swift", CategoryId = 1, Category = _categories[0] },
            new Skill { SkillId = 10, SkillName = "Kotlin", CategoryId = 1, Category = _categories[0] },

            // Web Frameworks
            new Skill { SkillId = 11, SkillName = "React", CategoryId = 2, Category = _categories[1] },
            new Skill { SkillId = 12, SkillName = "Angular", CategoryId = 2, Category = _categories[1] },
            new Skill { SkillId = 13, SkillName = "Vue.js", CategoryId = 2, Category = _categories[1] },
            new Skill { SkillId = 14, SkillName = "Django", CategoryId = 2, Category = _categories[1] },
            new Skill { SkillId = 15, SkillName = "Flask", CategoryId = 2, Category = _categories[1] },
            new Skill { SkillId = 16, SkillName = "Spring Boot", CategoryId = 2, Category = _categories[1] },
            new Skill { SkillId = 17, SkillName = "Node.js", CategoryId = 2, Category = _categories[1] },
            new Skill { SkillId = 18, SkillName = "Express.js", CategoryId = 2, Category = _categories[1] },
            new Skill { SkillId = 19, SkillName = "ASP.NET Core", CategoryId = 2, Category = _categories[1] },
            new Skill { SkillId = 20, SkillName = "Next.js", CategoryId = 2, Category = _categories[1] },

            // Databases
            new Skill { SkillId = 21, SkillName = "MySQL", CategoryId = 3, Category = _categories[2] },
            new Skill { SkillId = 22, SkillName = "PostgreSQL", CategoryId = 3, Category = _categories[2] },
            new Skill { SkillId = 23, SkillName = "MongoDB", CategoryId = 3, Category = _categories[2] },
            new Skill { SkillId = 24, SkillName = "Redis", CategoryId = 3, Category = _categories[2] },
            new Skill { SkillId = 25, SkillName = "SQL Server", CategoryId = 3, Category = _categories[2] },
            new Skill { SkillId = 26, SkillName = "Oracle", CategoryId = 3, Category = _categories[2] },
            new Skill { SkillId = 27, SkillName = "Cassandra", CategoryId = 3, Category = _categories[2] },
            new Skill { SkillId = 28, SkillName = "DynamoDB", CategoryId = 3, Category = _categories[2] },

            // Cloud Platforms
            new Skill { SkillId = 29, SkillName = "AWS", CategoryId = 4, Category = _categories[3] },
            new Skill { SkillId = 30, SkillName = "Azure", CategoryId = 4, Category = _categories[3] },
            new Skill { SkillId = 31, SkillName = "Google Cloud", CategoryId = 4, Category = _categories[3] },
            new Skill { SkillId = 32, SkillName = "Heroku", CategoryId = 4, Category = _categories[3] },

            // DevOps Tools
            new Skill { SkillId = 33, SkillName = "Docker", CategoryId = 5, Category = _categories[4] },
            new Skill { SkillId = 34, SkillName = "Kubernetes", CategoryId = 5, Category = _categories[4] },
            new Skill { SkillId = 35, SkillName = "Jenkins", CategoryId = 5, Category = _categories[4] },
            new Skill { SkillId = 36, SkillName = "GitLab CI", CategoryId = 5, Category = _categories[4] },
            new Skill { SkillId = 37, SkillName = "Terraform", CategoryId = 5, Category = _categories[4] },
            new Skill { SkillId = 38, SkillName = "Ansible", CategoryId = 5, Category = _categories[4] },
            new Skill { SkillId = 39, SkillName = "Git", CategoryId = 5, Category = _categories[4] },
            new Skill { SkillId = 40, SkillName = "GitHub Actions", CategoryId = 5, Category = _categories[4] }
        };

        Console.WriteLine($"🔧 MockSkillService initialized with {_skills.Count} skills");
    }

    public Task<List<Skill>> GetAllAsync()
    {
        return Task.FromResult(_skills);
    }

    public Task<List<Skill>> GetByCategoryAsync(int categoryId)
    {
        var skills = _skills.Where(s => s.CategoryId == categoryId).ToList();
        return Task.FromResult(skills);
    }

    public Task<Skill?> GetByIdAsync(int skillId)
    {
        var skill = _skills.FirstOrDefault(s => s.SkillId == skillId);
        return Task.FromResult(skill);
    }

    public Task<Skill?> GetByNameAsync(string skillName)
    {
        var skill = _skills.FirstOrDefault(s => 
            s.SkillName.Equals(skillName, StringComparison.OrdinalIgnoreCase));
        return Task.FromResult(skill);
    }

    public Task<Skill?> GetByAliasAsync(string alias)
    {
        // Simple alias matching for common variations
        var normalizedAlias = alias.ToLower();
        var skill = _skills.FirstOrDefault(s => 
            s.SkillName.ToLower().Contains(normalizedAlias) || 
            normalizedAlias.Contains(s.SkillName.ToLower()));
        return Task.FromResult(skill);
    }

    public Task<Skill> CreateAsync(Skill skill)
    {
        // Mock: just return the skill with a new ID
        skill.SkillId = _skills.Max(s => s.SkillId) + 1;
        _skills.Add(skill);
        return Task.FromResult(skill);
    }

    public Task<Skill> UpdateAsync(Skill skill)
    {
        var existing = _skills.FirstOrDefault(s => s.SkillId == skill.SkillId);
        if (existing != null)
        {
            existing.SkillName = skill.SkillName;
            existing.CategoryId = skill.CategoryId;
        }
        return Task.FromResult(skill);
    }

    public Task<bool> DeleteAsync(int skillId)
    {
        var skill = _skills.FirstOrDefault(s => s.SkillId == skillId);
        if (skill != null)
        {
            _skills.Remove(skill);
            return Task.FromResult(true);
        }
        return Task.FromResult(false);
    }

    public Task<List<SkillCategory>> GetCategoriesAsync()
    {
        return Task.FromResult(_categories);
    }

    public Task<SkillCategory> CreateCategoryAsync(SkillCategory category)
    {
        category.CategoryId = _categories.Max(c => c.CategoryId) + 1;
        _categories.Add(category);
        return Task.FromResult(category);
    }

    public Task<SkillAlias> AddAliasAsync(int skillId, string aliasName)
    {
        // Mock: just return a new alias
        return Task.FromResult(new SkillAlias 
        { 
            AliasId = 1, 
            SkillId = skillId, 
            AliasName = aliasName 
        });
    }

    public Task<bool> DeleteAliasAsync(int aliasId)
    {
        return Task.FromResult(true);
    }

    public Task<List<Skill>> SearchAsync(string searchTerm)
    {
        var results = _skills.Where(s => 
            s.SkillName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
            .ToList();
        return Task.FromResult(results);
    }

    public Task<List<LearningResource>> GetLearningResourcesBySkillIdAsync(int skillId)
    {
        // Mock: return empty list
        return Task.FromResult(new List<LearningResource>());
    }

    public Task<List<LearningResource>> GetLearningResourcesBySkillNameAsync(string skillName)
    {
        // Mock: return empty list
        return Task.FromResult(new List<LearningResource>());
    }
}
