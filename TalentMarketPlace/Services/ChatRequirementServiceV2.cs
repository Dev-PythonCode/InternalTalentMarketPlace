using TalentMarketPlace.Models;
using TalentMarketPlace.Services.Interfaces;

namespace TalentMarketPlace.Services;

public interface IChatRequirementServiceV2
{
    Task<RequirementChatMessage> GetInitialGreetingAsync();
    Task<RequirementChatMessage> ProcessUserInputAsync(string userInput);
    Task<List<Skill>> GetSkillSuggestionsAsync(string searchTerm);
    Task<RequirementChatState> GetCurrentStateAsync();
    Task ResetAsync();
    Requirement GetCurrentRequirement();
    Task SetSelectedOptionAsync(string step, string value);
}

public class ChatRequirementServiceV2 : IChatRequirementServiceV2
{
    private readonly IRequirementService _requirementService;
    private readonly ISkillService _skillService;
    private readonly ILogger<ChatRequirementServiceV2> _logger;
    
    private RequirementChatState _state = new();
    private string _currentConversationStep = "";
    private List<Skill> _availableSkills = new();

    public ChatRequirementServiceV2(
        IRequirementService requirementService,
        ISkillService skillService,
        ILogger<ChatRequirementServiceV2> logger)
    {
        _requirementService = requirementService;
        _skillService = skillService;
        _logger = logger;
    }

    public async Task<RequirementChatMessage> GetInitialGreetingAsync()
    {
        _state = new RequirementChatState();
        _currentConversationStep = "title";
        _availableSkills = await _skillService.GetAllAsync();
        
        return new RequirementChatMessage
        {
            Content = "👋 **Welcome!** I'm your Requirement Creator Assistant.\n\n" +
                      "Let's build your requirement together step by step.\n\n" +
                      "📝 **First:** What's the **title** for this position?\n" +
                      "Example: Senior Python Developer, Full Stack Engineer, DevOps Specialist",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "title",
            HasSuggestions = false
        };
    }

    public async Task<RequirementChatMessage> ProcessUserInputAsync(string userInput)
    {
        if (string.IsNullOrWhiteSpace(userInput))
        {
            return new RequirementChatMessage
            {
                Content = "Please provide an answer to continue.",
                IsBot = true,
                Timestamp = DateTime.UtcNow,
                Step = _currentConversationStep
            };
        }

        try
        {
            return _currentConversationStep switch
            {
                "title" => await HandleTitleAsync(userInput),
                "description" => await HandleDescriptionAsync(userInput),
                "location" => await HandleLocationAsync(userInput),
                "duration" => await HandleDurationAsync(userInput),
                "priority" => await HandlePriorityAsync(userInput),
                "add_skills" => await HandleAddSkillsAsync(userInput),
                "skill_experience" => await HandleSkillExperienceAsync(userInput),
                "skill_proficiency" => await HandleSkillProficiencyAsync(userInput),
                "skill_mandatory" => await HandleSkillMandatoryAsync(userInput),
                "add_more_skills" => await HandleAddMoreSkillsAsync(userInput),
                "review" => await HandleReviewAsync(userInput),
                _ => await GetInitialGreetingAsync()
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing chat input at step {Step}", _currentConversationStep);
            return new RequirementChatMessage
            {
                Content = $"❌ Error: {ex.Message}\n\nLet's try again.",
                IsBot = true,
                Timestamp = DateTime.UtcNow,
                Step = _currentConversationStep
            };
        }
    }

    public async Task<List<Skill>> GetSkillSuggestionsAsync(string searchTerm)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return _availableSkills.Take(15).ToList();

            var lower = searchTerm.ToLower();
            
            // First: exact prefix matches
            var exactMatches = _availableSkills
                .Where(s => s.SkillName.ToLower().StartsWith(lower))
                .ToList();
            
            // Second: contains matches
            var containsMatches = _availableSkills
                .Where(s => s.SkillName.ToLower().Contains(lower) && !s.SkillName.ToLower().StartsWith(lower))
                .ToList();
            
            // Combine and return top 15
            return exactMatches.Concat(containsMatches).Take(15).ToList();
        }
        catch
        {
            return _availableSkills.Take(15).ToList();
        }
    }

    public async Task SetSelectedOptionAsync(string step, string value)
    {
        // This allows UI to directly set selected values when user clicks a button
        await ProcessUserInputAsync(value);
    }

    private async Task<RequirementChatMessage> HandleTitleAsync(string userInput)
    {
        _state.Requirement.Title = userInput.Trim();
        _currentConversationStep = "description";
        
        return new RequirementChatMessage
        {
            Content = $"✅ Great! **{_state.Requirement.Title}** looks perfect.\n\n" +
                      "📄 **Next:** Please provide a brief **description** of the role.\n\n" +
                      "Include:\n" +
                      "• Key responsibilities\n" +
                      "• Ideal candidate profile\n" +
                      "• Team/Project details",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "description",
            HasSuggestions = false
        };
    }

    private async Task<RequirementChatMessage> HandleDescriptionAsync(string userInput)
    {
        _state.Requirement.Description = userInput.Trim();
        _currentConversationStep = "location";
        
        return new RequirementChatMessage
        {
            Content = "✅ Perfect! Description saved.\n\n" +
                      "📍 **Where** should this position be based?",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "location",
            HasSuggestions = true,
            Suggestions = new[] { "Bangalore", "Chennai", "Mumbai", "Hyderabad", "Delhi", "Pune", "Remote", "Any" }
        };
    }

    private async Task<RequirementChatMessage> HandleLocationAsync(string userInput)
    {
        _state.Requirement.Location = userInput.Trim();
        _currentConversationStep = "duration";
        
        return new RequirementChatMessage
        {
            Content = $"✅ **Location:** {userInput.Trim()}\n\n" +
                      "⏱️ **Duration of this position?**\n\n" +
                      "Choose from the options or enter a custom duration (e.g., '6 months', '1 year', '18 months')",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "duration",
            HasSuggestions = true,
            Suggestions = new[] { "3 months", "6 months", "9 months", "12 months", "18 months", "2 years", "Permanent" }
        };
    }

    private async Task<RequirementChatMessage> HandleDurationAsync(string userInput)
    {
        _state.Requirement.Duration = userInput.Trim();
        _currentConversationStep = "priority";
        
        return new RequirementChatMessage
        {
            Content = $"✅ Duration: **{userInput.Trim()}**\n\n" +
                      "🚩 **How urgent** is this requirement?",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "priority",
            HasSuggestions = true,
            Suggestions = new[] { "High (Critical)", "Medium (Soon)", "Low (Flexible)" }
        };
    }

    private async Task<RequirementChatMessage> HandlePriorityAsync(string userInput)
    {
        var priority = userInput.Trim();
        
        // Parse from button text like "High (Critical)" or just "High"
        if (priority.Contains("High", StringComparison.OrdinalIgnoreCase)) 
            _state.Requirement.Priority = "High";
        else if (priority.Contains("Medium", StringComparison.OrdinalIgnoreCase)) 
            _state.Requirement.Priority = "Medium";
        else if (priority.Contains("Low", StringComparison.OrdinalIgnoreCase)) 
            _state.Requirement.Priority = "Low";
        else 
            _state.Requirement.Priority = priority;
        
        _currentConversationStep = "add_skills";
        _state.CurrentSkillIndex = 0;
        
        return new RequirementChatMessage
        {
            Content = $"✅ **Priority:** {_state.Requirement.Priority}\n\n" +
                      "🔧 **Now for the skills!** Type or select a skill from the suggestions.\n\n" +
                      "I'll help you find the right skills from our database.\n\n" +
                      "Examples: Python, Java, AWS, Docker, React, Node.js, SQL, etc.",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "add_skills",
            HasSuggestions = false
        };
    }

    private async Task<RequirementChatMessage> HandleAddSkillsAsync(string userInput)
    {
        var skillName = userInput.Trim();
        var matchedSkill = _availableSkills.FirstOrDefault(s => 
            s.SkillName.Equals(skillName, StringComparison.OrdinalIgnoreCase));

        if (matchedSkill == null)
        {
            var suggestions = await GetSkillSuggestionsAsync(skillName);
            if (suggestions.Any())
            {
                return new RequirementChatMessage
                {
                    Content = $"❓ I found similar skills:\n\n" +
                              string.Join("\n", suggestions.Select(s => $"• {s.SkillName}")) +
                              "\n\nPlease select one from the list or type the exact skill name.",
                    IsBot = true,
                    Timestamp = DateTime.UtcNow,
                    Step = "add_skills",
                    HasSuggestions = true,
                    Suggestions = suggestions.Select(s => s.SkillName).ToArray()
                };
            }
            else
            {
                return new RequirementChatMessage
                {
                    Content = $"❌ '**{skillName}**' not found in our database.\n\n" +
                              "📚 Available skills include:\n" +
                              string.Join(", ", _availableSkills.Take(15).Select(s => $"**{s.SkillName}**")) +
                              $"\n\n...and more.\n\nPlease choose from our skill list.",
                    IsBot = true,
                    Timestamp = DateTime.UtcNow,
                    Step = "add_skills",
                    HasSuggestions = true,
                    Suggestions = _availableSkills.Take(10).Select(s => s.SkillName).ToArray()
                };
            }
        }

        // Skill found! Move to experience
        _state.CurrentSkillId = matchedSkill.SkillId;
        _state.CurrentSkillName = matchedSkill.SkillName;
        _currentConversationStep = "skill_experience";

        return new RequirementChatMessage
        {
            Content = $"✅ **{matchedSkill.SkillName}** added!\n\n" +
                      $"📊 **Minimum years of experience** required for {matchedSkill.SkillName}?",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "skill_experience",
            HasSuggestions = true,
            Suggestions = new[] { "0", "1", "2", "3", "5", "7", "10" }
        };
    }

    private async Task<RequirementChatMessage> HandleSkillExperienceAsync(string userInput)
    {
        if (!decimal.TryParse(userInput.Trim(), out var years))
        {
            return new RequirementChatMessage
            {
                Content = "⚠️ Please enter a valid number (e.g., 2, 5, 10)",
                IsBot = true,
                Timestamp = DateTime.UtcNow,
                Step = "skill_experience",
                HasSuggestions = true,
                Suggestions = new[] { "0", "1", "2", "3", "5", "7", "10" }
            };
        }

        _state.CurrentSkillExperience = years;
        _currentConversationStep = "skill_proficiency";

        return new RequirementChatMessage
        {
            Content = $"✅ **{years} years** required.\n\n" +
                      $"⭐ **What proficiency level** is needed for {_state.CurrentSkillName}?",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "skill_proficiency",
            HasSuggestions = true,
            Suggestions = new[] { "Beginner", "Intermediate", "Advanced", "Expert" }
        };
    }

    private async Task<RequirementChatMessage> HandleSkillProficiencyAsync(string userInput)
    {
        var level = userInput.Trim();
        var validLevels = new[] { "Beginner", "Intermediate", "Advanced", "Expert" };
        
        _state.CurrentSkillProficiency = validLevels.FirstOrDefault(l => 
            l.Equals(level, StringComparison.OrdinalIgnoreCase)) ?? "Intermediate";
        
        _currentConversationStep = "skill_mandatory";

        return new RequirementChatMessage
        {
            Content = $"✅ **{_state.CurrentSkillProficiency}** level set.\n\n" +
                      $"❗ **Is {_state.CurrentSkillName} mandatory** for this role?\n\n" +
                      $"(Mandatory = Must-have, Nice-to-have = Optional)",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "skill_mandatory",
            HasSuggestions = true,
            Suggestions = new[] { "Mandatory (Must-have)", "Nice-to-have (Optional)" }
        };
    }

    private async Task<RequirementChatMessage> HandleSkillMandatoryAsync(string userInput)
    {
        var userResponse = userInput.Trim().ToLower();
        
        // Parse button clicks like "Mandatory (Must-have)" or "Nice-to-have (Optional)" or just Yes/No
        var isMandatory = userResponse.Contains("mandatory") || 
                          userResponse.Contains("must-have") || 
                          userResponse.Equals("yes", StringComparison.OrdinalIgnoreCase);

        // Add skill to requirement
        var reqSkill = new RequirementSkill
        {
            SkillId = _state.CurrentSkillId,
            MinYearsRequired = _state.CurrentSkillExperience,
            ProficiencyLevel = _state.CurrentSkillProficiency ?? "Intermediate",
            IsMandatory = isMandatory,
            Weightage = isMandatory ? 5 : 3
        };

        _state.Requirement.RequirementSkills.Add(reqSkill);
        _currentConversationStep = "add_more_skills";

        var skillsList = string.Join("\n", _state.Requirement.RequirementSkills.Select((rs, idx) => 
            $"{idx + 1}. **{rs.Skill?.SkillName ?? "Unknown"}** - {rs.MinYearsRequired} yrs, {rs.ProficiencyLevel} {(rs.IsMandatory ? "🔴 Mandatory" : "🟢 Optional")}"));

        return new RequirementChatMessage
        {
            Content = $"✅ **{_state.CurrentSkillName}** set as {(isMandatory ? "**Mandatory** 🔴" : "**Optional** 🟢")}!\n\n" +
                      $"**Skills Added:**\n{skillsList}\n\n" +
                      $"➕ **Add more skills** to this requirement?",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "add_more_skills",
            HasSuggestions = true,
            Suggestions = new[] { "Yes, add more skills", "No, review requirement" }
        };
    }

    private async Task<RequirementChatMessage> HandleAddMoreSkillsAsync(string userInput)
    {
        var userResponse = userInput.ToLower();
        var addMore = userResponse.Contains("yes") || 
                      userResponse.Contains("more") || 
                      userResponse.Contains("add") ||
                      !userResponse.Contains("no") && !userResponse.Contains("review");

        if (addMore)
        {
            _currentConversationStep = "add_skills";
            return new RequirementChatMessage
            {
                Content = "🔧 **Add another skill!** Search for a skill name to continue.\n\n" +
                          $"Current skills: {_state.Requirement.RequirementSkills.Count}",
                IsBot = true,
                Timestamp = DateTime.UtcNow,
                Step = "add_skills",
                HasSuggestions = false
            };
        }
        else
        {
            _currentConversationStep = "review";
            var reviewMessage = await ShowReviewAsync();
            return reviewMessage;
        }
    }

    private async Task<RequirementChatMessage> ShowReviewAsync()
    {
        var skillsSection = _state.Requirement.RequirementSkills.Any()
            ? string.Join("\n", _state.Requirement.RequirementSkills.Select(rs =>
                $"  • {rs.Skill?.SkillName ?? "Unknown"} - {rs.MinYearsRequired} years, {rs.ProficiencyLevel}, {(rs.IsMandatory ? "🔴 Mandatory" : "🟢 Optional")}"))
            : "  (None added)";

        var summary = $"""
            📋 **REQUIREMENT SUMMARY**
            
            **Title:** {_state.Requirement.Title}
            **Description:** {_state.Requirement.Description}
            **Location:** {_state.Requirement.Location}
            **Duration:** {_state.Requirement.Duration}
            **Priority:** {_state.Requirement.Priority}
            
            **Required Skills:**
            {skillsSection}
            """;

        return new RequirementChatMessage
        {
            Content = summary + "\n\n✅ **Ready to post this requirement?**",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "review",
            HasSuggestions = true,
            Suggestions = new[] { "Yes, post it!", "No, modify" },
            IsReadyToSubmit = true
        };
    }

    private async Task<RequirementChatMessage> HandleReviewAsync(string userInput)
    {
        var userResponse = userInput.ToLower();
        var confirmed = userResponse.Contains("yes") || 
                        userResponse.Contains("post") || 
                        userResponse.Contains("confirm");

        if (confirmed)
        {
            return new RequirementChatMessage
            {
                Content = "🎉 **Perfect!** Your requirement is ready to be published.\n\n" +
                          "Click the **'📤 Post Requirement'** button below to save and publish it.",
                IsBot = true,
                Timestamp = DateTime.UtcNow,
                Step = "completed",
                IsReadyToSubmit = true
            };
        }
        else
        {
            await ResetAsync();
            return await GetInitialGreetingAsync();
        }
    }

    public async Task<RequirementChatState> GetCurrentStateAsync()
    {
        return _state;
    }

    public async Task ResetAsync()
    {
        _state = new RequirementChatState();
        _currentConversationStep = "title";
    }

    public Requirement GetCurrentRequirement()
    {
        return _state.Requirement;
    }
}
