using Microsoft.EntityFrameworkCore;
using TalentMarketPlace.Data;
using MudBlazor.Services;
using TalentMarketPlace.Services;

var builder = WebApplication.CreateBuilder(args);

// ============================================
// ADD SERVICES TO THE CONTAINER
// ============================================

// Add Database Context
builder.Services.AddDbContext<TalentMarketplaceDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlOptions => sqlOptions.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(30),
            errorNumbersToAdd: null)
    ));

// Add Blazor Server
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Add MudBlazor (UI Component Library)
builder.Services.AddMudServices();

// Add HttpClient for Python API calls
builder.Services.AddHttpClient("PythonAPI", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["PythonAPI:BaseUrl"] ?? "http://localhost:5000");
    client.Timeout = TimeSpan.FromMinutes(5);
});

// Add Scoped Services
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<ISkillService, SkillService>();
builder.Services.AddScoped<ISearchService, SearchService>();
builder.Services.AddScoped<IRequirementService, RequirementService>();
builder.Services.AddScoped<IApplicationService, ApplicationService>();
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<IPythonApiService, PythonApiService>();

// Add Authentication (Simple for hackathon)
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

// Add CORS for Python API
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowPythonAPI", policy =>
    {
        policy.WithOrigins("http://localhost:5000", "http://127.0.0.1:5000")
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// ============================================
// CONFIGURE THE HTTP REQUEST PIPELINE
// ============================================

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

// ============================================
// DATABASE MIGRATION & SEEDING
// ============================================

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<TalentMarketplaceDbContext>();

        // Apply pending migrations
        context.Database.Migrate();

        // Seed additional data if needed
        await SeedAdditionalData(context);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while migrating the database.");
    }
}

app.Run();

// ============================================
// SEED ADDITIONAL DATA METHOD
// ============================================

async Task SeedAdditionalData(TalentMarketplaceDbContext context)
{
    // Check if EmployeeSkills data already exists
    if (!context.EmployeeSkills.Any())
    {
        var employeeSkills = new List<EmployeeSkill>
        {
            // Arun Kumar - Python, AWS, Docker
            new EmployeeSkill { EmployeeId = 1, SkillId = 1, YearsOfExperience = 5.0m, ProficiencyLevel = "Expert", LastUsedDate = DateTime.Now, Source = "Auto" },
            new EmployeeSkill { EmployeeId = 1, SkillId = 6, YearsOfExperience = 3.0m, ProficiencyLevel = "Advanced", LastUsedDate = DateTime.Now.AddMonths(-2), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 1, SkillId = 8, YearsOfExperience = 2.5m, ProficiencyLevel = "Advanced", LastUsedDate = DateTime.Now.AddMonths(-1), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 1, SkillId = 17, YearsOfExperience = 4.0m, ProficiencyLevel = "Advanced", LastUsedDate = DateTime.Now, Source = "Manual" },

            // Beena Singh - Java, Kubernetes, Jenkins
            new EmployeeSkill { EmployeeId = 2, SkillId = 2, YearsOfExperience = 4.0m, ProficiencyLevel = "Advanced", LastUsedDate = DateTime.Now, Source = "Auto" },
            new EmployeeSkill { EmployeeId = 2, SkillId = 9, YearsOfExperience = 2.0m, ProficiencyLevel = "Intermediate", LastUsedDate = DateTime.Now.AddMonths(-1), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 2, SkillId = 10, YearsOfExperience = 3.0m, ProficiencyLevel = "Advanced", LastUsedDate = DateTime.Now, Source = "Auto" },
            new EmployeeSkill { EmployeeId = 2, SkillId = 8, YearsOfExperience = 3.5m, ProficiencyLevel = "Expert", LastUsedDate = DateTime.Now, Source = "Manual" },

            // Rajesh Nair - React, Node.js, MongoDB
            new EmployeeSkill { EmployeeId = 3, SkillId = 11, YearsOfExperience = 3.0m, ProficiencyLevel = "Advanced", LastUsedDate = DateTime.Now, Source = "Auto" },
            new EmployeeSkill { EmployeeId = 3, SkillId = 14, YearsOfExperience = 4.0m, ProficiencyLevel = "Advanced", LastUsedDate = DateTime.Now, Source = "Auto" },
            new EmployeeSkill { EmployeeId = 3, SkillId = 19, YearsOfExperience = 2.5m, ProficiencyLevel = "Intermediate", LastUsedDate = DateTime.Now.AddMonths(-3), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 3, SkillId = 4, YearsOfExperience = 3.5m, ProficiencyLevel = "Expert", LastUsedDate = DateTime.Now, Source = "Manual" },

            // Priya Sharma - Python, SQL Server, AWS
            new EmployeeSkill { EmployeeId = 4, SkillId = 1, YearsOfExperience = 2.0m, ProficiencyLevel = "Intermediate", LastUsedDate = DateTime.Now, Source = "Auto" },
            new EmployeeSkill { EmployeeId = 4, SkillId = 17, YearsOfExperience = 5.0m, ProficiencyLevel = "Expert", LastUsedDate = DateTime.Now, Source = "Auto" },
            new EmployeeSkill { EmployeeId = 4, SkillId = 6, YearsOfExperience = 1.0m, ProficiencyLevel = "Beginner", LastUsedDate = DateTime.Now.AddMonths(-6), Source = "Auto" },

            // Vikram Reddy - Angular, Java, SQL Server
            new EmployeeSkill { EmployeeId = 5, SkillId = 12, YearsOfExperience = 5.0m, ProficiencyLevel = "Expert", LastUsedDate = DateTime.Now.AddMonths(-4), Source = "Auto" },
            new EmployeeSkill { EmployeeId = 5, SkillId = 2, YearsOfExperience = 8.0m, ProficiencyLevel = "Expert", LastUsedDate = DateTime.Now, Source = "Auto" },
            new EmployeeSkill { EmployeeId = 5, SkillId = 17, YearsOfExperience = 6.0m, ProficiencyLevel = "Expert", LastUsedDate = DateTime.Now, Source = "Manual" },
            new EmployeeSkill { EmployeeId = 5, SkillId = 16, YearsOfExperience = 7.0m, ProficiencyLevel = "Expert", LastUsedDate = DateTime.Now, Source = "Manual" }
        };

        context.EmployeeSkills.AddRange(employeeSkills);
        await context.SaveChangesAsync();
    }

    // Seed Learning Resources
    if (!context.LearningResources.Any())
    {
        var learningResources = new List<LearningResource>
        {
            new LearningResource { SkillId = 1, ResourceTitle = "Complete Python Bootcamp", Provider = "Udemy", ResourceUrl = "https://udemy.com/python", ResourceType = "Course", DurationHours = 30, Level = "Beginner", Rating = 4.6m },
            new LearningResource { SkillId = 6, ResourceTitle = "AWS Certified Solutions Architect", Provider = "AWS", ResourceUrl = "https://aws.amazon.com/training", ResourceType = "Course", DurationHours = 50, Level = "Intermediate", Rating = 4.8m },
            new LearningResource { SkillId = 9, ResourceTitle = "Kubernetes for Beginners", Provider = "Coursera", ResourceUrl = "https://coursera.org/k8s", ResourceType = "Course", DurationHours = 20, Level = "Beginner", Rating = 4.5m },
            new LearningResource { SkillId = 11, ResourceTitle = "React - The Complete Guide", Provider = "Udemy", ResourceUrl = "https://udemy.com/react", ResourceType = "Course", DurationHours = 40, Level = "Intermediate", Rating = 4.7m }
        };

        context.LearningResources.AddRange(learningResources);
        await context.SaveChangesAsync();
    }
}