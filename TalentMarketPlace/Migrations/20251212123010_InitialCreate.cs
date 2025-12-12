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
                name: "SkillCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    DisplayOrder = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillCategories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Role = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SkillName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    ResourceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SkillId = table.Column<int>(type: "INTEGER", nullable: false),
                    ResourceTitle = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Provider = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    ResourceUrl = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    ResourceType = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    DurationHours = table.Column<int>(type: "INTEGER", nullable: false),
                    Level = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(3,2)", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
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
                    AliasId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SkillId = table.Column<int>(type: "INTEGER", nullable: false),
                    AliasName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    ApplicationId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RequirementId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    CoverLetter = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    MatchPercentage = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    AIScore = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    AIRecommendation = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    Status = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    ManagerFeedback = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    AppliedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReviewedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProjects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProjectName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    Role = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Client = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSkills",
                columns: table => new
                {
                    ProjectSkillId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProjectId = table.Column<int>(type: "INTEGER", nullable: false),
                    SkillId = table.Column<int>(type: "INTEGER", nullable: false),
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
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Location = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    TeamId = table.Column<int>(type: "INTEGER", nullable: true),
                    Designation = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    AvailabilityStatus = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    YearsOfExperience = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PhotoUrl = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    ResumeUrl = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    LastResumeUpdate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsVectorIndexed = table.Column<bool>(type: "INTEGER", nullable: false),
                    VectorIndexedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    EmployeeSkillId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    SkillId = table.Column<int>(type: "INTEGER", nullable: false),
                    YearsOfExperience = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    ProficiencyLevel = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    LastUsedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Source = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    IsVerified = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    SearchId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SearchedById = table.Column<int>(type: "INTEGER", nullable: false),
                    SearchQuery = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Filters = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    ResultCount = table.Column<int>(type: "INTEGER", nullable: false),
                    SearchDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsSaved = table.Column<bool>(type: "INTEGER", nullable: false),
                    SavedSearchName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
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
                    TeamId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Department = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    ManagerId = table.Column<int>(type: "INTEGER", nullable: true),
                    Location = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
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
                    RequirementId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    PostedById = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamId = table.Column<int>(type: "INTEGER", nullable: true),
                    Location = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Duration = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Priority = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Status = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    ViewCount = table.Column<int>(type: "INTEGER", nullable: false),
                    ApplicationCount = table.Column<int>(type: "INTEGER", nullable: false),
                    PostedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
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
                    RecommendationId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    ResourceId = table.Column<int>(type: "INTEGER", nullable: false),
                    RequirementId = table.Column<int>(type: "INTEGER", nullable: true),
                    Reason = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Priority = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    IsCompleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    RecommendedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CompletedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
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
                    NotificationId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    RequirementId = table.Column<int>(type: "INTEGER", nullable: true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Message = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    Type = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    IsRead = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReadDate = table.Column<DateTime>(type: "TEXT", nullable: true)
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
                    RequirementSkillId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RequirementId = table.Column<int>(type: "INTEGER", nullable: false),
                    SkillId = table.Column<int>(type: "INTEGER", nullable: false),
                    MinYearsRequired = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    ProficiencyLevel = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    IsMandatory = table.Column<bool>(type: "INTEGER", nullable: false),
                    Weightage = table.Column<int>(type: "INTEGER", nullable: false)
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
                    { 1, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(450), "arun.kumar@company.com", true, "hashedpassword1", "Employee" },
                    { 2, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(450), "beena.singh@company.com", true, "hashedpassword2", "Employee" },
                    { 3, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(460), "rajesh.nair@company.com", true, "hashedpassword3", "Employee" },
                    { 4, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(460), "priya.sharma@company.com", true, "hashedpassword4", "Employee" },
                    { 5, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(460), "vikram.reddy@company.com", true, "hashedpassword5", "Employee" },
                    { 6, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(460), "hr.manager@company.com", true, "hashedpassword6", "HR" },
                    { 7, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(460), "tech.manager@company.com", true, "hashedpassword7", "Manager" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "AvailabilityStatus", "CreatedDate", "Designation", "Email", "FullName", "IsVectorIndexed", "JoiningDate", "LastResumeUpdate", "Location", "PhoneNumber", "PhotoUrl", "ResumeUrl", "TeamId", "UpdatedDate", "UserId", "VectorIndexedDate", "YearsOfExperience" },
                values: new object[,]
                {
                    { 1, "Available", new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(480), "Senior Software Engineer", "arun.kumar@company.com", "Arun Kumar", false, new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "9876543210", null, null, 1, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(480), 1, null, 5m },
                    { 2, "Limited", new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(490), "DevOps Engineer", "beena.singh@company.com", "Beena Singh", false, new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "9876543211", null, null, 3, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(490), 2, null, 4m },
                    { 3, "Available", new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(490), "Full Stack Developer", "rajesh.nair@company.com", "Rajesh Veerasamy", false, new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chennai", "9876543212", null, null, 1, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(490), 3, null, 3m },
                    { 4, "Available", new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(490), "Backend Developer", "priya.sharma@company.com", "Priya Sharma", false, new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "9876543213", null, null, 2, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(490), 4, null, 2m },
                    { 5, "Not Available", new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(500), "Tech Lead", "vikram.reddy@company.com", "Vikram Raja", false, new DateTime(2016, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chennai", "9876543214", null, null, 1, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(500), 5, null, 8m },
                    { 6, "Available", new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(500), "HR Manager", "hr.manager@company.com", "HR Manager", false, new DateTime(2014, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "9876543215", null, null, null, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(500), 6, null, 10m },
                    { 7, "Available", new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(500), "Engineering Manager", "tech.manager@company.com", "Tech Manager", false, new DateTime(2012, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "9876543216", null, null, 1, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(500), 7, null, 12m }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "SkillId", "CategoryId", "CreatedDate", "Description", "IsActive", "SkillName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(410), "Python programming language", true, "Python" },
                    { 2, 1, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(410), "Java programming language", true, "Java" },
                    { 3, 1, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(410), "C# programming language", true, "C#" },
                    { 4, 1, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(410), "JavaScript programming language", true, "JavaScript" },
                    { 5, 1, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(410), "TypeScript programming language", true, "TypeScript" },
                    { 6, 2, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(410), "Amazon Web Services", true, "AWS" },
                    { 7, 2, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(410), "Microsoft Azure", true, "Azure" },
                    { 8, 2, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(410), "Docker containerization", true, "Docker" },
                    { 9, 2, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(410), "Kubernetes orchestration", true, "Kubernetes" },
                    { 10, 2, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(410), "Jenkins CI/CD", true, "Jenkins" },
                    { 11, 3, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(410), "React.js library", true, "React" },
                    { 12, 3, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(410), "Angular framework", true, "Angular" },
                    { 13, 3, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(410), "Vue.js framework", true, "Vue.js" },
                    { 14, 4, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(420), "Node.js runtime", true, "Node.js" },
                    { 15, 4, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(420), "ASP.NET Core framework", true, "ASP.NET Core" },
                    { 16, 4, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(420), "Spring Boot framework", true, "Spring Boot" },
                    { 17, 5, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(420), "Microsoft SQL Server", true, "SQL Server" },
                    { 18, 5, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(420), "PostgreSQL database", true, "PostgreSQL" },
                    { 19, 5, new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(420), "MongoDB NoSQL database", true, "MongoDB" }
                });

            migrationBuilder.InsertData(
                table: "SkillAliases",
                columns: new[] { "AliasId", "AliasName", "CreatedDate", "SkillId" },
                values: new object[,]
                {
                    { 1, "K8s", new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(430), 9 },
                    { 2, "K8", new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(440), 9 },
                    { 3, "JS", new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(440), 4 },
                    { 4, "TS", new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(440), 5 },
                    { 5, "React.js", new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(440), 11 },
                    { 6, "ReactJS", new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(440), 11 },
                    { 7, "NodeJS", new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(440), 14 },
                    { 8, "MSSQL", new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(440), 17 },
                    { 9, "MS SQL", new DateTime(2025, 12, 12, 12, 30, 10, 92, DateTimeKind.Utc).AddTicks(440), 17 }
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
