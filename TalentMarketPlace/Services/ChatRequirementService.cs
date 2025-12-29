using TalentMarketPlace.Models;
using TalentMarketPlace.Services.Interfaces;

namespace TalentMarketPlace.Services;

public interface IChatRequirementService
{
    Task<RequirementChatMessage> GetInitialGreetingAsync();
    Task<RequirementChatMessage> ProcessUserInputAsync(string userInput);
    Task<RequirementChatState> GetCurrentStateAsync();
    Task ResetAsync();
    Requirement GetCurrentRequirement();
}

public class ChatRequirementService : IChatRequirementService
{
    private readonly IRequirementService _requirementService;
    private readonly ISkillService _skillService;
    private readonly ILogger<ChatRequirementService> _logger;
    
    private RequirementChatState _state = new();
    private int _conversationStep = 0;
    private List<Skill> _availableSkills = new();

    public ChatRequirementService(
        IRequirementService requirementService,
        ISkillService skillService,
        ILogger<ChatRequirementService> logger)
    {
        _requirementService = requirementService;
        _skillService = skillService;
        _logger = logger;
    }

    public async Task<RequirementChatMessage> GetInitialGreetingAsync()
    {
        _state = new RequirementChatState();
        _conversationStep = 0;
        _availableSkills = await _skillService.GetAllAsync();
        
        var greeting = new RequirementChatMessage
        {
            Content = "👋 Hello! I'm here to help you post a new requirement. Let's create it together!\n\n" +
                      "First, what's the **title or role name** for this requirement? " +
                      "(e.g., 'Senior Python Developer', 'Full Stack Engineer', 'DevOps Specialist')",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "title"
        };
        
        return greeting;
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
                Step = GetCurrentStep()
            };
        }

        _conversationStep++;

        try
        {
            return GetCurrentStep() switch
            {
                "title" => await HandleTitleAsync(userInput),
                "description" => await HandleDescriptionAsync(userInput),
                "location" => await HandleLocationAsync(userInput),
                "duration" => await HandleDurationAsync(userInput),
                "priority" => await HandlePriorityAsync(userInput),
                "skills" => await HandleSkillsAsync(userInput),
                "experience" => await HandleExperienceAsync(userInput),
                "proficiency" => await HandleProficiencyAsync(userInput),
                "mandatory" => await HandleMandatoryAsync(userInput),
                "add_more_skills" => await HandleAddMoreSkillsAsync(userInput),
                "confirmation" => await HandleConfirmationAsync(userInput),
                _ => await GetInitialGreetingAsync()
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing chat input");
            return new RequirementChatMessage
            {
                Content = $"Sorry, I encountered an error: {ex.Message}",
                IsBot = true,
                Timestamp = DateTime.UtcNow,
                Step = GetCurrentStep()
            };
        }
    }

    private async Task<RequirementChatMessage> HandleTitleAsync(string userInput)
    {
        _state.Requirement.Title = userInput.Trim();
        
        return new RequirementChatMessage
        {
            Content = $"Great! **{_state.Requirement.Title}** sounds good.\n\n" +
                      "Now, could you provide a brief **description** of the role? " +
                      "Include responsibilities, ideal candidate profile, and any other relevant details.",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "description"
        };
    }

    private async Task<RequirementChatMessage> HandleDescriptionAsync(string userInput)
    {
        _state.Requirement.Description = userInput.Trim();
        
        return new RequirementChatMessage
        {
            Content = "Perfect! 📝\n\n" +
                      "Where should this position be based? Here are common options:\n" +
                      "• **Bangalore**\n" +
                      "• **Chennai**\n" +
                      "• **Mumbai**\n" +
                      "• **Hyderabad**\n" +
                      "• **Any** (Remote/Flexible)\n\n" +
                      "Please type your choice or a different location.",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "location"
        };
    }

    private async Task<RequirementChatMessage> HandleLocationAsync(string userInput)
    {
        var locations = new[] { "Bangalore", "Chennai", "Mumbai", "Hyderabad", "Any" };
        var selectedLocation = locations.FirstOrDefault(l => 
            l.Equals(userInput.Trim(), StringComparison.OrdinalIgnoreCase)) 
            ?? userInput.Trim();
        
        _state.Requirement.Location = selectedLocation;
        
        return new RequirementChatMessage
        {
            Content = $"Got it! Location: **{selectedLocation}** ✓\n\n" +
                      "What's the **duration** of this position?\n" +
                      "• **3 months**\n" +
                      "• **6 months**\n" +
                      "• **12 months**\n" +
                      "• **Permanent**\n\n" +
                      "Please select or type a duration.",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "duration"
        };
    }

    private async Task<RequirementChatMessage> HandleDurationAsync(string userInput)
    {
        var durations = new[] { "3 months", "6 months", "12 months", "Permanent" };
        var selectedDuration = durations.FirstOrDefault(d => 
            d.Equals(userInput.Trim(), StringComparison.OrdinalIgnoreCase)) 
            ?? userInput.Trim();
        
        _state.Requirement.Duration = selectedDuration;
        
        return new RequirementChatMessage
        {
            Content = $"Duration set to: **{selectedDuration}** ✓\n\n" +
                      "How **urgent** is this requirement?\n" +
                      "• 🔴 **High** - Critical, needed immediately\n" +
                      "• 🟡 **Medium** - Important, needed soon\n" +
                      "• 🟢 **Low** - Flexible timeline\n\n" +
                      "Please select: High, Medium, or Low",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "priority"
        };
    }

    private async Task<RequirementChatMessage> HandlePriorityAsync(string userInput)
    {
        var priorities = new[] { "High", "Medium", "Low" };
        var selectedPriority = priorities.FirstOrDefault(p => 
            p.Equals(userInput.Trim(), StringComparison.OrdinalIgnoreCase)) 
            ?? "Medium";
        
        _state.Requirement.Priority = selectedPriority;
        
        return new RequirementChatMessage
        {
            Content = $"Priority set to: **{selectedPriority}** 📌\n\n" +
                      "Now let's identify the **required skills**. What are the main technical or professional skills needed for this role?\n\n" +
                      "You can mention multiple skills, for example: \"Python, Django, PostgreSQL, AWS, Docker\"\n\n" +
                      "Or just start with the primary skill.",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "skills"
        };
    }

    private async Task<RequirementChatMessage> HandleSkillsAsync(string userInput)
    {
        // Parse skills from user input
        var skillNames = userInput.Split(new[] { ',', ';', '&' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(s => s.Trim())
            .ToList();

        _state.SkillsInput = userInput;
        _state.IdentifiedSkills = skillNames;

        // Match skills from available database
        var matchedSkills = new List<Skill>();

        foreach (var skillName in skillNames)
        {
            var match = _availableSkills.FirstOrDefault(s => 
                s.SkillName.Equals(skillName, StringComparison.OrdinalIgnoreCase));
            if (match != null)
            {
                matchedSkills.Add(match);
            }
        }

        _state.SelectedSkillIds = matchedSkills.Select(s => s.SkillId).ToList();

        var skillList = string.Join("\n", matchedSkills.Select(s => $"• {s.SkillName}"));

        if (matchedSkills.Any())
        {
            _state.CurrentSkillIndex = 0;
            var firstSkill = matchedSkills[0];
            _state.CurrentSkillName = firstSkill.SkillName;
            _state.CurrentSkillId = firstSkill.SkillId;

            return new RequirementChatMessage
            {
                Content = $"Great! I found these skills:\n{skillList}\n\n" +
                          $"Now let's define requirements for each skill.\n\n" +
                          $"For **{firstSkill.SkillName}**: How many **minimum years of experience** are required? " +
                          $"(e.g., 0, 2, 5, 10)",
                IsBot = true,
                Timestamp = DateTime.UtcNow,
                Step = "experience"
            };
        }
        else
        {
            return new RequirementChatMessage
            {
                Content = $"I couldn't find exact matches for those skills in our system.\n\n" +
                          $"Available skills include: " + string.Join(", ", _availableSkills.Take(10).Select(s => s.SkillName)) + ", etc.\n\n" +
                          $"Could you please mention the skills again, using names from our system?",
                IsBot = true,
                Timestamp = DateTime.UtcNow,
                Step = "skills"
            };
        }
    }

    private async Task<RequirementChatMessage> HandleExperienceAsync(string userInput)
    {
        if (!decimal.TryParse(userInput.Trim(), out var years))
        {
            return new RequirementChatMessage
            {
                Content = "Please enter a valid number for years of experience (e.g., 2, 5, 10)",
                IsBot = true,
                Timestamp = DateTime.UtcNow,
                Step = "experience"
            };
        }

        _state.CurrentSkillExperience = years;

        return new RequirementChatMessage
        {
            Content = $"Good! Minimum **{years} years** of {_state.CurrentSkillName} required.\n\n" +
                      $"What **proficiency level** is needed for {_state.CurrentSkillName}?\n" +
                      "• **Beginner** - Basic knowledge\n" +
                      "• **Intermediate** - Good hands-on experience\n" +
                      "• **Advanced** - Expert level\n\n" +
                      "Please select: Beginner, Intermediate, or Advanced",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "proficiency"
        };
    }

    private async Task<RequirementChatMessage> HandleProficiencyAsync(string userInput)
    {
        var levels = new[] { "Beginner", "Intermediate", "Advanced" };
        var selectedLevel = levels.FirstOrDefault(l => 
            l.Equals(userInput.Trim(), StringComparison.OrdinalIgnoreCase)) 
            ?? "Intermediate";

        _state.CurrentSkillProficiency = selectedLevel;

        return new RequirementChatMessage
        {
            Content = $"Proficiency level set to: **{selectedLevel}** ✓\n\n" +
                      $"Is **{_state.CurrentSkillName}** a **mandatory** skill for this role?\n" +
                      "• **Yes** - Must-have, deal-breaker if missing\n" +
                      "• **No** - Nice-to-have, but not essential\n\n" +
                      "Please type: Yes or No",
            IsBot = true,
            Timestamp = DateTime.UtcNow,
            Step = "mandatory"
        };
    }

    private async Task<RequirementChatMessage> HandleMandatoryAsync(string userInput)
    {
        var isMandatory = userInput.Trim().Equals("Yes", StringComparison.OrdinalIgnoreCase);

        // Add skill to requirement
        var reqSkill = new RequirementSkill
        {
            SkillId = _state.CurrentSkillId,
            MinYearsRequired = _state.CurrentSkillExperience,
            ProficiencyLevel = _state.CurrentSkillProficiency,
            IsMandatory = isMandatory,
            Weightage = isMandatory ? 5 : 3
        };

        _state.Requirement.RequirementSkills ??= new List<RequirementSkill>();
        _state.Requirement.RequirementSkills.Add(reqSkill);

        // Move to next skill or ask for more
        if (_state.CurrentSkillIndex < _state.SelectedSkillIds.Count - 1)
        {
            _state.CurrentSkillIndex++;
            var nextSkillId = _state.SelectedSkillIds[_state.CurrentSkillIndex];
            _state.CurrentSkillId = nextSkillId;
            var nextSkill = _availableSkills.First(s => s.SkillId == nextSkillId);
            _state.CurrentSkillName = nextSkill.SkillName;

            return new RequirementChatMessage
            {
                Content = $"✅ **{_state.CurrentSkillName}** added!\n\n" +
                          $"Now for the next skill: **{nextSkill.SkillName}**\n\n" +
                          $"How many **minimum years of experience** are required?",
                IsBot = true,
                Timestamp = DateTime.UtcNow,
                Step = "experience"
            };
        }
        else
        {
            return new RequirementChatMessage
            {
                Content = $"✅ **{_state.CurrentSkillName}** added!\n\n" +
                          $"I've configured **{_state.Requirement.RequirementSkills.Count}** skill(s) so far.\n\n" +
                          $"Do you want to **add more skills** to this requirement?\n" +
                          "• **Yes** - Add another skill\n" +
                          "• **No** - Review and post\n\n" +
                          "Please type: Yes or No",
                IsBot = true,
                Timestamp = DateTime.UtcNow,
                Step = "add_more_skills"
            };
        }
    }

    private async Task<RequirementChatMessage> HandleAddMoreSkillsAsync(string userInput)
    {
        var addMore = userInput.Trim().Equals("Yes", StringComparison.OrdinalIgnoreCase);

        if (addMore)
        {
            return new RequirementChatMessage
            {
                Content = $"Perfect! You've already added:\n" +
                          string.Join("\n", _state.Requirement.RequirementSkills
                              .Select(rs => $"• {rs.Skill?.SkillName ?? "Unknown"}")) +
                          $"\n\nWhat's the next skill?",
                IsBot = true,
                Timestamp = DateTime.UtcNow,
                Step = "skills"
            };
        }
        else
        {
            // Show summary
            var summary = BuildRequirementSummary();
            return new RequirementChatMessage
            {
                Content = summary + "\n\n**Please review the above. Does everything look correct?**\n" +
                          "• **Yes** - Post this requirement\n" +
                          "• **No** - Start over\n\n" +
                          "Type: Yes or No",
                IsBot = true,
                Timestamp = DateTime.UtcNow,
                Step = "confirmation"
            };
        }
    }

    private async Task<RequirementChatMessage> HandleConfirmationAsync(string userInput)
    {
        var confirmed = userInput.Trim().Equals("Yes", StringComparison.OrdinalIgnoreCase);

        if (confirmed)
        {
            return new RequirementChatMessage
            {
                Content = "🎉 **Excellent!** Your requirement is ready to be posted.\n\n" +
                          "Click **'Post Requirement'** button below to save it to the system.",
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

    private string BuildRequirementSummary()
    {
        var lines = new List<string>
        {
            "📋 **REQUIREMENT SUMMARY**\n",
            $"**Title:** {_state.Requirement.Title}",
            $"**Description:** {_state.Requirement.Description}",
            $"**Location:** {_state.Requirement.Location}",
            $"**Duration:** {_state.Requirement.Duration}",
            $"**Priority:** {_state.Requirement.Priority}",
            "\n**Required Skills:**"
        };

        foreach (var skill in _state.Requirement.RequirementSkills ?? new List<RequirementSkill>())
        {
            var mandatory = skill.IsMandatory ? "🔴 MANDATORY" : "🟢 Nice-to-have";
            lines.Add($"• {skill.Skill?.SkillName ?? "Unknown"} - " +
                      $"{skill.MinYearsRequired} yrs, {skill.ProficiencyLevel} - {mandatory}");
        }

        return string.Join("\n", lines);
    }

    private string GetCurrentStep()
    {
        return _conversationStep switch
        {
            0 => "title",
            1 => "description",
            2 => "location",
            3 => "duration",
            4 => "priority",
            5 => "skills",
            _ => "skills"
        };
    }

    public async Task<RequirementChatState> GetCurrentStateAsync()
    {
        return _state;
    }

    public async Task ResetAsync()
    {
        _state = new RequirementChatState();
        _conversationStep = 0;
    }

    public Requirement GetCurrentRequirement()
    {
        return _state.Requirement;
    }
}

public class RequirementChatState
{
    public Requirement Requirement { get; set; } = new()
    {
        Priority = "Medium",
        Duration = "6 months",
        Status = "Open",
        Location = "Bangalore"
    };

    public List<int> SelectedSkillIds { get; set; } = new();
    public List<string> IdentifiedSkills { get; set; } = new();
    public string SkillsInput { get; set; } = string.Empty;
    
    public int CurrentSkillIndex { get; set; } = 0;
    public int CurrentSkillId { get; set; } = 0;
    public string CurrentSkillName { get; set; } = string.Empty;
    public decimal CurrentSkillExperience { get; set; } = 0;
    public string CurrentSkillProficiency { get; set; } = "Intermediate";
}

public class RequirementChatMessage
{
    public string Content { get; set; } = string.Empty;
    public bool IsBot { get; set; } = false;
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public string Step { get; set; } = string.Empty;
    public bool IsReadyToSubmit { get; set; } = false;
    public bool HasSuggestions { get; set; } = false;
    public string[]? Suggestions { get; set; } = null;
}
