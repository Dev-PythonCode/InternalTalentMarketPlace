using Microsoft.EntityFrameworkCore;
using TalentMarketPlace.Data;
using MudBlazor.Services;
using TalentMarketPlace.Services;
using TalentMarketPlace.Services.Interfaces;
using TalentMarketPlace.Models;

var builder = WebApplication.CreateBuilder(args);

// Set up URLs with custom hostname - explicitly use IPv4
builder.WebHost.UseUrls("http://127.0.0.1:5242", "http://onerrd:5242");

// Get Python API URL early for logging
var pythonApiUrl = builder.Configuration["PythonAI:ApiUrl"] ?? "http://localhost:5000";
Console.WriteLine($"🔧 Configuration: Python API URL = {pythonApiUrl}");

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<TalentMarketplaceDbContext>(options =>
    options.UseSqlServer(connectionString)
);

// Add Blazor Server
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor()
    .AddCircuitOptions(options =>
    {
        options.DetailedErrors = true;
    });

// Add MudBlazor
builder.Services.AddMudServices();

// Add HttpClient for Python API
Console.WriteLine($"🔧 Registering HttpClient for Python API...");
builder.Services.AddHttpClient();  // Add default factory

builder.Services.AddHttpClient("PythonAPI", client =>
{
    client.BaseAddress = new Uri(pythonApiUrl);
    client.Timeout = TimeSpan.FromSeconds(30);
    Console.WriteLine($"🔧 HttpClient 'PythonAPI' configured with BaseAddress: {client.BaseAddress}");
});
// Register Email Service
builder.Services.AddScoped<IEmailService, EmailService>();

// Add these two lines:
builder.Services.AddScoped<IScheduledEmailService, ScheduledEmailService>();
builder.Services.AddHostedService<ScheduledEmailBackgroundService>();

// ⭐ NEW: Level-based reminder service
builder.Services.AddScoped<ILevelReminderService, LevelReminderService>();

// Add Services
Console.WriteLine($"🔧 Registering application services...");
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

// ⭐ TEMPORARY: Use MockSkillService for Mac testing (no SQL Server)
var useMockAuth = builder.Configuration.GetValue<bool>("UseMockAuth", true); // Set to false in production
if (useMockAuth)
{
    Console.WriteLine("⚠️  USING MOCK SERVICES (No database required)");
    builder.Services.AddScoped<ISkillService, MockSkillService>();
    builder.Services.AddScoped<IAuthService, MockAuthService>();
    builder.Services.AddScoped<MockAuthStateProvider>();
}
else
{
    Console.WriteLine("🔐 Using real services (Database required)");
    builder.Services.AddScoped<ISkillService, SkillService>();
    builder.Services.AddScoped<IAuthService, AuthService>();
    builder.Services.AddScoped<AuthStateProvider>();
}

builder.Services.AddScoped<ISearchService, SearchService>();
builder.Services.AddScoped<IRequirementService, RequirementService>();
builder.Services.AddScoped<IApplicationService, ApplicationService>();
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<IPythonApiService, PythonApiService>();
builder.Services.AddScoped<ChatSessionService>();
builder.Services.AddScoped<IChatRequirementService, ChatRequirementService>();
builder.Services.AddScoped<IChatRequirementServiceV2, ChatRequirementServiceV2>();


// Add Session
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(8);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowPythonAPI", policy =>
    {
        policy.WithOrigins("http://localhost:5000", "http://127.0.0.1:5000")
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddLogging(logging =>
{
    logging.AddConsole();
    logging.AddDebug();
    logging.SetMinimumLevel(LogLevel.Debug); // Enable debug logging
});

builder.Services.Configure<PythonAISettings>(
    builder.Configuration.GetSection("PythonAI")
);

Console.WriteLine($"🔧 Building application...");
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseCors("AllowPythonAPI");
app.UseSession();

Console.WriteLine($"🔧 Running database migrations...");

// DATABASE MIGRATION & SEEDING
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<TalentMarketplaceDbContext>();
        // ⭐ Comment out migrations and just create/update the database
        if (context.Database.IsRelational())
        {
            await context.Database.EnsureCreatedAsync();
        }
        else
        {
            await context.Database.MigrateAsync();
        }
        await SeedAdditionalData(context);
        
        Console.WriteLine($"✅ Database setup completed successfully");
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while setting up the database.");
    }
}

// Test Python API connection
Console.WriteLine($"🔧 Testing Python API connection to {pythonApiUrl}...");
try
{
    using var testScope = app.Services.CreateScope();
    var pythonApiService = testScope.ServiceProvider.GetRequiredService<IPythonApiService>();
    var isHealthy = await pythonApiService.IsHealthyAsync();
    
    if (isHealthy)
    {
        Console.WriteLine($"✅ Python API is HEALTHY at {pythonApiUrl}");
    }
    else
    {
        Console.WriteLine($"⚠️ Python API health check FAILED at {pythonApiUrl}");
        Console.WriteLine($"   Make sure Python API is running: cd /Users/dev/Projects/PythonAPI && source venv/bin/activate && python app.py");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"❌ Error testing Python API: {ex.Message}");
}

Console.WriteLine($"🚀 Starting web server...");

// CRITICAL FIX: Map Blazor Hub and Fallback properly
app.MapBlazorHub();
app.MapFallbackToPage("/_Host"); // This looks for Pages/_Host.cshtml

app.Run();

async Task SeedAdditionalData(TalentMarketplaceDbContext context)
{
    if (!await context.EmployeeSkills.AnyAsync())
    {
        var employeeSkills = new List<EmployeeSkill>
        {
            new EmployeeSkill { EmployeeId = 1, SkillId = 1, YearsOfExperience = 5.0m, ProficiencyLevel = "Expert", LastUsedDate = new DateTime(2025, 12, 30), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 1, SkillId = 6, YearsOfExperience = 3.0m, ProficiencyLevel = "Advanced", LastUsedDate = new DateTime(2025, 10, 30), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 1, SkillId = 8, YearsOfExperience = 2.5m, ProficiencyLevel = "Advanced", LastUsedDate = new DateTime(2025, 11, 30), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 1, SkillId = 17, YearsOfExperience = 4.0m, ProficiencyLevel = "Advanced", LastUsedDate = new DateTime(2025, 12, 30), Source = "Manual" },
            new EmployeeSkill { EmployeeId = 2, SkillId = 2, YearsOfExperience = 4.0m, ProficiencyLevel = "Advanced", LastUsedDate = new DateTime(2025, 12, 30), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 2, SkillId = 9, YearsOfExperience = 2.0m, ProficiencyLevel = "Intermediate", LastUsedDate = new DateTime(2025, 11, 30), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 2, SkillId = 10, YearsOfExperience = 3.0m, ProficiencyLevel = "Advanced", LastUsedDate = new DateTime(2025, 12, 30), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 2, SkillId = 8, YearsOfExperience = 3.5m, ProficiencyLevel = "Expert", LastUsedDate = new DateTime(2025, 12, 30), Source = "Manual" },
            new EmployeeSkill { EmployeeId = 3, SkillId = 11, YearsOfExperience = 3.0m, ProficiencyLevel = "Advanced", LastUsedDate = new DateTime(2025, 12, 30), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 3, SkillId = 14, YearsOfExperience = 4.0m, ProficiencyLevel = "Advanced", LastUsedDate = new DateTime(2025, 12, 30), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 3, SkillId = 19, YearsOfExperience = 2.5m, ProficiencyLevel = "Intermediate", LastUsedDate = new DateTime(2025, 9, 30), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 3, SkillId = 4, YearsOfExperience = 3.5m, ProficiencyLevel = "Expert", LastUsedDate = new DateTime(2025, 12, 30), Source = "Manual" },
            new EmployeeSkill { EmployeeId = 4, SkillId = 1, YearsOfExperience = 2.0m, ProficiencyLevel = "Intermediate", LastUsedDate = new DateTime(2025, 12, 30), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 4, SkillId = 17, YearsOfExperience = 5.0m, ProficiencyLevel = "Expert", LastUsedDate = new DateTime(2025, 12, 30), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 4, SkillId = 6, YearsOfExperience = 1.0m, ProficiencyLevel = "Beginner", LastUsedDate = new DateTime(2025, 6, 30), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 5, SkillId = 12, YearsOfExperience = 5.0m, ProficiencyLevel = "Expert", LastUsedDate = new DateTime(2025, 8, 30), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 5, SkillId = 2, YearsOfExperience = 8.0m, ProficiencyLevel = "Expert", LastUsedDate = new DateTime(2025, 12, 30), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 5, SkillId = 17, YearsOfExperience = 6.0m, ProficiencyLevel = "Expert", LastUsedDate = new DateTime(2025, 12, 30), Source = "Manual" },
            new EmployeeSkill { EmployeeId = 5, SkillId = 16, YearsOfExperience = 7.0m, ProficiencyLevel = "Expert", LastUsedDate = new DateTime(2025, 12, 30), Source = "Manual" }
        };

        await context.EmployeeSkills.AddRangeAsync(employeeSkills);
        await context.SaveChangesAsync();
    }

    if (!await context.LearningResources.AnyAsync())
    {
        var learningResources = new List<LearningResource>
        {
            new LearningResource { SkillId = 1, ResourceTitle = "Complete Python Bootcamp", Provider = "Udemy", ResourceUrl = "https://udemy.com/python", ResourceType = "Course", DurationHours = 30, Level = "Beginner", Rating = 4.6m },
            new LearningResource { SkillId = 6, ResourceTitle = "AWS Certified Solutions Architect", Provider = "AWS", ResourceUrl = "https://aws.amazon.com/training", ResourceType = "Course", DurationHours = 50, Level = "Intermediate", Rating = 4.8m },
            new LearningResource { SkillId = 9, ResourceTitle = "Kubernetes for Beginners", Provider = "Coursera", ResourceUrl = "https://coursera.org/k8s", ResourceType = "Course", DurationHours = 20, Level = "Beginner", Rating = 4.5m },
            new LearningResource { SkillId = 11, ResourceTitle = "React - The Complete Guide", Provider = "Udemy", ResourceUrl = "https://udemy.com/react", ResourceType = "Course", DurationHours = 40, Level = "Intermediate", Rating = 4.7m }
        };

        await context.LearningResources.AddRangeAsync(learningResources);
        await context.SaveChangesAsync();
    }
}