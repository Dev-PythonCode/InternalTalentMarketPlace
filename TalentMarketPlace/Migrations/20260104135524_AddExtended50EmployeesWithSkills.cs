using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TalentMarketPlace.Migrations
{
    /// <inheritdoc />
    public partial class AddExtended50EmployeesWithSkills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2480), new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2490), new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2490), new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2490), new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2490), new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2490), new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2500), new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedDate", "Email", "IsActive", "PasswordHash", "Role" },
                values: new object[,]
                {
                    { 8, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1090), "employee8@company.com", true, "hashedpassword8", "Employee" },
                    { 9, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1470), "employee9@company.com", true, "hashedpassword9", "Employee" },
                    { 10, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1470), "employee10@company.com", true, "hashedpassword10", "Employee" },
                    { 11, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1480), "employee11@company.com", true, "hashedpassword11", "Employee" },
                    { 12, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1480), "employee12@company.com", true, "hashedpassword12", "Employee" },
                    { 13, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1480), "employee13@company.com", true, "hashedpassword13", "Employee" },
                    { 14, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1480), "employee14@company.com", true, "hashedpassword14", "Employee" },
                    { 15, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1480), "employee15@company.com", true, "hashedpassword15", "Employee" },
                    { 16, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1480), "employee16@company.com", true, "hashedpassword16", "Employee" },
                    { 17, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1490), "employee17@company.com", true, "hashedpassword17", "Employee" },
                    { 18, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1490), "employee18@company.com", true, "hashedpassword18", "Employee" },
                    { 19, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1490), "employee19@company.com", true, "hashedpassword19", "Employee" },
                    { 20, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1490), "employee20@company.com", true, "hashedpassword20", "Employee" },
                    { 21, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1490), "employee21@company.com", true, "hashedpassword21", "Employee" },
                    { 22, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1490), "employee22@company.com", true, "hashedpassword22", "Employee" },
                    { 23, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1490), "employee23@company.com", true, "hashedpassword23", "Employee" },
                    { 24, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1490), "employee24@company.com", true, "hashedpassword24", "Employee" },
                    { 25, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1490), "employee25@company.com", true, "hashedpassword25", "Employee" },
                    { 26, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1490), "employee26@company.com", true, "hashedpassword26", "Employee" },
                    { 27, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1490), "employee27@company.com", true, "hashedpassword27", "Employee" },
                    { 28, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1500), "employee28@company.com", true, "hashedpassword28", "Employee" },
                    { 29, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1500), "employee29@company.com", true, "hashedpassword29", "Employee" },
                    { 30, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1500), "employee30@company.com", true, "hashedpassword30", "Employee" },
                    { 31, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1500), "employee31@company.com", true, "hashedpassword31", "Employee" },
                    { 32, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1500), "employee32@company.com", true, "hashedpassword32", "Employee" },
                    { 33, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1500), "employee33@company.com", true, "hashedpassword33", "Employee" },
                    { 34, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1500), "employee34@company.com", true, "hashedpassword34", "Employee" },
                    { 35, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1500), "employee35@company.com", true, "hashedpassword35", "Employee" },
                    { 36, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1510), "employee36@company.com", true, "hashedpassword36", "Employee" },
                    { 37, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1510), "employee37@company.com", true, "hashedpassword37", "Employee" },
                    { 38, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1510), "employee38@company.com", true, "hashedpassword38", "Employee" },
                    { 39, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1510), "employee39@company.com", true, "hashedpassword39", "Employee" },
                    { 40, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1510), "employee40@company.com", true, "hashedpassword40", "Employee" },
                    { 41, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1510), "employee41@company.com", true, "hashedpassword41", "Employee" },
                    { 42, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1510), "employee42@company.com", true, "hashedpassword42", "Employee" },
                    { 43, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1510), "employee43@company.com", true, "hashedpassword43", "Employee" },
                    { 44, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1510), "employee44@company.com", true, "hashedpassword44", "Employee" },
                    { 45, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1510), "employee45@company.com", true, "hashedpassword45", "Employee" },
                    { 46, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1520), "employee46@company.com", true, "hashedpassword46", "Employee" },
                    { 47, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1520), "employee47@company.com", true, "hashedpassword47", "Employee" },
                    { 48, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1520), "employee48@company.com", true, "hashedpassword48", "Employee" },
                    { 49, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1520), "employee49@company.com", true, "hashedpassword49", "Employee" },
                    { 50, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1520), "employee50@company.com", true, "hashedpassword50", "Employee" },
                    { 51, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1520), "employee51@company.com", true, "hashedpassword51", "Employee" },
                    { 52, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1520), "employee52@company.com", true, "hashedpassword52", "Employee" },
                    { 53, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1520), "employee53@company.com", true, "hashedpassword53", "Employee" },
                    { 54, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1520), "employee54@company.com", true, "hashedpassword54", "Employee" },
                    { 55, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1520), "employee55@company.com", true, "hashedpassword55", "Employee" },
                    { 56, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1530), "employee56@company.com", true, "hashedpassword56", "Employee" },
                    { 57, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(1530), "employee57@company.com", true, "hashedpassword57", "Employee" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "AvailabilityStatus", "CreatedDate", "Designation", "Email", "FullName", "IsVectorIndexed", "JoiningDate", "LastResumeUpdate", "Location", "PhoneNumber", "PhotoUrl", "ResumeUrl", "TeamId", "UpdatedDate", "UserId", "VectorIndexedDate", "YearsOfExperience" },
                values: new object[,]
                {
                    { 8, "Limited", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8050), "Solutions Architect", "employee8@company.com", "Amit Bhat", false, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hyderabad", "9876585d", null, null, 1, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8120), 8, null, 3m },
                    { 9, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8220), "DevOps Engineer", "employee9@company.com", "Anita Reddy", false, new DateTime(2012, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "9876595d", null, null, 1, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8220), 9, null, 12m },
                    { 10, "Not Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8230), "Senior Software Developer", "employee10@company.com", "Arjun Verma", false, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mumbai", "98765105d", null, null, 1, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8230), 10, null, 1m },
                    { 11, "Limited", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8230), "Solutions Architect", "employee11@company.com", "Akshay Sharma", false, new DateTime(2015, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hyderabad", "98765115d", null, null, 3, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8230), 11, null, 9m },
                    { 12, "Not Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8230), "QA Engineer", "employee12@company.com", "Arushi Reddy", false, new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Delhi", "98765125d", null, null, 1, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8230), 12, null, 1m },
                    { 13, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8240), "Data Analyst", "employee13@company.com", "Ashok Rana", false, new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "98765135d", null, null, 3, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8240), 13, null, 6m },
                    { 14, "Limited", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8240), "Data Analyst", "employee14@company.com", "Ajay Kumar", false, new DateTime(2012, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hyderabad", "98765145d", null, null, 1, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8240), 14, null, 12m },
                    { 15, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8240), "DevOps Engineer", "employee15@company.com", "Alka Singh", false, new DateTime(2017, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hyderabad", "98765155d", null, null, 1, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8240), 15, null, 7m },
                    { 16, "Limited", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8240), "Cloud Engineer", "employee16@company.com", "Anil Singh", false, new DateTime(2013, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "98765165d", null, null, 3, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8240), 16, null, 11m },
                    { 17, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8250), "Data Analyst", "employee17@company.com", "Anand Rao", false, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "98765175d", null, null, 1, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8250), 17, null, 1m },
                    { 18, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8250), "DevOps Engineer", "employee18@company.com", "Bhavna Varma", false, new DateTime(2010, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765185d", null, null, 1, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8250), 18, null, 14m },
                    { 19, "Not Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8250), "QA Engineer", "employee19@company.com", "Brijesh Krishnan", false, new DateTime(2012, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chennai", "98765195d", null, null, 3, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8250), 19, null, 12m },
                    { 20, "Limited", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8250), "Senior Software Developer", "employee20@company.com", "Bhavik Sharma", false, new DateTime(2010, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kolkata", "98765205d", null, null, 1, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8250), 20, null, 14m },
                    { 21, "Not Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8260), "Database Administrator", "employee21@company.com", "Balaji Desai", false, new DateTime(2012, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hyderabad", "98765215d", null, null, 2, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8260), 21, null, 12m },
                    { 22, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8260), "Data Analyst", "employee22@company.com", "Bimla Khanna", false, new DateTime(2013, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765225d", null, null, 3, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8260), 22, null, 11m },
                    { 23, "Limited", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8260), "Frontend Developer", "employee23@company.com", "Bikram Desai", false, new DateTime(2010, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chennai", "98765235d", null, null, 1, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8260), 23, null, 14m },
                    { 24, "Not Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8260), "Backend Developer", "employee24@company.com", "Bhanu Krishnan", false, new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "98765245d", null, null, 1, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8260), 24, null, 2m },
                    { 25, "Not Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8270), "Principal Engineer", "employee25@company.com", "Brij Sharma", false, new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Goa", "98765255d", null, null, 1, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8270), 25, null, 1m },
                    { 26, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8270), "Full Stack Developer", "employee26@company.com", "Bimal Nair", false, new DateTime(2015, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hyderabad", "98765265d", null, null, 1, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8270), 26, null, 9m },
                    { 27, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8280), "Full Stack Developer", "employee27@company.com", "Bhat Kumar", false, new DateTime(2009, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hyderabad", "98765275d", null, null, 3, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8280), 27, null, 15m },
                    { 28, "Limited", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8280), "Principal Engineer", "employee28@company.com", "Chitra Gupta", false, new DateTime(2015, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765285d", null, null, 2, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8280), 28, null, 9m },
                    { 29, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8280), "Senior Software Developer", "employee29@company.com", "Chetan Desai", false, new DateTime(2009, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Goa", "98765295d", null, null, 3, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8280), 29, null, 15m },
                    { 30, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8280), "Cloud Engineer", "employee30@company.com", "Chirag Sharma", false, new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mumbai", "98765305d", null, null, 2, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8280), 30, null, 3m },
                    { 31, "Not Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8290), "Data Analyst", "employee31@company.com", "Charanjit Varma", false, new DateTime(2009, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chennai", "98765315d", null, null, 2, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8290), 31, null, 15m },
                    { 32, "Not Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8290), "Frontend Developer", "employee32@company.com", "Chanchal Sharma", false, new DateTime(2012, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765325d", null, null, 3, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8290), 32, null, 12m },
                    { 33, "Limited", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8290), "Senior Software Developer", "employee33@company.com", "Chandra Bhat", false, new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Delhi", "98765335d", null, null, 2, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8290), 33, null, 3m },
                    { 34, "Not Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8290), "Principal Engineer", "employee34@company.com", "Chiman Sharma", false, new DateTime(2010, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Goa", "98765345d", null, null, 2, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8290), 34, null, 14m },
                    { 35, "Not Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8290), "Senior Software Developer", "employee35@company.com", "Choudary Reddy", false, new DateTime(2015, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765355d", null, null, 3, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8290), 35, null, 9m },
                    { 36, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8300), "QA Engineer", "employee36@company.com", "Chetna Desai", false, new DateTime(2016, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765365d", null, null, 3, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8300), 36, null, 8m },
                    { 37, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8300), "Backend Developer", "employee37@company.com", "Charan Varma", false, new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chennai", "98765375d", null, null, 1, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8300), 37, null, 1m },
                    { 38, "Limited", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8300), "Consultant", "employee38@company.com", "Dhruv Singh", false, new DateTime(2016, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Delhi", "98765385d", null, null, 2, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8300), 38, null, 8m },
                    { 39, "Not Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8300), "DevOps Engineer", "employee39@company.com", "Divya Singh", false, new DateTime(2019, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765395d", null, null, 2, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8300), 39, null, 5m },
                    { 40, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8310), "Principal Engineer", "employee40@company.com", "Deepak Singh", false, new DateTime(2016, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Goa", "98765405d", null, null, 3, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8310), 40, null, 8m },
                    { 41, "Not Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8310), "Data Analyst", "employee41@company.com", "Dhanvi Nair", false, new DateTime(2015, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mumbai", "98765415d", null, null, 3, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8310), 41, null, 9m },
                    { 42, "Not Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8310), "Junior Software Developer", "employee42@company.com", "Dinesh Nair", false, new DateTime(2009, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chennai", "98765425d", null, null, 2, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8310), 42, null, 15m },
                    { 43, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8320), "Data Analyst", "employee43@company.com", "Disha Verma", false, new DateTime(2018, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765435d", null, null, 2, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8320), 43, null, 6m },
                    { 44, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8360), "DevOps Engineer", "employee44@company.com", "Devendra Bhat", false, new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chennai", "98765445d", null, null, 3, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8360), 44, null, 2m },
                    { 45, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8360), "Consultant", "employee45@company.com", "Darshan Gupta", false, new DateTime(2018, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kolkata", "98765455d", null, null, 1, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8360), 45, null, 6m },
                    { 46, "Limited", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8360), "Data Analyst", "employee46@company.com", "Devesh Bhat", false, new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Delhi", "98765465d", null, null, 2, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8360), 46, null, 3m },
                    { 47, "Limited", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8360), "Cloud Engineer", "employee47@company.com", "Dilip Krishnan", false, new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765475d", null, null, 3, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8360), 47, null, 3m },
                    { 48, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8360), "Solutions Architect", "employee48@company.com", "Esha Pillai", false, new DateTime(2013, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765485d", null, null, 3, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8370), 48, null, 11m },
                    { 49, "Limited", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8370), "Junior Software Developer", "employee49@company.com", "Eshan Gupta", false, new DateTime(2012, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765495d", null, null, 3, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8370), 49, null, 12m },
                    { 50, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8370), "Cloud Engineer", "employee50@company.com", "Ekta Krishnan", false, new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "98765505d", null, null, 3, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8370), 50, null, 3m },
                    { 51, "Not Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8370), "Cloud Engineer", "employee51@company.com", "Emran Rao", false, new DateTime(2013, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hyderabad", "98765515d", null, null, 3, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8370), 51, null, 11m },
                    { 52, "Not Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8370), "Data Analyst", "employee52@company.com", "Eswar Varma", false, new DateTime(2016, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Goa", "98765525d", null, null, 2, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8370), 52, null, 8m },
                    { 53, "Limited", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8380), "Principal Engineer", "employee53@company.com", "Eknath Verma", false, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Goa", "98765535d", null, null, 2, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8380), 53, null, 5m },
                    { 54, "Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8380), "Data Analyst", "employee54@company.com", "Esteemed Reddy", false, new DateTime(2018, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "98765545d", null, null, 1, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8380), 54, null, 6m },
                    { 55, "Not Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8380), "Senior Software Developer", "employee55@company.com", "Eby Kumar", false, new DateTime(2010, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mumbai", "98765555d", null, null, 2, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8380), 55, null, 14m },
                    { 56, "Not Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8380), "Database Administrator", "employee56@company.com", "Eman Nair", false, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kolkata", "98765565d", null, null, 1, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8380), 56, null, 9m },
                    { 57, "Not Available", new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8390), "Cloud Engineer", "employee57@company.com", "Ezra Verma", false, new DateTime(2013, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Goa", "98765575d", null, null, 2, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(8390), 57, null, 11m }
                });

            migrationBuilder.InsertData(
                table: "EmployeeSkills",
                columns: new[] { "EmployeeSkillId", "CreatedDate", "EmployeeId", "IsVerified", "LastUsedDate", "ProficiencyLevel", "SkillId", "Source", "UpdatedDate", "YearsOfExperience" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 4, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(9970), 8, true, new DateTime(2025, 3, 16, 13, 55, 24, 476, DateTimeKind.Utc).AddTicks(9880), "Advanced", 5, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(40), 2m },
                    { 2, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(120), 8, true, new DateTime(2025, 10, 24, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(120), "Intermediate", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(120), 3m },
                    { 3, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(130), 8, false, new DateTime(2025, 6, 8, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(130), "Expert", 3, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(130), 3m },
                    { 4, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(130), 8, false, new DateTime(2025, 3, 1, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(130), "Expert", 12, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(130), 3m },
                    { 5, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(130), 8, false, new DateTime(2025, 11, 27, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(130), "Expert", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(130), 3m },
                    { 6, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(130), 8, true, new DateTime(2025, 7, 1, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(130), "Beginner", 4, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(130), 3m },
                    { 7, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(170), 9, false, new DateTime(2025, 8, 17, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(170), "Beginner", 8, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(170), 2m },
                    { 8, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(170), 9, true, new DateTime(2025, 9, 25, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(170), "Expert", 10, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(170), 6m },
                    { 9, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(170), 9, true, new DateTime(2025, 6, 24, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(170), "Intermediate", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(170), 10m },
                    { 10, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(170), 9, true, new DateTime(2025, 1, 31, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(170), "Intermediate", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(170), 1m },
                    { 11, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(180), 9, false, new DateTime(2025, 10, 8, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(170), "Expert", 7, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(180), 9m },
                    { 12, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(180), 9, true, new DateTime(2025, 12, 15, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(180), "Expert", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(180), 5m },
                    { 13, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(180), 10, false, new DateTime(2025, 11, 23, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(180), "Intermediate", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(180), 1m },
                    { 14, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(180), 10, true, new DateTime(2025, 8, 29, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(180), "Intermediate", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(180), 1m },
                    { 15, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), 10, false, new DateTime(2025, 5, 20, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(180), "Advanced", 14, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), 1m },
                    { 16, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), 10, true, new DateTime(2025, 1, 19, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), "Intermediate", 11, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), 1m },
                    { 17, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), 10, false, new DateTime(2025, 8, 7, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), "Intermediate", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), 1m },
                    { 18, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), 10, false, new DateTime(2025, 1, 31, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), "Beginner", 4, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), 1m },
                    { 19, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), 11, true, new DateTime(2025, 11, 29, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), "Advanced", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), 3m },
                    { 20, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), 11, false, new DateTime(2025, 6, 20, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), "Advanced", 14, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), 3m },
                    { 21, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), 11, false, new DateTime(2025, 5, 19, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(190), "Expert", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), 5m },
                    { 22, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), 11, true, new DateTime(2025, 9, 7, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), "Intermediate", 15, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), 3m },
                    { 23, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), 12, false, new DateTime(2025, 4, 14, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), "Beginner", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), 1m },
                    { 24, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), 12, false, new DateTime(2025, 7, 27, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), "Expert", 5, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), 1m },
                    { 25, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), 12, false, new DateTime(2025, 11, 8, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), "Expert", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), 1m },
                    { 26, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), 12, true, new DateTime(2025, 2, 24, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), "Advanced", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), 1m },
                    { 27, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), 12, true, new DateTime(2025, 2, 22, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), "Advanced", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(200), 1m },
                    { 28, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(210), 13, false, new DateTime(2025, 10, 5, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(210), "Beginner", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(210), 3m },
                    { 29, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(210), 13, true, new DateTime(2025, 7, 31, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(210), "Advanced", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(210), 2m },
                    { 30, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(210), 13, true, new DateTime(2025, 2, 15, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(210), "Advanced", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(210), 1m },
                    { 31, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(210), 14, true, new DateTime(2025, 11, 25, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(210), "Intermediate", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(210), 10m },
                    { 32, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(220), 14, false, new DateTime(2025, 3, 18, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(210), "Expert", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(220), 10m },
                    { 33, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(220), 14, true, new DateTime(2025, 10, 31, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(220), "Advanced", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(220), 3m },
                    { 34, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(220), 14, false, new DateTime(2025, 2, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(220), "Beginner", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(220), 1m },
                    { 35, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(220), 14, true, new DateTime(2025, 2, 16, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(220), "Beginner", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(220), 7m },
                    { 36, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(230), 15, false, new DateTime(2025, 8, 5, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(230), "Intermediate", 10, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(230), 7m },
                    { 37, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(230), 15, false, new DateTime(2025, 4, 24, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(230), "Beginner", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), 4m },
                    { 38, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), 15, false, new DateTime(2025, 10, 14, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), "Beginner", 6, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), 7m },
                    { 39, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), 16, true, new DateTime(2025, 10, 1, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), "Expert", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), 5m },
                    { 40, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), 16, true, new DateTime(2025, 12, 11, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), "Advanced", 8, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), 7m },
                    { 41, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), 16, false, new DateTime(2025, 8, 6, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), "Beginner", 10, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), 1m },
                    { 42, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), 16, true, new DateTime(2025, 4, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), "Intermediate", 7, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), 7m },
                    { 43, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), 16, true, new DateTime(2026, 1, 1, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), "Beginner", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(240), 5m },
                    { 44, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(250), 17, true, new DateTime(2025, 1, 19, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(250), "Beginner", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(250), 1m },
                    { 45, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(250), 17, false, new DateTime(2025, 7, 21, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(250), "Intermediate", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(250), 1m },
                    { 46, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(250), 17, false, new DateTime(2025, 7, 1, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(250), "Advanced", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(250), 1m },
                    { 47, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(250), 17, true, new DateTime(2025, 10, 24, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(250), "Advanced", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(250), 1m },
                    { 48, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(250), 17, true, new DateTime(2025, 5, 18, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(250), "Advanced", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(250), 1m },
                    { 49, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(250), 18, true, new DateTime(2025, 4, 2, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(250), "Advanced", 7, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(250), 1m },
                    { 50, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), 18, false, new DateTime(2025, 8, 1, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), "Advanced", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), 4m },
                    { 51, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), 18, true, new DateTime(2025, 3, 18, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), "Beginner", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), 1m },
                    { 52, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), 18, true, new DateTime(2025, 5, 7, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), "Expert", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), 10m },
                    { 53, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), 18, false, new DateTime(2025, 8, 2, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), "Beginner", 6, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), 9m },
                    { 54, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), 18, true, new DateTime(2025, 2, 3, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), "Expert", 9, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), 1m },
                    { 55, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), 19, false, new DateTime(2025, 12, 21, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), "Advanced", 4, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), 8m },
                    { 56, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), 19, true, new DateTime(2025, 10, 5, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), "Beginner", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), 5m },
                    { 57, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(270), 19, true, new DateTime(2025, 9, 13, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(260), "Intermediate", 5, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(270), 2m },
                    { 58, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(270), 19, true, new DateTime(2025, 4, 10, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(270), "Beginner", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(270), 1m },
                    { 59, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(270), 19, true, new DateTime(2025, 4, 20, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(270), "Expert", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(270), 8m },
                    { 60, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(270), 20, false, new DateTime(2025, 2, 20, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(270), "Intermediate", 5, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(270), 4m },
                    { 61, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(270), 20, true, new DateTime(2025, 6, 11, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(270), "Expert", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(270), 6m },
                    { 62, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(270), 20, true, new DateTime(2025, 3, 30, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(270), "Beginner", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(270), 2m },
                    { 63, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), 20, false, new DateTime(2025, 1, 29, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(270), "Advanced", 12, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), 8m },
                    { 64, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), 20, false, new DateTime(2025, 11, 24, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), "Expert", 16, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), 3m },
                    { 65, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), 20, false, new DateTime(2025, 12, 22, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), "Expert", 15, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), 4m },
                    { 66, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), 21, true, new DateTime(2025, 4, 23, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), "Advanced", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), 8m },
                    { 67, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), 21, false, new DateTime(2025, 8, 2, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), "Advanced", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), 2m },
                    { 68, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), 21, true, new DateTime(2025, 4, 6, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), "Intermediate", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), 9m },
                    { 69, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), 21, false, new DateTime(2025, 4, 30, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), "Expert", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), 3m },
                    { 70, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), 21, false, new DateTime(2025, 3, 8, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), "Advanced", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(280), 6m },
                    { 71, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(290), 22, true, new DateTime(2025, 9, 25, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(290), "Intermediate", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(290), 7m },
                    { 72, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(290), 22, true, new DateTime(2025, 9, 20, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(290), "Intermediate", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(290), 2m },
                    { 73, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(290), 22, false, new DateTime(2025, 11, 8, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(290), "Intermediate", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(290), 5m },
                    { 74, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(310), 23, true, new DateTime(2025, 8, 25, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(310), "Intermediate", 12, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(310), 4m },
                    { 75, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(310), 23, false, new DateTime(2025, 8, 28, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(310), "Beginner", 5, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(310), 1m },
                    { 76, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(320), 23, false, new DateTime(2025, 3, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(320), "Advanced", 13, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(320), 1m },
                    { 77, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(320), 24, false, new DateTime(2025, 7, 20, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(320), "Beginner", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(320), 2m },
                    { 78, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(320), 24, true, new DateTime(2025, 6, 25, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(320), "Intermediate", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(320), 2m },
                    { 79, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(320), 24, false, new DateTime(2025, 1, 13, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(320), "Expert", 14, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(320), 2m },
                    { 80, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(320), 24, true, new DateTime(2025, 4, 29, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(320), "Expert", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(320), 2m },
                    { 81, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(320), 24, false, new DateTime(2025, 3, 30, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(320), "Advanced", 3, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(320), 2m },
                    { 82, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(330), 24, true, new DateTime(2025, 8, 5, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(330), "Beginner", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(330), 2m },
                    { 83, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(330), 25, false, new DateTime(2025, 3, 25, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(330), "Advanced", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(330), 1m },
                    { 84, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(330), 25, true, new DateTime(2025, 7, 15, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(330), "Beginner", 15, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(330), 1m },
                    { 85, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(330), 25, true, new DateTime(2025, 11, 12, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(330), "Advanced", 3, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(330), 1m },
                    { 86, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(330), 25, true, new DateTime(2025, 12, 21, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(330), "Intermediate", 11, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(330), 1m },
                    { 87, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(340), 26, false, new DateTime(2025, 7, 13, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(340), "Expert", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(340), 7m },
                    { 88, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(340), 26, true, new DateTime(2025, 2, 9, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(340), "Beginner", 4, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(340), 3m },
                    { 89, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(340), 26, true, new DateTime(2025, 9, 18, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(340), "Intermediate", 11, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(340), 3m },
                    { 90, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(340), 26, true, new DateTime(2025, 9, 26, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(340), "Advanced", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(340), 1m },
                    { 91, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(340), 27, false, new DateTime(2025, 8, 25, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(340), "Beginner", 4, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(340), 9m },
                    { 92, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(340), 27, true, new DateTime(2025, 8, 17, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(340), "Beginner", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(340), 9m },
                    { 93, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), 27, true, new DateTime(2025, 7, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), "Advanced", 5, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), 1m },
                    { 94, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), 27, false, new DateTime(2025, 9, 19, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), "Intermediate", 14, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), 9m },
                    { 95, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), 27, true, new DateTime(2025, 8, 22, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), "Expert", 11, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), 2m },
                    { 96, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), 28, true, new DateTime(2025, 3, 31, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), "Expert", 3, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), 2m },
                    { 97, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), 28, true, new DateTime(2025, 2, 11, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), "Advanced", 12, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), 4m },
                    { 98, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), 28, true, new DateTime(2025, 8, 18, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), "Advanced", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), 8m },
                    { 99, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), 28, false, new DateTime(2025, 11, 21, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), "Beginner", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(350), 3m },
                    { 100, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(360), 29, true, new DateTime(2025, 3, 12, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(360), "Advanced", 15, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(360), 1m },
                    { 101, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(360), 29, true, new DateTime(2025, 4, 10, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(360), "Expert", 14, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(360), 9m },
                    { 102, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(360), 29, false, new DateTime(2025, 8, 13, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(360), "Expert", 4, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(360), 5m },
                    { 103, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(360), 30, true, new DateTime(2025, 7, 31, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(360), "Expert", 9, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(360), 3m },
                    { 104, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(360), 30, true, new DateTime(2025, 12, 6, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(360), "Beginner", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(360), 3m },
                    { 105, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), 30, false, new DateTime(2025, 10, 19, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), "Expert", 6, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), 1m },
                    { 106, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), 30, true, new DateTime(2025, 10, 15, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), "Beginner", 10, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), 3m },
                    { 107, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), 31, true, new DateTime(2025, 6, 3, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), "Intermediate", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), 5m },
                    { 108, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), 31, true, new DateTime(2025, 2, 19, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), "Advanced", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), 3m },
                    { 109, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), 31, false, new DateTime(2025, 6, 18, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), "Intermediate", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), 8m },
                    { 110, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), 31, false, new DateTime(2025, 2, 7, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), "Expert", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), 7m },
                    { 111, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), 31, true, new DateTime(2025, 11, 28, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), "Expert", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(370), 2m },
                    { 112, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(380), 32, true, new DateTime(2025, 4, 7, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(380), "Beginner", 5, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(380), 5m },
                    { 113, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(380), 32, false, new DateTime(2025, 9, 3, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(380), "Expert", 4, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(380), 2m },
                    { 114, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(380), 32, false, new DateTime(2025, 3, 19, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(380), "Beginner", 13, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(380), 8m },
                    { 115, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(380), 32, true, new DateTime(2025, 3, 20, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(380), "Advanced", 11, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(380), 9m },
                    { 116, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(380), 32, true, new DateTime(2025, 2, 25, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(380), "Beginner", 12, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(380), 3m },
                    { 117, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), 33, false, new DateTime(2025, 11, 18, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), "Intermediate", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), 3m },
                    { 118, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), 33, true, new DateTime(2025, 10, 19, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), "Intermediate", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), 3m },
                    { 119, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), 33, true, new DateTime(2025, 11, 25, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), "Advanced", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), 3m },
                    { 120, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), 33, false, new DateTime(2025, 9, 15, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), "Beginner", 15, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), 3m },
                    { 121, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), 33, true, new DateTime(2025, 12, 10, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), "Advanced", 16, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), 3m },
                    { 122, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), 34, true, new DateTime(2025, 2, 21, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), "Advanced", 12, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), 9m },
                    { 123, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), 34, false, new DateTime(2025, 6, 16, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), "Expert", 4, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(390), 4m },
                    { 124, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(400), 34, false, new DateTime(2025, 2, 16, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(400), "Advanced", 5, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(400), 1m },
                    { 125, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(400), 34, true, new DateTime(2025, 1, 8, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(400), "Intermediate", 15, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(400), 5m },
                    { 126, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(400), 35, false, new DateTime(2025, 7, 24, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(400), "Beginner", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(400), 1m },
                    { 127, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(400), 35, true, new DateTime(2025, 10, 9, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(400), "Beginner", 4, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(400), 1m },
                    { 128, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(400), 35, false, new DateTime(2025, 4, 5, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(400), "Beginner", 11, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(400), 9m },
                    { 129, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(410), 36, false, new DateTime(2025, 10, 21, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(410), "Beginner", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(410), 4m },
                    { 130, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(410), 36, false, new DateTime(2025, 11, 16, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(410), "Advanced", 4, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(410), 8m },
                    { 131, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(410), 36, false, new DateTime(2025, 10, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(410), "Expert", 5, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(410), 4m },
                    { 132, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(410), 37, true, new DateTime(2025, 8, 23, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(410), "Beginner", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(410), 1m },
                    { 133, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(410), 37, true, new DateTime(2025, 8, 1, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(410), "Expert", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(410), 1m },
                    { 134, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(410), 37, true, new DateTime(2025, 11, 23, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(410), "Beginner", 15, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(410), 1m },
                    { 135, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(420), 37, false, new DateTime(2025, 7, 16, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(420), "Beginner", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(420), 1m },
                    { 136, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(420), 38, false, new DateTime(2025, 2, 22, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(420), "Advanced", 3, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(420), 8m },
                    { 137, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(420), 38, false, new DateTime(2025, 1, 15, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(420), "Advanced", 15, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(420), 3m },
                    { 138, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(420), 38, false, new DateTime(2025, 10, 2, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(420), "Expert", 5, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(420), 5m },
                    { 139, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(420), 38, true, new DateTime(2025, 1, 15, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(420), "Expert", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(420), 8m },
                    { 140, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(420), 38, true, new DateTime(2025, 9, 5, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(420), "Beginner", 14, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(420), 8m },
                    { 141, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), 38, false, new DateTime(2025, 10, 12, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), "Advanced", 11, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), 2m },
                    { 142, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), 39, false, new DateTime(2025, 7, 21, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), "Advanced", 10, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), 5m },
                    { 143, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), 39, false, new DateTime(2025, 8, 19, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), "Advanced", 9, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), 2m },
                    { 144, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), 39, false, new DateTime(2025, 8, 30, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), "Beginner", 8, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), 3m },
                    { 145, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), 39, true, new DateTime(2025, 8, 17, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), "Beginner", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), 1m },
                    { 146, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), 39, false, new DateTime(2025, 5, 17, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), "Expert", 6, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), 5m },
                    { 147, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), 39, true, new DateTime(2025, 10, 11, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), "Expert", 7, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(430), 5m },
                    { 148, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(440), 40, false, new DateTime(2025, 8, 12, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(440), "Advanced", 15, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(440), 3m },
                    { 149, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(440), 40, false, new DateTime(2025, 12, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(440), "Expert", 11, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(440), 3m },
                    { 150, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(450), 40, true, new DateTime(2025, 10, 26, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(450), "Beginner", 3, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(450), 4m },
                    { 151, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(450), 41, false, new DateTime(2025, 11, 19, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(450), "Beginner", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(450), 6m },
                    { 152, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(450), 41, false, new DateTime(2025, 11, 13, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(450), "Expert", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(450), 4m },
                    { 153, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(450), 41, true, new DateTime(2025, 7, 10, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(450), "Expert", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(450), 4m },
                    { 154, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), 42, false, new DateTime(2025, 12, 31, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), "Advanced", 11, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), 9m },
                    { 155, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), 42, true, new DateTime(2025, 11, 7, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), "Intermediate", 16, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), 1m },
                    { 156, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), 42, true, new DateTime(2025, 1, 26, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), "Expert", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), 6m },
                    { 157, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), 42, false, new DateTime(2025, 10, 2, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), "Advanced", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), 10m },
                    { 158, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), 42, true, new DateTime(2025, 5, 31, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), "Expert", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), 10m },
                    { 159, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), 43, true, new DateTime(2025, 6, 5, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), "Expert", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), 4m },
                    { 160, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), 43, false, new DateTime(2025, 6, 9, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), "Expert", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), 2m },
                    { 161, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), 43, false, new DateTime(2025, 11, 28, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), "Beginner", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(460), 2m },
                    { 162, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(470), 43, false, new DateTime(2025, 4, 16, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(470), "Expert", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(470), 4m },
                    { 163, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(470), 43, false, new DateTime(2025, 5, 25, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(470), "Advanced", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(470), 5m },
                    { 164, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(470), 44, true, new DateTime(2025, 3, 16, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(470), "Intermediate", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(470), 2m },
                    { 165, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(470), 44, true, new DateTime(2025, 9, 29, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(470), "Beginner", 7, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(470), 2m },
                    { 166, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(470), 44, false, new DateTime(2025, 1, 14, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(470), "Advanced", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(470), 2m },
                    { 167, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(470), 44, true, new DateTime(2025, 5, 15, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(470), "Intermediate", 8, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(470), 2m },
                    { 168, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), 45, false, new DateTime(2025, 1, 11, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), "Intermediate", 3, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), 2m },
                    { 169, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), 45, true, new DateTime(2025, 5, 20, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), "Expert", 4, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), 3m },
                    { 170, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), 45, true, new DateTime(2025, 10, 8, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), "Advanced", 11, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), 6m },
                    { 171, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), 45, false, new DateTime(2025, 9, 22, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), "Expert", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), 6m },
                    { 172, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), 45, true, new DateTime(2025, 11, 30, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), "Expert", 14, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), 1m },
                    { 173, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), 46, false, new DateTime(2025, 8, 22, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), "Advanced", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), 1m },
                    { 174, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), 46, false, new DateTime(2025, 9, 10, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(480), "Beginner", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), 3m },
                    { 175, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), 46, true, new DateTime(2025, 10, 8, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), "Beginner", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), 3m },
                    { 176, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), 46, true, new DateTime(2025, 2, 22, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), "Advanced", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), 3m },
                    { 177, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), 47, true, new DateTime(2025, 9, 25, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), "Beginner", 7, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), 3m },
                    { 178, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), 47, false, new DateTime(2025, 7, 7, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), "Beginner", 10, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), 3m },
                    { 179, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), 47, false, new DateTime(2025, 9, 23, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), "Advanced", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), 3m },
                    { 180, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), 47, false, new DateTime(2025, 6, 23, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), "Intermediate", 9, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(490), 3m },
                    { 181, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(500), 48, true, new DateTime(2025, 10, 14, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(500), "Beginner", 12, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(500), 3m },
                    { 182, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(500), 48, false, new DateTime(2025, 9, 27, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(500), "Expert", 5, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(500), 1m },
                    { 183, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(500), 48, false, new DateTime(2025, 11, 23, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(500), "Advanced", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(500), 7m },
                    { 184, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(500), 48, false, new DateTime(2025, 2, 26, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(500), "Expert", 4, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(500), 1m },
                    { 185, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(500), 49, true, new DateTime(2025, 12, 6, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(500), "Intermediate", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(500), 6m },
                    { 186, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(510), 49, false, new DateTime(2025, 9, 26, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(510), "Beginner", 15, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(510), 2m },
                    { 187, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(510), 49, false, new DateTime(2025, 12, 30, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(510), "Advanced", 13, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(510), 4m },
                    { 188, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(510), 50, false, new DateTime(2026, 1, 3, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(510), "Beginner", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(510), 2m },
                    { 189, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(510), 50, true, new DateTime(2025, 11, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(510), "Expert", 7, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(510), 3m },
                    { 190, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(510), 50, false, new DateTime(2025, 8, 5, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(510), "Intermediate", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(510), 1m },
                    { 191, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(510), 50, false, new DateTime(2025, 2, 28, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(510), "Advanced", 9, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(510), 3m },
                    { 192, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(520), 50, true, new DateTime(2025, 10, 16, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(520), "Expert", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(520), 3m },
                    { 193, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(520), 50, true, new DateTime(2025, 12, 21, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(520), "Expert", 8, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(520), 3m },
                    { 194, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(520), 51, true, new DateTime(2025, 7, 31, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(520), "Advanced", 7, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(520), 7m },
                    { 195, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(520), 51, false, new DateTime(2025, 10, 11, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(520), "Advanced", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(520), 3m },
                    { 196, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(520), 51, false, new DateTime(2025, 12, 26, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(520), "Beginner", 6, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(520), 2m },
                    { 197, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), 52, false, new DateTime(2025, 10, 19, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), "Expert", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), 3m },
                    { 198, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), 52, false, new DateTime(2025, 6, 5, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), "Intermediate", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), 8m },
                    { 199, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), 52, false, new DateTime(2025, 6, 11, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), "Expert", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), 1m },
                    { 200, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), 53, true, new DateTime(2025, 6, 19, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), "Expert", 15, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), 5m },
                    { 201, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), 53, true, new DateTime(2025, 6, 22, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), "Intermediate", 14, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), 1m },
                    { 202, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), 53, false, new DateTime(2025, 12, 21, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), "Intermediate", 3, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), 5m },
                    { 203, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), 53, true, new DateTime(2025, 3, 22, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), "Intermediate", 11, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(530), 3m },
                    { 204, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(540), 54, true, new DateTime(2025, 5, 7, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(540), "Expert", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(540), 2m },
                    { 205, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(540), 54, false, new DateTime(2025, 1, 9, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(540), "Advanced", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(540), 6m },
                    { 206, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(540), 54, false, new DateTime(2025, 7, 10, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(540), "Expert", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(540), 2m },
                    { 207, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(540), 54, false, new DateTime(2025, 2, 15, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(540), "Advanced", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(540), 6m },
                    { 208, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), 55, false, new DateTime(2025, 2, 12, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), "Expert", 14, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), 10m },
                    { 209, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), 55, true, new DateTime(2025, 2, 16, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), "Beginner", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), 5m },
                    { 210, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), 55, true, new DateTime(2025, 6, 17, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), "Expert", 5, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), 4m },
                    { 211, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), 55, false, new DateTime(2025, 6, 18, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), "Advanced", 13, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), 8m },
                    { 212, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), 55, true, new DateTime(2025, 2, 9, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), "Expert", 11, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), 7m },
                    { 213, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), 56, true, new DateTime(2025, 11, 16, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), "Advanced", 17, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), 9m },
                    { 214, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), 56, true, new DateTime(2025, 4, 9, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), "Advanced", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), 7m },
                    { 215, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), 56, false, new DateTime(2025, 10, 5, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), "Expert", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(550), 5m },
                    { 216, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(560), 56, false, new DateTime(2025, 9, 23, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(560), "Beginner", 2, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(560), 7m },
                    { 217, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(560), 56, false, new DateTime(2025, 2, 27, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(560), "Intermediate", 1, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(560), 8m },
                    { 218, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(560), 57, true, new DateTime(2025, 5, 22, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(560), "Beginner", 8, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(560), 4m },
                    { 219, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(560), 57, true, new DateTime(2025, 6, 26, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(560), "Beginner", 19, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(560), 2m },
                    { 220, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(560), 57, true, new DateTime(2025, 9, 23, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(560), "Advanced", 18, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(560), 8m },
                    { 221, new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(560), 57, false, new DateTime(2025, 6, 14, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(560), "Expert", 7, "Manual", new DateTime(2026, 1, 4, 13, 55, 24, 477, DateTimeKind.Utc).AddTicks(560), 10m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 57);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(9560), new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 2, 18, 11, 56, 220, DateTimeKind.Utc).AddTicks(350), new DateTime(2026, 1, 2, 18, 11, 56, 220, DateTimeKind.Utc).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 2, 18, 11, 56, 220, DateTimeKind.Utc).AddTicks(360), new DateTime(2026, 1, 2, 18, 11, 56, 220, DateTimeKind.Utc).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 2, 18, 11, 56, 220, DateTimeKind.Utc).AddTicks(360), new DateTime(2026, 1, 2, 18, 11, 56, 220, DateTimeKind.Utc).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 2, 18, 11, 56, 220, DateTimeKind.Utc).AddTicks(360), new DateTime(2026, 1, 2, 18, 11, 56, 220, DateTimeKind.Utc).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 2, 18, 11, 56, 220, DateTimeKind.Utc).AddTicks(360), new DateTime(2026, 1, 2, 18, 11, 56, 220, DateTimeKind.Utc).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 2, 18, 11, 56, 220, DateTimeKind.Utc).AddTicks(360), new DateTime(2026, 1, 2, 18, 11, 56, 220, DateTimeKind.Utc).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 2, 18, 11, 56, 219, DateTimeKind.Utc).AddTicks(8930));
        }
    }
}
