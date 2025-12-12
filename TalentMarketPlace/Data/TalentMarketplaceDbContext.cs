using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace TalentMarketPlace.Data
{
    public class TalentMarketplaceDbContext : DbContext
    {
        public TalentMarketplaceDbContext(DbContextOptions<TalentMarketplaceDbContext> options)
            : base(options)
        {
        }

        // DbSets
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<SkillCategory> SkillCategories { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillAlias> SkillAliases { get; set; }
        public DbSet<EmployeeSkill> EmployeeSkills { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        public DbSet<ProjectSkill> ProjectSkills { get; set; }
        public DbSet<Requirement> Requirements { get; set; }
        public DbSet<RequirementSkill> RequirementSkills { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<SearchHistory> SearchHistories { get; set; }
        public DbSet<LearningResource> LearningResources { get; set; }
        public DbSet<LearningRecommendation> LearningRecommendations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ============================================
            // UNIQUE CONSTRAINTS
            // ============================================

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<Employee>()
                .HasIndex(e => e.Email)
                .IsUnique();

            modelBuilder.Entity<Skill>()
                .HasIndex(s => s.SkillName)
                .IsUnique();

            modelBuilder.Entity<SkillAlias>()
                .HasIndex(sa => sa.AliasName)
                .IsUnique();

            // ============================================
            // RELATIONSHIPS
            // ============================================

            // User → Employee (One-to-One)
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.User)
                .WithOne(u => u.Employee)
                .HasForeignKey<Employee>(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Team → Manager (Self-referencing)
            modelBuilder.Entity<Team>()
                .HasOne(t => t.Manager)
                .WithMany()
                .HasForeignKey(t => t.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);

            // Team → Employees (One-to-Many)
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Team)
                .WithMany(t => t.Employees)
                .HasForeignKey(e => e.TeamId)
                .OnDelete(DeleteBehavior.SetNull);

            // SkillCategory → Skills (One-to-Many)
            modelBuilder.Entity<Skill>()
                .HasOne(s => s.Category)
                .WithMany(c => c.Skills)
                .HasForeignKey(s => s.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Skill → SkillAliases (One-to-Many)
            modelBuilder.Entity<SkillAlias>()
                .HasOne(sa => sa.Skill)
                .WithMany(s => s.SkillAliases)
                .HasForeignKey(sa => sa.SkillId)
                .OnDelete(DeleteBehavior.Cascade);

            // Employee → EmployeeSkills (One-to-Many)
            modelBuilder.Entity<EmployeeSkill>()
                .HasOne(es => es.Employee)
                .WithMany(e => e.EmployeeSkills)
                .HasForeignKey(es => es.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Skill → EmployeeSkills (One-to-Many)
            modelBuilder.Entity<EmployeeSkill>()
                .HasOne(es => es.Skill)
                .WithMany(s => s.EmployeeSkills)
                .HasForeignKey(es => es.SkillId)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee → EmployeeProjects (One-to-Many)
            modelBuilder.Entity<EmployeeProject>()
                .HasOne(ep => ep.Employee)
                .WithMany(e => e.EmployeeProjects)
                .HasForeignKey(ep => ep.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // EmployeeProject → ProjectSkills (One-to-Many)
            modelBuilder.Entity<ProjectSkill>()
                .HasOne(ps => ps.Project)
                .WithMany(ep => ep.ProjectSkills)
                .HasForeignKey(ps => ps.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            // Skill → ProjectSkills (One-to-Many)
            modelBuilder.Entity<ProjectSkill>()
                .HasOne(ps => ps.Skill)
                .WithMany(s => s.ProjectSkills)
                .HasForeignKey(ps => ps.SkillId)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee → Requirements (One-to-Many) - PostedBy
            modelBuilder.Entity<Requirement>()
                .HasOne(r => r.PostedBy)
                .WithMany(e => e.PostedRequirements)
                .HasForeignKey(r => r.PostedById)
                .OnDelete(DeleteBehavior.Restrict);

            // Team → Requirements (One-to-Many)
            modelBuilder.Entity<Requirement>()
                .HasOne(r => r.Team)
                .WithMany(t => t.Requirements)
                .HasForeignKey(r => r.TeamId)
                .OnDelete(DeleteBehavior.SetNull);

            // Requirement → RequirementSkills (One-to-Many)
            modelBuilder.Entity<RequirementSkill>()
                .HasOne(rs => rs.Requirement)
                .WithMany(r => r.RequirementSkills)
                .HasForeignKey(rs => rs.RequirementId)
                .OnDelete(DeleteBehavior.Cascade);

            // Skill → RequirementSkills (One-to-Many)
            modelBuilder.Entity<RequirementSkill>()
                .HasOne(rs => rs.Skill)
                .WithMany(s => s.RequirementSkills)
                .HasForeignKey(rs => rs.SkillId)
                .OnDelete(DeleteBehavior.Restrict);

            // Requirement → Applications (One-to-Many)
            modelBuilder.Entity<Application>()
                .HasOne(a => a.Requirement)
                .WithMany(r => r.Applications)
                .HasForeignKey(a => a.RequirementId)
                .OnDelete(DeleteBehavior.Cascade);

            // Employee → Applications (One-to-Many)
            modelBuilder.Entity<Application>()
                .HasOne(a => a.Employee)
                .WithMany(e => e.Applications)
                .HasForeignKey(a => a.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee → Notifications (One-to-Many)
            modelBuilder.Entity<Notification>()
                .HasOne(n => n.Employee)
                .WithMany(e => e.Notifications)
                .HasForeignKey(n => n.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Requirement → Notifications (One-to-Many)
            modelBuilder.Entity<Notification>()
                .HasOne(n => n.Requirement)
                .WithMany(r => r.Notifications)
                .HasForeignKey(n => n.RequirementId)
                .OnDelete(DeleteBehavior.SetNull);

            // Employee → SearchHistory (One-to-Many)
            modelBuilder.Entity<SearchHistory>()
                .HasOne(sh => sh.SearchedBy)
                .WithMany(e => e.SearchHistories)
                .HasForeignKey(sh => sh.SearchedById)
                .OnDelete(DeleteBehavior.Cascade);

            // Skill → LearningResources (One-to-Many)
            modelBuilder.Entity<LearningResource>()
                .HasOne(lr => lr.Skill)
                .WithMany(s => s.LearningResources)
                .HasForeignKey(lr => lr.SkillId)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee → LearningRecommendations (One-to-Many)
            modelBuilder.Entity<LearningRecommendation>()
                .HasOne(lr => lr.Employee)
                .WithMany(e => e.LearningRecommendations)
                .HasForeignKey(lr => lr.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // LearningResource → LearningRecommendations (One-to-Many)
            modelBuilder.Entity<LearningRecommendation>()
                .HasOne(lr => lr.Resource)
                .WithMany(r => r.LearningRecommendations)
                .HasForeignKey(lr => lr.ResourceId)
                .OnDelete(DeleteBehavior.Restrict);

            // Requirement → LearningRecommendations (One-to-Many)
            modelBuilder.Entity<LearningRecommendation>()
                .HasOne(lr => lr.Requirement)
                .WithMany(r => r.LearningRecommendations)
                .HasForeignKey(lr => lr.RequirementId)
                .OnDelete(DeleteBehavior.SetNull);

            // ============================================
            // SEED DATA
            // ============================================

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // Seed Skill Categories
            modelBuilder.Entity<SkillCategory>().HasData(
                new SkillCategory { CategoryId = 1, CategoryName = "Programming Languages", DisplayOrder = 1 },
                new SkillCategory { CategoryId = 2, CategoryName = "Cloud & DevOps", DisplayOrder = 2 },
                new SkillCategory { CategoryId = 3, CategoryName = "Frontend Technologies", DisplayOrder = 3 },
                new SkillCategory { CategoryId = 4, CategoryName = "Backend Technologies", DisplayOrder = 4 },
                new SkillCategory { CategoryId = 5, CategoryName = "Databases", DisplayOrder = 5 },
                new SkillCategory { CategoryId = 6, CategoryName = "Mobile Development", DisplayOrder = 6 },
                new SkillCategory { CategoryId = 7, CategoryName = "Data Science & AI", DisplayOrder = 7 },
                new SkillCategory { CategoryId = 8, CategoryName = "Testing & QA", DisplayOrder = 8 }
            );

            // Seed Skills
            modelBuilder.Entity<Skill>().HasData(
                // Programming Languages
                new Skill { SkillId = 1, SkillName = "Python", CategoryId = 1, Description = "Python programming language" },
                new Skill { SkillId = 2, SkillName = "Java", CategoryId = 1, Description = "Java programming language" },
                new Skill { SkillId = 3, SkillName = "C#", CategoryId = 1, Description = "C# programming language" },
                new Skill { SkillId = 4, SkillName = "JavaScript", CategoryId = 1, Description = "JavaScript programming language" },
                new Skill { SkillId = 5, SkillName = "TypeScript", CategoryId = 1, Description = "TypeScript programming language" },

                // Cloud & DevOps
                new Skill { SkillId = 6, SkillName = "AWS", CategoryId = 2, Description = "Amazon Web Services" },
                new Skill { SkillId = 7, SkillName = "Azure", CategoryId = 2, Description = "Microsoft Azure" },
                new Skill { SkillId = 8, SkillName = "Docker", CategoryId = 2, Description = "Docker containerization" },
                new Skill { SkillId = 9, SkillName = "Kubernetes", CategoryId = 2, Description = "Kubernetes orchestration" },
                new Skill { SkillId = 10, SkillName = "Jenkins", CategoryId = 2, Description = "Jenkins CI/CD" },

                // Frontend
                new Skill { SkillId = 11, SkillName = "React", CategoryId = 3, Description = "React.js library" },
                new Skill { SkillId = 12, SkillName = "Angular", CategoryId = 3, Description = "Angular framework" },
                new Skill { SkillId = 13, SkillName = "Vue.js", CategoryId = 3, Description = "Vue.js framework" },

                // Backend
                new Skill { SkillId = 14, SkillName = "Node.js", CategoryId = 4, Description = "Node.js runtime" },
                new Skill { SkillId = 15, SkillName = "ASP.NET Core", CategoryId = 4, Description = "ASP.NET Core framework" },
                new Skill { SkillId = 16, SkillName = "Spring Boot", CategoryId = 4, Description = "Spring Boot framework" },

                // Databases
                new Skill { SkillId = 17, SkillName = "SQL Server", CategoryId = 5, Description = "Microsoft SQL Server" },
                new Skill { SkillId = 18, SkillName = "PostgreSQL", CategoryId = 5, Description = "PostgreSQL database" },
                new Skill { SkillId = 19, SkillName = "MongoDB", CategoryId = 5, Description = "MongoDB NoSQL database" }
            );

            // Seed Skill Aliases
            modelBuilder.Entity<SkillAlias>().HasData(
                new SkillAlias { AliasId = 1, SkillId = 9, AliasName = "K8s" },
                new SkillAlias { AliasId = 2, SkillId = 9, AliasName = "K8" },
                new SkillAlias { AliasId = 3, SkillId = 4, AliasName = "JS" },
                new SkillAlias { AliasId = 4, SkillId = 5, AliasName = "TS" },
                new SkillAlias { AliasId = 5, SkillId = 11, AliasName = "React.js" },
                new SkillAlias { AliasId = 6, SkillId = 11, AliasName = "ReactJS" },
                new SkillAlias { AliasId = 7, SkillId = 14, AliasName = "NodeJS" },
                new SkillAlias { AliasId = 8, SkillId = 17, AliasName = "MSSQL" },
                new SkillAlias { AliasId = 9, SkillId = 17, AliasName = "MS SQL" }
            );

            // Seed Users
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Email = "arun.kumar@company.com", PasswordHash = "hashedpassword1", Role = "Employee" },
                new User { UserId = 2, Email = "beena.singh@company.com", PasswordHash = "hashedpassword2", Role = "Employee" },
                new User { UserId = 3, Email = "rajesh.nair@company.com", PasswordHash = "hashedpassword3", Role = "Employee" },
                new User { UserId = 4, Email = "priya.sharma@company.com", PasswordHash = "hashedpassword4", Role = "Employee" },
                new User { UserId = 5, Email = "vikram.reddy@company.com", PasswordHash = "hashedpassword5", Role = "Employee" },
                new User { UserId = 6, Email = "hr.manager@company.com", PasswordHash = "hashedpassword6", Role = "HR" },
                new User { UserId = 7, Email = "tech.manager@company.com", PasswordHash = "hashedpassword7", Role = "Manager" }
            );

            // Seed Teams
            modelBuilder.Entity<Team>().HasData(
                new Team { TeamId = 1, TeamName = "Engineering", Department = "Technology", Location = "Bangalore" },
                new Team { TeamId = 2, TeamName = "Product", Department = "Product Management", Location = "Chennai" },
                new Team { TeamId = 3, TeamName = "DevOps", Department = "Technology", Location = "Bangalore" }
            );

            // Seed Employees
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    UserId = 1,
                    FullName = "Arun Kumar",
                    Email = "arun.kumar@company.com",
                    PhoneNumber = "9876543210",
                    Location = "Bangalore",
                    TeamId = 1,
                    Designation = "Senior Software Engineer",
                    AvailabilityStatus = "Available",
                    YearsOfExperience = 5,
                    JoiningDate = new DateTime(2019, 1, 15)
                },
                new Employee
                {
                    EmployeeId = 2,
                    UserId = 2,
                    FullName = "Beena Singh",
                    Email = "beena.singh@company.com",
                    PhoneNumber = "9876543211",
                    Location = "Bangalore",
                    TeamId = 3,
                    Designation = "DevOps Engineer",
                    AvailabilityStatus = "Limited",
                    YearsOfExperience = 4,
                    JoiningDate = new DateTime(2020, 3, 10)
                },
                new Employee
                {
                    EmployeeId = 3,
                    UserId = 3,
                    FullName = "Rajesh Veerasamy",
                    Email = "rajesh.nair@company.com",
                    PhoneNumber = "9876543212",
                    Location = "Chennai",
                    TeamId = 1,
                    Designation = "Full Stack Developer",
                    AvailabilityStatus = "Available",
                    YearsOfExperience = 3,
                    JoiningDate = new DateTime(2021, 5, 20)
                },
                new Employee
                {
                    EmployeeId = 4,
                    UserId = 4,
                    FullName = "Priya Sharma",
                    Email = "priya.sharma@company.com",
                    PhoneNumber = "9876543213",
                    Location = "Bangalore",
                    TeamId = 2,
                    Designation = "Backend Developer",
                    AvailabilityStatus = "Available",
                    YearsOfExperience = 2,
                    JoiningDate = new DateTime(2022, 8, 1)
                },
                new Employee
                {
                    EmployeeId = 5,
                    UserId = 5,
                    FullName = "Vikram Raja",
                    Email = "vikram.reddy@company.com",
                    PhoneNumber = "9876543214",
                    Location = "Chennai",
                    TeamId = 1,
                    Designation = "Tech Lead",
                    AvailabilityStatus = "Not Available",
                    YearsOfExperience = 8,
                    JoiningDate = new DateTime(2016, 11, 5)
                },
                new Employee
                {
                    EmployeeId = 6,
                    UserId = 6,
                    FullName = "HR Manager",
                    Email = "hr.manager@company.com",
                    PhoneNumber = "9876543215",
                    Location = "Bangalore",
                    Designation = "HR Manager",
                    AvailabilityStatus = "Available",
                    YearsOfExperience = 10,
                    JoiningDate = new DateTime(2014, 1, 10)
                },
                new Employee
                {
                    EmployeeId = 7,
                    UserId = 7,
                    FullName = "Tech Manager",
                    Email = "tech.manager@company.com",
                    PhoneNumber = "9876543216",
                    Location = "Bangalore",
                    TeamId = 1,
                    Designation = "Engineering Manager",
                    AvailabilityStatus = "Available",
                    YearsOfExperience = 12,
                    JoiningDate = new DateTime(2012, 6, 15)
                }
            );
        }
    }
}

