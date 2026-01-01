using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TalentMarketPlace.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecipientCount = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    SentBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RecipientType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RecipientList = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CcAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    SuccessCount = table.Column<int>(type: "int", nullable: false),
                    FailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduledEmails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recipients = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CcAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ScheduledTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ErrorMessage = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    SuccessCount = table.Column<int>(type: "int", nullable: false),
                    FailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduledEmails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillCategories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                    table.ForeignKey(
                        name: "FK_Skills_SkillCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "SkillCategories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LearningResources",
                columns: table => new
                {
                    ResourceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    ResourceTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Provider = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ResourceUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ResourceType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DurationHours = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(3,2)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningResources", x => x.ResourceId);
                    table.ForeignKey(
                        name: "FK_LearningResources_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SkillAliases",
                columns: table => new
                {
                    AliasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    AliasName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillAliases", x => x.AliasId);
                    table.ForeignKey(
                        name: "FK_SkillAliases_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequirementId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ApplicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CoverLetter = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    MatchPercentage = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    AIScore = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    AIRecommendation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ManagerFeedback = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    AppliedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProjects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSkills",
                columns: table => new
                {
                    ProjectSkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    YearsUsed = table.Column<decimal>(type: "decimal(4,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSkills", x => x.ProjectSkillId);
                    table.ForeignKey(
                        name: "FK_ProjectSkills_EmployeeProjects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "EmployeeProjects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AvailabilityStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    YearsOfExperience = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhotoUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ResumeUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    LastResumeUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsVectorIndexed = table.Column<bool>(type: "bit", nullable: false),
                    VectorIndexedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSkills",
                columns: table => new
                {
                    EmployeeSkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    YearsOfExperience = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    ProficiencyLevel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastUsedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSkills", x => x.EmployeeSkillId);
                    table.ForeignKey(
                        name: "FK_EmployeeSkills_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SearchHistories",
                columns: table => new
                {
                    SearchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SearchedById = table.Column<int>(type: "int", nullable: false),
                    SearchQuery = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Filters = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    ResultCount = table.Column<int>(type: "int", nullable: false),
                    SearchDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsSaved = table.Column<bool>(type: "bit", nullable: false),
                    SavedSearchName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchHistories", x => x.SearchId);
                    table.ForeignKey(
                        name: "FK_SearchHistories_Employees_SearchedById",
                        column: x => x.SearchedById,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Department = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Teams_Employees_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Requirements",
                columns: table => new
                {
                    RequirementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    PostedById = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Priority = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    ApplicationCount = table.Column<int>(type: "int", nullable: false),
                    PostedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requirements", x => x.RequirementId);
                    table.ForeignKey(
                        name: "FK_Requirements_Employees_PostedById",
                        column: x => x.PostedById,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requirements_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "LearningRecommendations",
                columns: table => new
                {
                    RecommendationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ResourceId = table.Column<int>(type: "int", nullable: false),
                    RequirementId = table.Column<int>(type: "int", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    RecommendedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningRecommendations", x => x.RecommendationId);
                    table.ForeignKey(
                        name: "FK_LearningRecommendations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LearningRecommendations_LearningResources_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "LearningResources",
                        principalColumn: "ResourceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LearningRecommendations_Requirements_RequirementId",
                        column: x => x.RequirementId,
                        principalTable: "Requirements",
                        principalColumn: "RequirementId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    RequirementId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReadDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                    table.ForeignKey(
                        name: "FK_Notifications_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notifications_Requirements_RequirementId",
                        column: x => x.RequirementId,
                        principalTable: "Requirements",
                        principalColumn: "RequirementId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "RequirementSkills",
                columns: table => new
                {
                    RequirementSkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequirementId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    MinYearsRequired = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    ProficiencyLevel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsMandatory = table.Column<bool>(type: "bit", nullable: false),
                    Weightage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequirementSkills", x => x.RequirementSkillId);
                    table.ForeignKey(
                        name: "FK_RequirementSkills_Requirements_RequirementId",
                        column: x => x.RequirementId,
                        principalTable: "Requirements",
                        principalColumn: "RequirementId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequirementSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "SkillCategories",
                columns: new[] { "CategoryId", "CategoryName", "Description", "DisplayOrder" },
                values: new object[,]
                {
                    { 1, "Programming Languages", null, 1 },
                    { 2, "Cloud & DevOps", null, 2 },
                    { 3, "Frontend Technologies", null, 3 },
                    { 4, "Backend Technologies", null, 4 },
                    { 5, "Databases", null, 5 },
                    { 6, "Mobile Development", null, 6 },
                    { 7, "Data Science & AI", null, 7 },
                    { 8, "Testing & QA", null, 8 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "Department", "IsActive", "Location", "ManagerId", "TeamName" },
                values: new object[,]
                {
                    { 1, "Technology", true, "Bangalore", null, "Engineering" },
                    { 2, "Product Management", true, "Chennai", null, "Product" },
                    { 3, "Technology", true, "Bangalore", null, "DevOps" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedDate", "Email", "IsActive", "PasswordHash", "Role" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(3676), "arun.kumar@company.com", true, "hashedpassword1", "Employee" },
                    { 2, new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(6064), "beena.singh@company.com", true, "hashedpassword2", "Employee" },
                    { 3, new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(6068), "rajesh.nair@company.com", true, "hashedpassword3", "Employee" },
                    { 4, new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(6070), "priya.sharma@company.com", true, "hashedpassword4", "Employee" },
                    { 5, new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(6073), "vikram.reddy@company.com", true, "hashedpassword5", "Employee" },
                    { 6, new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(6114), "hr.manager@company.com", true, "hashedpassword6", "HR" },
                    { 7, new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(6115), "tech.manager@company.com", true, "hashedpassword7", "Manager" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "AvailabilityStatus", "CreatedDate", "Designation", "Email", "FullName", "IsVectorIndexed", "JoiningDate", "LastResumeUpdate", "Location", "PhoneNumber", "PhotoUrl", "ResumeUrl", "TeamId", "UpdatedDate", "UserId", "VectorIndexedDate", "YearsOfExperience" },
                values: new object[,]
                {
                    { 1, "Available", new DateTime(2025, 12, 31, 17, 15, 56, 776, DateTimeKind.Utc).AddTicks(3088), "Senior Software Engineer", "arun.kumar@company.com", "Arun Kumar", false, new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "9876543210", null, null, 1, new DateTime(2025, 12, 31, 17, 15, 56, 776, DateTimeKind.Utc).AddTicks(3090), 1, null, 5m },
                    { 2, "Limited", new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(12), "DevOps Engineer", "beena.singh@company.com", "Beena Singh", false, new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "9876543211", null, null, 3, new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(13), 2, null, 4m },
                    { 3, "Available", new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(22), "Full Stack Developer", "rajesh.nair@company.com", "Rajesh Veerasamy", false, new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chennai", "9876543212", null, null, 1, new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(23), 3, null, 3m },
                    { 4, "Available", new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(27), "Backend Developer", "priya.sharma@company.com", "Priya Sharma", false, new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "9876543213", null, null, 2, new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(27), 4, null, 2m },
                    { 5, "Not Available", new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(31), "Tech Lead", "vikram.reddy@company.com", "Vikram Raja", false, new DateTime(2016, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chennai", "9876543214", null, null, 1, new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(31), 5, null, 8m },
                    { 6, "Available", new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(35), "HR Manager", "hr.manager@company.com", "HR Manager", false, new DateTime(2014, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "9876543215", null, null, null, new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(35), 6, null, 10m },
                    { 7, "Available", new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(38), "Engineering Manager", "tech.manager@company.com", "Tech Manager", false, new DateTime(2012, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "9876543216", null, null, 1, new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(39), 7, null, 12m }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "SkillId", "CategoryId", "CreatedDate", "Description", "IsActive", "SkillName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(6533), "Python programming language", true, "Python" },
                    { 2, 1, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9121), "Java programming language", true, "Java" },
                    { 3, 1, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9124), "C# programming language", true, "C#" },
                    { 4, 1, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9126), "JavaScript programming language", true, "JavaScript" },
                    { 5, 1, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9128), "TypeScript programming language", true, "TypeScript" },
                    { 6, 2, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9129), "Amazon Web Services", true, "AWS" },
                    { 7, 2, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9131), "Microsoft Azure", true, "Azure" },
                    { 8, 2, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9133), "Docker containerization", true, "Docker" },
                    { 9, 2, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9135), "Kubernetes orchestration", true, "Kubernetes" },
                    { 10, 2, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9184), "Jenkins CI/CD", true, "Jenkins" },
                    { 11, 3, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9185), "React.js library", true, "React" },
                    { 12, 3, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9187), "Angular framework", true, "Angular" },
                    { 13, 3, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9189), "Vue.js framework", true, "Vue.js" },
                    { 14, 4, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9191), "Node.js runtime", true, "Node.js" },
                    { 15, 4, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9193), "ASP.NET Core framework", true, "ASP.NET Core" },
                    { 16, 4, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9195), "Spring Boot framework", true, "Spring Boot" },
                    { 17, 5, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9196), "Microsoft SQL Server", true, "SQL Server" },
                    { 18, 5, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9198), "PostgreSQL database", true, "PostgreSQL" },
                    { 19, 5, new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9200), "MongoDB NoSQL database", true, "MongoDB" }
                });

            migrationBuilder.InsertData(
                table: "SkillAliases",
                columns: new[] { "AliasId", "AliasName", "CreatedDate", "SkillId" },
                values: new object[,]
                {
                    { 1, "K8s", new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(487), 9 },
                    { 2, "K8", new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(2383), 9 },
                    { 3, "JS", new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(2386), 4 },
                    { 4, "TS", new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(2388), 5 },
                    { 5, "React.js", new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(2390), 11 },
                    { 6, "ReactJS", new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(2391), 11 },
                    { 7, "NodeJS", new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(2393), 14 },
                    { 8, "MSSQL", new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(2394), 17 },
                    { 9, "MS SQL", new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(2396), 17 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_EmployeeId",
                table: "Applications",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_RequirementId",
                table: "Applications",
                column: "RequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailHistory_SentDate",
                table: "EmailHistory",
                column: "SentDate");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjects_EmployeeId",
                table: "EmployeeProjects",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                table: "Employees",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TeamId",
                table: "Employees",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSkills_EmployeeId",
                table: "EmployeeSkills",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSkills_SkillId",
                table: "EmployeeSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_LearningRecommendations_EmployeeId",
                table: "LearningRecommendations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LearningRecommendations_RequirementId",
                table: "LearningRecommendations",
                column: "RequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_LearningRecommendations_ResourceId",
                table: "LearningRecommendations",
                column: "ResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_LearningResources_SkillId",
                table: "LearningResources",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_EmployeeId",
                table: "Notifications",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_RequirementId",
                table: "Notifications",
                column: "RequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkills_ProjectId",
                table: "ProjectSkills",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkills_SkillId",
                table: "ProjectSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Requirements_PostedById",
                table: "Requirements",
                column: "PostedById");

            migrationBuilder.CreateIndex(
                name: "IX_Requirements_TeamId",
                table: "Requirements",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_RequirementSkills_RequirementId",
                table: "RequirementSkills",
                column: "RequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_RequirementSkills_SkillId",
                table: "RequirementSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledEmails_ScheduledTime_Status",
                table: "ScheduledEmails",
                columns: new[] { "ScheduledTime", "Status" });

            migrationBuilder.CreateIndex(
                name: "IX_SearchHistories_SearchedById",
                table: "SearchHistories",
                column: "SearchedById");

            migrationBuilder.CreateIndex(
                name: "IX_SkillAliases_AliasName",
                table: "SkillAliases",
                column: "AliasName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SkillAliases_SkillId",
                table: "SkillAliases",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CategoryId",
                table: "Skills",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_SkillName",
                table: "Skills",
                column: "SkillName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ManagerId",
                table: "Teams",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Employees_EmployeeId",
                table: "Applications",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Requirements_RequirementId",
                table: "Applications",
                column: "RequirementId",
                principalTable: "Requirements",
                principalColumn: "RequirementId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProjects_Employees_EmployeeId",
                table: "EmployeeProjects",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Teams_TeamId",
                table: "Employees",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Employees_ManagerId",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "EmailHistory");

            migrationBuilder.DropTable(
                name: "EmployeeSkills");

            migrationBuilder.DropTable(
                name: "LearningRecommendations");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "ProjectSkills");

            migrationBuilder.DropTable(
                name: "RequirementSkills");

            migrationBuilder.DropTable(
                name: "ScheduledEmails");

            migrationBuilder.DropTable(
                name: "SearchHistories");

            migrationBuilder.DropTable(
                name: "SkillAliases");

            migrationBuilder.DropTable(
                name: "LearningResources");

            migrationBuilder.DropTable(
                name: "EmployeeProjects");

            migrationBuilder.DropTable(
                name: "Requirements");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "SkillCategories");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
