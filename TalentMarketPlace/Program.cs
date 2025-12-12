using Microsoft.EntityFrameworkCore;
using TalentMarketPlace.Data;
using MudBlazor.Services;
using TalentMarketPlace.Services;
using TalentMarketPlace.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<TalentMarketplaceDbContext>(options =>
    options.UseSqlServer(
        connectionString,
        sqlOptions => sqlOptions.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(30),
            errorNumbersToAdd: null)
    ));

// Add Blazor Server
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Add MudBlazor
builder.Services.AddMudServices();

// Add HttpClient for Python API
builder.Services.AddHttpClient("PythonAPI", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["PythonApi:BaseUrl"] ?? "http://127.0.0.1:5000");
    client.Timeout = TimeSpan.FromSeconds(30);
});

// Add Services
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<ISkillService, SkillService>();
builder.Services.AddScoped<ISearchService, SearchService>();
builder.Services.AddScoped<IRequirementService, RequirementService>();
builder.Services.AddScoped<IApplicationService, ApplicationService>();
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<IPythonApiService, PythonApiService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<AuthStateProvider>();

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
});

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

// DATABASE MIGRATION & SEEDING
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<TalentMarketplaceDbContext>();
        await context.Database.MigrateAsync();
        await SeedAdditionalData(context);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while migrating the database.");
    }
}

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
            new EmployeeSkill { EmployeeId = 1, SkillId = 1, YearsOfExperience = 5.0m, ProficiencyLevel = "Expert", LastUsedDate = DateTime.Now, Source = "Auto" },
            new EmployeeSkill { EmployeeId = 1, SkillId = 6, YearsOfExperience = 3.0m, ProficiencyLevel = "Advanced", LastUsedDate = DateTime.Now.AddMonths(-2), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 1, SkillId = 8, YearsOfExperience = 2.5m, ProficiencyLevel = "Advanced", LastUsedDate = DateTime.Now.AddMonths(-1), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 1, SkillId = 17, YearsOfExperience = 4.0m, ProficiencyLevel = "Advanced", LastUsedDate = DateTime.Now, Source = "Manual" },
            new EmployeeSkill { EmployeeId = 2, SkillId = 2, YearsOfExperience = 4.0m, ProficiencyLevel = "Advanced", LastUsedDate = DateTime.Now, Source = "Auto" },
            new EmployeeSkill { EmployeeId = 2, SkillId = 9, YearsOfExperience = 2.0m, ProficiencyLevel = "Intermediate", LastUsedDate = DateTime.Now.AddMonths(-1), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 2, SkillId = 10, YearsOfExperience = 3.0m, ProficiencyLevel = "Advanced", LastUsedDate = DateTime.Now, Source = "Auto" },
            new EmployeeSkill { EmployeeId = 2, SkillId = 8, YearsOfExperience = 3.5m, ProficiencyLevel = "Expert", LastUsedDate = DateTime.Now, Source = "Manual" },
            new EmployeeSkill { EmployeeId = 3, SkillId = 11, YearsOfExperience = 3.0m, ProficiencyLevel = "Advanced", LastUsedDate = DateTime.Now, Source = "Auto" },
            new EmployeeSkill { EmployeeId = 3, SkillId = 14, YearsOfExperience = 4.0m, ProficiencyLevel = "Advanced", LastUsedDate = DateTime.Now, Source = "Auto" },
            new EmployeeSkill { EmployeeId = 3, SkillId = 19, YearsOfExperience = 2.5m, ProficiencyLevel = "Intermediate", LastUsedDate = DateTime.Now.AddMonths(-3), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 3, SkillId = 4, YearsOfExperience = 3.5m, ProficiencyLevel = "Expert", LastUsedDate = DateTime.Now, Source = "Manual" },
            new EmployeeSkill { EmployeeId = 4, SkillId = 1, YearsOfExperience = 2.0m, ProficiencyLevel = "Intermediate", LastUsedDate = DateTime.Now, Source = "Auto" },
            new EmployeeSkill { EmployeeId = 4, SkillId = 17, YearsOfExperience = 5.0m, ProficiencyLevel = "Expert", LastUsedDate = DateTime.Now, Source = "Auto" },
            new EmployeeSkill { EmployeeId = 4, SkillId = 6, YearsOfExperience = 1.0m, ProficiencyLevel = "Beginner", LastUsedDate = DateTime.Now.AddMonths(-6), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 5, SkillId = 12, YearsOfExperience = 5.0m, ProficiencyLevel = "Expert", LastUsedDate = DateTime.Now.AddMonths(-4), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 5, SkillId = 2, YearsOfExperience = 8.0m, ProficiencyLevel = "Expert", LastUsedDate = DateTime.Now, Source = "Auto" },
            new EmployeeSkill { EmployeeId = 5, SkillId = 17, YearsOfExperience = 6.0m, ProficiencyLevel = "Expert", LastUsedDate = DateTime.Now, Source = "Manual" },
            new EmployeeSkill { EmployeeId = 5, SkillId = 16, YearsOfExperience = 7.0m, ProficiencyLevel = "Expert", LastUsedDate = DateTime.Now, Source = "Manual" }
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
