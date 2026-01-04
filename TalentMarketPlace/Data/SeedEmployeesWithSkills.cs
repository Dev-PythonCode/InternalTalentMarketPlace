using Microsoft.EntityFrameworkCore;
using TalentMarketPlace.Models;
using System;
using System.Collections.Generic;

namespace TalentMarketPlace.Data
{
    /// <summary>
    /// Extended seed data for 50+ employees with diverse skills
    /// This is separated to keep the main DbContext cleaner
    /// </summary>
    public static class SeedEmployeesWithSkills
    {
        public static void SeedExtendedData(ModelBuilder modelBuilder)
        {
            // Add more users (IDs 8-57 for 50 new employees)
            var users = new List<User>();
            for (int i = 8; i <= 57; i++)
            {
                users.Add(new User
                {
                    UserId = i,
                    Email = $"employee{i}@company.com",
                    PasswordHash = $"hashedpassword{i}",
                    Role = "Employee"
                });
            }
            modelBuilder.Entity<User>().HasData(users);

            // Add more employees (IDs 8-57)
            var employees = new List<Employee>();
            var firstNames = new[] { "Amit", "Anita", "Arjun", "Akshay", "Arushi", "Ashok", "Ajay", "Alka", "Anil", "Anand",
                                     "Bhavna", "Brijesh", "Bhavik", "Balaji", "Bimla", "Bikram", "Bhanu", "Brij", "Bimal", "Bhat",
                                     "Chitra", "Chetan", "Chirag", "Charanjit", "Chanchal", "Chandra", "Chiman", "Choudary", "Chetna", "Charan",
                                     "Dhruv", "Divya", "Deepak", "Dhanvi", "Dinesh", "Disha", "Devendra", "Darshan", "Devesh", "Dilip",
                                     "Esha", "Eshan", "Ekta", "Emran", "Eswar", "Eknath", "Esteemed", "Eby", "Eman", "Ezra",
                                     "Farhan", "Faria", "Faisal", "Fiza", "Faiza", "Feroz", "Fathima", "Firoj", "Fayaz", "Fanu"};
            
            var lastNames = new[] { "Sharma", "Singh", "Patel", "Reddy", "Kumar", "Nair", "Desai", "Iyer", "Krishnan", "Rao",
                                    "Verma", "Gupta", "Joshi", "Bhat", "Rana", "Khanna", "Sharma", "Singh", "Varma", "Pillai" };
            
            var designations = new[] { "Junior Software Developer", "Senior Software Developer", "Full Stack Developer", 
                                      "Frontend Developer", "Backend Developer", "DevOps Engineer", "Cloud Engineer",
                                      "Database Administrator", "QA Engineer", "Data Analyst", "Solutions Architect",
                                      "Tech Lead", "Engineering Manager", "Principal Engineer", "Consultant" };
            
            var locations = new[] { "Bangalore", "Hyderabad", "Chennai", "Mumbai", "Pune", "Kolkata", "Delhi", "Goa" };
            var availabilityStatuses = new[] { "Available", "Limited", "Not Available" };
            var random = new Random(42); // Fixed seed for reproducibility

            int empId = 8;
            for (int i = 0; i < 50; i++)
            {
                var firstName = firstNames[i % firstNames.Length];
                var lastName = lastNames[random.Next(lastNames.Length)];
                var yearsExp = random.Next(1, 16); // 1-15 years
                var joinDate = new DateTime(2024 - yearsExp, random.Next(1, 12), random.Next(1, 28));

                employees.Add(new Employee
                {
                    EmployeeId = empId,
                    UserId = empId,
                    FullName = $"{firstName} {lastName}",
                    Email = $"employee{empId}@company.com",
                    PhoneNumber = $"98765{empId:05d}",
                    Location = locations[random.Next(locations.Length)],
                    TeamId = random.Next(1, 4), // Teams 1, 2, or 3
                    Designation = designations[random.Next(designations.Length)],
                    AvailabilityStatus = availabilityStatuses[random.Next(availabilityStatuses.Length)],
                    YearsOfExperience = yearsExp,
                    JoiningDate = joinDate,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                });
                empId++;
            }

            modelBuilder.Entity<Employee>().HasData(employees);

            // Add diverse skills to employees
            var employeeSkills = new List<EmployeeSkill>();
            int skillAssignmentId = 1;

            // Define skill pools for different roles
            var skillPools = new Dictionary<string, List<int>>
            {
                // Developer skills
                { "Developer", new List<int> { 1, 2, 3, 4, 5, 11, 12, 13, 14, 15, 16, 17, 18, 19 } },
                // DevOps/Cloud skills
                { "DevOps", new List<int> { 6, 7, 8, 9, 10, 17, 18, 19 } },
                // Frontend specific
                { "Frontend", new List<int> { 4, 5, 11, 12, 13 } },
                // Backend specific
                { "Backend", new List<int> { 1, 2, 3, 14, 15, 16, 17, 18, 19 } },
                // QA/Testing
                { "QA", new List<int> { 1, 4, 5, 17, 18, 19 } },
                // Data
                { "Data", new List<int> { 1, 2, 17, 18, 19 } }
            };

            var proficiencyLevels = new[] { "Beginner", "Intermediate", "Advanced", "Expert" };

            for (int empId2 = 8; empId2 <= 57; empId2++)
            {
                // Get designation of employee
                var emp = employees.Find(e => e.EmployeeId == empId2);
                if (emp == null) continue;

                // Determine which skill pool to use
                List<int> skillsForRole = new List<int> { 1, 2, 3, 4, 5, 11, 12, 14, 15 }; // Default

                if (emp.Designation.Contains("DevOps") || emp.Designation.Contains("Cloud"))
                    skillsForRole = skillPools["DevOps"];
                else if (emp.Designation.Contains("Frontend"))
                    skillsForRole = skillPools["Frontend"];
                else if (emp.Designation.Contains("Backend"))
                    skillsForRole = skillPools["Backend"];
                else if (emp.Designation.Contains("QA"))
                    skillsForRole = skillPools["QA"];
                else if (emp.Designation.Contains("Data") || emp.Designation.Contains("Analyst"))
                    skillsForRole = skillPools["Data"];
                else if (emp.Designation.Contains("Developer"))
                    skillsForRole = skillPools["Developer"];

                // Assign 3-6 skills to each employee
                int skillCount = random.Next(3, 7);
                var shuffledSkills = new List<int>(skillsForRole);
                
                // Fisher-Yates shuffle
                for (int i = shuffledSkills.Count - 1; i > 0; i--)
                {
                    int randomIndex = random.Next(i + 1);
                    var temp = shuffledSkills[i];
                    shuffledSkills[i] = shuffledSkills[randomIndex];
                    shuffledSkills[randomIndex] = temp;
                }

                for (int i = 0; i < Math.Min(skillCount, shuffledSkills.Count); i++)
                {
                    var skillId = shuffledSkills[i];
                    var yearsWithSkill = Math.Min(emp.YearsOfExperience, random.Next(1, 11)); // 1-10 years with skill
                    var profLevel = proficiencyLevels[random.Next(proficiencyLevels.Length)];

                    employeeSkills.Add(new EmployeeSkill
                    {
                        EmployeeSkillId = skillAssignmentId++,
                        EmployeeId = empId2,
                        SkillId = skillId,
                        YearsOfExperience = yearsWithSkill,
                        ProficiencyLevel = profLevel,
                        Source = "Manual",
                        IsVerified = random.Next(100) > 50, // 50% chance of being verified
                        LastUsedDate = DateTime.UtcNow.AddDays(-random.Next(1, 365)),
                        CreatedDate = DateTime.UtcNow,
                        UpdatedDate = DateTime.UtcNow
                    });
                }
            }

            modelBuilder.Entity<EmployeeSkill>().HasData(employeeSkills);
        }
    }
}
