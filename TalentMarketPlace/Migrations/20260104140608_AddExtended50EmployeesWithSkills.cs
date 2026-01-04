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
                values: new object[] { new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(7350), new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(7360), new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(7360), new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(7360), new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(7360), new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(7360), new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(7370), new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedDate", "Email", "IsActive", "PasswordHash", "Role" },
                values: new object[,]
                {
                    { 8, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(5820), "employee8@company.com", true, "hashedpassword8", "Employee" },
                    { 9, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6200), "employee9@company.com", true, "hashedpassword9", "Employee" },
                    { 10, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6200), "employee10@company.com", true, "hashedpassword10", "Employee" },
                    { 11, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6210), "employee11@company.com", true, "hashedpassword11", "Employee" },
                    { 12, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6210), "employee12@company.com", true, "hashedpassword12", "Employee" },
                    { 13, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6210), "employee13@company.com", true, "hashedpassword13", "Employee" },
                    { 14, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6210), "employee14@company.com", true, "hashedpassword14", "Employee" },
                    { 15, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6220), "employee15@company.com", true, "hashedpassword15", "Employee" },
                    { 16, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6230), "employee16@company.com", true, "hashedpassword16", "Employee" },
                    { 17, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6230), "employee17@company.com", true, "hashedpassword17", "Employee" },
                    { 18, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6230), "employee18@company.com", true, "hashedpassword18", "Employee" },
                    { 19, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6230), "employee19@company.com", true, "hashedpassword19", "Employee" },
                    { 20, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6230), "employee20@company.com", true, "hashedpassword20", "Employee" },
                    { 21, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6240), "employee21@company.com", true, "hashedpassword21", "Employee" },
                    { 22, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6240), "employee22@company.com", true, "hashedpassword22", "Employee" },
                    { 23, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6240), "employee23@company.com", true, "hashedpassword23", "Employee" },
                    { 24, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6240), "employee24@company.com", true, "hashedpassword24", "Employee" },
                    { 25, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6240), "employee25@company.com", true, "hashedpassword25", "Employee" },
                    { 26, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6240), "employee26@company.com", true, "hashedpassword26", "Employee" },
                    { 27, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6240), "employee27@company.com", true, "hashedpassword27", "Employee" },
                    { 28, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6240), "employee28@company.com", true, "hashedpassword28", "Employee" },
                    { 29, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6240), "employee29@company.com", true, "hashedpassword29", "Employee" },
                    { 30, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6240), "employee30@company.com", true, "hashedpassword30", "Employee" },
                    { 31, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6250), "employee31@company.com", true, "hashedpassword31", "Employee" },
                    { 32, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6250), "employee32@company.com", true, "hashedpassword32", "Employee" },
                    { 33, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6250), "employee33@company.com", true, "hashedpassword33", "Employee" },
                    { 34, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6250), "employee34@company.com", true, "hashedpassword34", "Employee" },
                    { 35, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6250), "employee35@company.com", true, "hashedpassword35", "Employee" },
                    { 36, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6250), "employee36@company.com", true, "hashedpassword36", "Employee" },
                    { 37, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6250), "employee37@company.com", true, "hashedpassword37", "Employee" },
                    { 38, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6250), "employee38@company.com", true, "hashedpassword38", "Employee" },
                    { 39, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6250), "employee39@company.com", true, "hashedpassword39", "Employee" },
                    { 40, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6250), "employee40@company.com", true, "hashedpassword40", "Employee" },
                    { 41, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6260), "employee41@company.com", true, "hashedpassword41", "Employee" },
                    { 42, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6260), "employee42@company.com", true, "hashedpassword42", "Employee" },
                    { 43, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6260), "employee43@company.com", true, "hashedpassword43", "Employee" },
                    { 44, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6260), "employee44@company.com", true, "hashedpassword44", "Employee" },
                    { 45, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6260), "employee45@company.com", true, "hashedpassword45", "Employee" },
                    { 46, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6260), "employee46@company.com", true, "hashedpassword46", "Employee" },
                    { 47, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6260), "employee47@company.com", true, "hashedpassword47", "Employee" },
                    { 48, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6260), "employee48@company.com", true, "hashedpassword48", "Employee" },
                    { 49, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6260), "employee49@company.com", true, "hashedpassword49", "Employee" },
                    { 50, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6260), "employee50@company.com", true, "hashedpassword50", "Employee" },
                    { 51, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6270), "employee51@company.com", true, "hashedpassword51", "Employee" },
                    { 52, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6270), "employee52@company.com", true, "hashedpassword52", "Employee" },
                    { 53, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6270), "employee53@company.com", true, "hashedpassword53", "Employee" },
                    { 54, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6270), "employee54@company.com", true, "hashedpassword54", "Employee" },
                    { 55, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6270), "employee55@company.com", true, "hashedpassword55", "Employee" },
                    { 56, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6270), "employee56@company.com", true, "hashedpassword56", "Employee" },
                    { 57, new DateTime(2026, 1, 4, 14, 6, 8, 61, DateTimeKind.Utc).AddTicks(6270), "employee57@company.com", true, "hashedpassword57", "Employee" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "AvailabilityStatus", "CreatedDate", "Designation", "Email", "FullName", "IsVectorIndexed", "JoiningDate", "LastResumeUpdate", "Location", "PhoneNumber", "PhotoUrl", "ResumeUrl", "TeamId", "UpdatedDate", "UserId", "VectorIndexedDate", "YearsOfExperience" },
                values: new object[,]
                {
                    { 8, "Limited", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2530), "Solutions Architect", "employee8@company.com", "Amit Bhat", false, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hyderabad", "9876585d", null, null, 1, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2610), 8, null, 3m },
                    { 9, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2720), "DevOps Engineer", "employee9@company.com", "Anita Reddy", false, new DateTime(2012, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "9876595d", null, null, 1, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2720), 9, null, 12m },
                    { 10, "Not Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2730), "Senior Software Developer", "employee10@company.com", "Arjun Verma", false, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mumbai", "98765105d", null, null, 1, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2730), 10, null, 1m },
                    { 11, "Limited", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2730), "Solutions Architect", "employee11@company.com", "Akshay Sharma", false, new DateTime(2015, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hyderabad", "98765115d", null, null, 3, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2730), 11, null, 9m },
                    { 12, "Not Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2730), "QA Engineer", "employee12@company.com", "Arushi Reddy", false, new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Delhi", "98765125d", null, null, 1, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2730), 12, null, 1m },
                    { 13, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2740), "Data Analyst", "employee13@company.com", "Ashok Rana", false, new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "98765135d", null, null, 3, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2740), 13, null, 6m },
                    { 14, "Limited", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2740), "Data Analyst", "employee14@company.com", "Ajay Kumar", false, new DateTime(2012, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hyderabad", "98765145d", null, null, 1, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2740), 14, null, 12m },
                    { 15, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2740), "DevOps Engineer", "employee15@company.com", "Alka Singh", false, new DateTime(2017, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hyderabad", "98765155d", null, null, 1, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2740), 15, null, 7m },
                    { 16, "Limited", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2740), "Cloud Engineer", "employee16@company.com", "Anil Singh", false, new DateTime(2013, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "98765165d", null, null, 3, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2750), 16, null, 11m },
                    { 17, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2750), "Data Analyst", "employee17@company.com", "Anand Rao", false, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "98765175d", null, null, 1, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2750), 17, null, 1m },
                    { 18, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2770), "DevOps Engineer", "employee18@company.com", "Bhavna Varma", false, new DateTime(2010, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765185d", null, null, 1, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2770), 18, null, 14m },
                    { 19, "Not Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2770), "QA Engineer", "employee19@company.com", "Brijesh Krishnan", false, new DateTime(2012, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chennai", "98765195d", null, null, 3, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2770), 19, null, 12m },
                    { 20, "Limited", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2770), "Senior Software Developer", "employee20@company.com", "Bhavik Sharma", false, new DateTime(2010, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kolkata", "98765205d", null, null, 1, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2770), 20, null, 14m },
                    { 21, "Not Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2780), "Database Administrator", "employee21@company.com", "Balaji Desai", false, new DateTime(2012, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hyderabad", "98765215d", null, null, 2, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2780), 21, null, 12m },
                    { 22, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2780), "Data Analyst", "employee22@company.com", "Bimla Khanna", false, new DateTime(2013, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765225d", null, null, 3, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2780), 22, null, 11m },
                    { 23, "Limited", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2780), "Frontend Developer", "employee23@company.com", "Bikram Desai", false, new DateTime(2010, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chennai", "98765235d", null, null, 1, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2780), 23, null, 14m },
                    { 24, "Not Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2780), "Backend Developer", "employee24@company.com", "Bhanu Krishnan", false, new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "98765245d", null, null, 1, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2780), 24, null, 2m },
                    { 25, "Not Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2790), "Principal Engineer", "employee25@company.com", "Brij Sharma", false, new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Goa", "98765255d", null, null, 1, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2790), 25, null, 1m },
                    { 26, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2790), "Full Stack Developer", "employee26@company.com", "Bimal Nair", false, new DateTime(2015, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hyderabad", "98765265d", null, null, 1, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2790), 26, null, 9m },
                    { 27, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2790), "Full Stack Developer", "employee27@company.com", "Bhat Kumar", false, new DateTime(2009, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hyderabad", "98765275d", null, null, 3, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2790), 27, null, 15m },
                    { 28, "Limited", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2790), "Principal Engineer", "employee28@company.com", "Chitra Gupta", false, new DateTime(2015, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765285d", null, null, 2, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2790), 28, null, 9m },
                    { 29, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2800), "Senior Software Developer", "employee29@company.com", "Chetan Desai", false, new DateTime(2009, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Goa", "98765295d", null, null, 3, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2800), 29, null, 15m },
                    { 30, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2800), "Cloud Engineer", "employee30@company.com", "Chirag Sharma", false, new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mumbai", "98765305d", null, null, 2, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2800), 30, null, 3m },
                    { 31, "Not Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2800), "Data Analyst", "employee31@company.com", "Charanjit Varma", false, new DateTime(2009, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chennai", "98765315d", null, null, 2, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2800), 31, null, 15m },
                    { 32, "Not Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2800), "Frontend Developer", "employee32@company.com", "Chanchal Sharma", false, new DateTime(2012, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765325d", null, null, 3, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2810), 32, null, 12m },
                    { 33, "Limited", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2810), "Senior Software Developer", "employee33@company.com", "Chandra Bhat", false, new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Delhi", "98765335d", null, null, 2, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2810), 33, null, 3m },
                    { 34, "Not Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2810), "Principal Engineer", "employee34@company.com", "Chiman Sharma", false, new DateTime(2010, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Goa", "98765345d", null, null, 2, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2810), 34, null, 14m },
                    { 35, "Not Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2810), "Senior Software Developer", "employee35@company.com", "Choudary Reddy", false, new DateTime(2015, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765355d", null, null, 3, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2810), 35, null, 9m },
                    { 36, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2810), "QA Engineer", "employee36@company.com", "Chetna Desai", false, new DateTime(2016, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765365d", null, null, 3, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2820), 36, null, 8m },
                    { 37, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2820), "Backend Developer", "employee37@company.com", "Charan Varma", false, new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chennai", "98765375d", null, null, 1, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2820), 37, null, 1m },
                    { 38, "Limited", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2820), "Consultant", "employee38@company.com", "Dhruv Singh", false, new DateTime(2016, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Delhi", "98765385d", null, null, 2, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2820), 38, null, 8m },
                    { 39, "Not Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2820), "DevOps Engineer", "employee39@company.com", "Divya Singh", false, new DateTime(2019, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765395d", null, null, 2, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2820), 39, null, 5m },
                    { 40, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2830), "Principal Engineer", "employee40@company.com", "Deepak Singh", false, new DateTime(2016, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Goa", "98765405d", null, null, 3, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2830), 40, null, 8m },
                    { 41, "Not Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2830), "Data Analyst", "employee41@company.com", "Dhanvi Nair", false, new DateTime(2015, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mumbai", "98765415d", null, null, 3, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2830), 41, null, 9m },
                    { 42, "Not Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2830), "Junior Software Developer", "employee42@company.com", "Dinesh Nair", false, new DateTime(2009, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chennai", "98765425d", null, null, 2, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2830), 42, null, 15m },
                    { 43, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2840), "Data Analyst", "employee43@company.com", "Disha Verma", false, new DateTime(2018, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765435d", null, null, 2, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2840), 43, null, 6m },
                    { 44, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2840), "DevOps Engineer", "employee44@company.com", "Devendra Bhat", false, new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chennai", "98765445d", null, null, 3, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2840), 44, null, 2m },
                    { 45, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2840), "Consultant", "employee45@company.com", "Darshan Gupta", false, new DateTime(2018, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kolkata", "98765455d", null, null, 1, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2840), 45, null, 6m },
                    { 46, "Limited", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2840), "Data Analyst", "employee46@company.com", "Devesh Bhat", false, new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Delhi", "98765465d", null, null, 2, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2840), 46, null, 3m },
                    { 47, "Limited", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2850), "Cloud Engineer", "employee47@company.com", "Dilip Krishnan", false, new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765475d", null, null, 3, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2850), 47, null, 3m },
                    { 48, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2850), "Solutions Architect", "employee48@company.com", "Esha Pillai", false, new DateTime(2013, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765485d", null, null, 3, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2850), 48, null, 11m },
                    { 49, "Limited", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2850), "Junior Software Developer", "employee49@company.com", "Eshan Gupta", false, new DateTime(2012, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pune", "98765495d", null, null, 3, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2850), 49, null, 12m },
                    { 50, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2850), "Cloud Engineer", "employee50@company.com", "Ekta Krishnan", false, new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "98765505d", null, null, 3, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2850), 50, null, 3m },
                    { 51, "Not Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2860), "Cloud Engineer", "employee51@company.com", "Emran Rao", false, new DateTime(2013, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hyderabad", "98765515d", null, null, 3, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2860), 51, null, 11m },
                    { 52, "Not Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2860), "Data Analyst", "employee52@company.com", "Eswar Varma", false, new DateTime(2016, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Goa", "98765525d", null, null, 2, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2860), 52, null, 8m },
                    { 53, "Limited", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2860), "Principal Engineer", "employee53@company.com", "Eknath Verma", false, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Goa", "98765535d", null, null, 2, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2860), 53, null, 5m },
                    { 54, "Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2860), "Data Analyst", "employee54@company.com", "Esteemed Reddy", false, new DateTime(2018, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bangalore", "98765545d", null, null, 1, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2860), 54, null, 6m },
                    { 55, "Not Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2870), "Senior Software Developer", "employee55@company.com", "Eby Kumar", false, new DateTime(2010, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mumbai", "98765555d", null, null, 2, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2870), 55, null, 14m },
                    { 56, "Not Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2880), "Database Administrator", "employee56@company.com", "Eman Nair", false, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kolkata", "98765565d", null, null, 1, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2880), 56, null, 9m },
                    { 57, "Not Available", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2880), "Cloud Engineer", "employee57@company.com", "Ezra Verma", false, new DateTime(2013, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Goa", "98765575d", null, null, 2, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(2880), 57, null, 11m }
                });

            migrationBuilder.InsertData(
                table: "EmployeeSkills",
                columns: new[] { "EmployeeSkillId", "CreatedDate", "EmployeeId", "IsVerified", "LastUsedDate", "ProficiencyLevel", "SkillId", "Source", "UpdatedDate", "YearsOfExperience" },
                values: new object[,]
                {
                    { 1000, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4670), 8, true, new DateTime(2025, 3, 16, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4570), "Advanced", 5, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4740), 2m },
                    { 1001, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4830), 8, true, new DateTime(2025, 10, 24, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4830), "Intermediate", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4830), 3m },
                    { 1002, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4830), 8, false, new DateTime(2025, 6, 8, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4830), "Expert", 3, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4830), 3m },
                    { 1003, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4830), 8, false, new DateTime(2025, 3, 1, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4830), "Expert", 12, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4830), 3m },
                    { 1004, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4830), 8, false, new DateTime(2025, 11, 27, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4830), "Expert", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4830), 3m },
                    { 1005, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4830), 8, true, new DateTime(2025, 7, 1, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4830), "Beginner", 4, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4830), 3m },
                    { 1006, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4880), 9, false, new DateTime(2025, 8, 17, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4880), "Beginner", 8, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4880), 2m },
                    { 1007, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4880), 9, true, new DateTime(2025, 9, 25, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4880), "Expert", 10, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4880), 6m },
                    { 1008, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4880), 9, true, new DateTime(2025, 6, 24, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4880), "Intermediate", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4880), 10m },
                    { 1009, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4880), 9, true, new DateTime(2025, 1, 31, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4880), "Intermediate", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4880), 1m },
                    { 1010, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4880), 9, false, new DateTime(2025, 10, 8, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4880), "Expert", 7, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4880), 9m },
                    { 1011, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4880), 9, true, new DateTime(2025, 12, 15, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4880), "Expert", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4880), 5m },
                    { 1012, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4890), 10, false, new DateTime(2025, 11, 23, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4890), "Intermediate", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4890), 1m },
                    { 1013, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4890), 10, true, new DateTime(2025, 8, 29, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4890), "Intermediate", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4890), 1m },
                    { 1014, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4890), 10, false, new DateTime(2025, 5, 20, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4890), "Advanced", 14, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4890), 1m },
                    { 1015, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4890), 10, true, new DateTime(2025, 1, 19, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4890), "Intermediate", 11, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4890), 1m },
                    { 1016, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4890), 10, false, new DateTime(2025, 8, 7, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4890), "Intermediate", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4890), 1m },
                    { 1017, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4900), 10, false, new DateTime(2025, 1, 31, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4900), "Beginner", 4, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4900), 1m },
                    { 1018, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4900), 11, true, new DateTime(2025, 11, 29, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4900), "Advanced", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4900), 3m },
                    { 1019, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4900), 11, false, new DateTime(2025, 6, 20, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4900), "Advanced", 14, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4900), 3m },
                    { 1020, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4900), 11, false, new DateTime(2025, 5, 19, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4900), "Expert", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4900), 5m },
                    { 1021, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4910), 11, true, new DateTime(2025, 9, 7, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4910), "Intermediate", 15, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4910), 3m },
                    { 1022, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4910), 12, false, new DateTime(2025, 4, 14, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4910), "Beginner", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4910), 1m },
                    { 1023, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4910), 12, false, new DateTime(2025, 7, 27, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4910), "Expert", 5, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4910), 1m },
                    { 1024, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4910), 12, false, new DateTime(2025, 11, 8, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4910), "Expert", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4910), 1m },
                    { 1025, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4920), 12, true, new DateTime(2025, 2, 24, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4920), "Advanced", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4920), 1m },
                    { 1026, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4920), 12, true, new DateTime(2025, 2, 22, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4920), "Advanced", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4920), 1m },
                    { 1027, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4920), 13, false, new DateTime(2025, 10, 5, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4920), "Beginner", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4920), 3m },
                    { 1028, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4920), 13, true, new DateTime(2025, 7, 31, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4920), "Advanced", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4920), 2m },
                    { 1029, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4920), 13, true, new DateTime(2025, 2, 15, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4920), "Advanced", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4920), 1m },
                    { 1030, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4930), 14, true, new DateTime(2025, 11, 25, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4930), "Intermediate", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4930), 10m },
                    { 1031, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4930), 14, false, new DateTime(2025, 3, 18, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4930), "Expert", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4930), 10m },
                    { 1032, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4930), 14, true, new DateTime(2025, 10, 31, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4930), "Advanced", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4930), 3m },
                    { 1033, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4930), 14, false, new DateTime(2025, 2, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4930), "Beginner", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4930), 1m },
                    { 1034, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4930), 14, true, new DateTime(2025, 2, 16, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4930), "Beginner", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4930), 7m },
                    { 1035, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4930), 15, false, new DateTime(2025, 8, 5, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4930), "Intermediate", 10, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4930), 7m },
                    { 1036, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), 15, false, new DateTime(2025, 4, 24, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), "Beginner", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), 4m },
                    { 1037, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), 15, false, new DateTime(2025, 10, 14, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), "Beginner", 6, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), 7m },
                    { 1038, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), 16, true, new DateTime(2025, 10, 1, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), "Expert", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), 5m },
                    { 1039, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), 16, true, new DateTime(2025, 12, 11, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), "Advanced", 8, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), 7m },
                    { 1040, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), 16, false, new DateTime(2025, 8, 6, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), "Beginner", 10, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), 1m },
                    { 1041, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), 16, true, new DateTime(2025, 4, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), "Intermediate", 7, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), 7m },
                    { 1042, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), 16, true, new DateTime(2026, 1, 1, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), "Beginner", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4940), 5m },
                    { 1043, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4950), 17, true, new DateTime(2025, 1, 19, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4950), "Beginner", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4950), 1m },
                    { 1044, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4950), 17, false, new DateTime(2025, 7, 21, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4950), "Intermediate", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4950), 1m },
                    { 1045, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4950), 17, false, new DateTime(2025, 7, 1, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4950), "Advanced", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4950), 1m },
                    { 1046, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4950), 17, true, new DateTime(2025, 10, 24, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4950), "Advanced", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4950), 1m },
                    { 1047, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4950), 17, true, new DateTime(2025, 5, 18, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4950), "Advanced", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4950), 1m },
                    { 1048, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), 18, true, new DateTime(2025, 4, 2, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), "Advanced", 7, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), 1m },
                    { 1049, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), 18, false, new DateTime(2025, 8, 1, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), "Advanced", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), 4m },
                    { 1050, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), 18, true, new DateTime(2025, 3, 18, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), "Beginner", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), 1m },
                    { 1051, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), 18, true, new DateTime(2025, 5, 7, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), "Expert", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), 10m },
                    { 1052, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), 18, false, new DateTime(2025, 8, 2, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), "Beginner", 6, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), 9m },
                    { 1053, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), 18, true, new DateTime(2025, 2, 3, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), "Expert", 9, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), 1m },
                    { 1054, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), 19, false, new DateTime(2025, 12, 21, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), "Advanced", 4, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), 8m },
                    { 1055, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), 19, true, new DateTime(2025, 10, 5, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), "Beginner", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4960), 5m },
                    { 1056, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4970), 19, true, new DateTime(2025, 9, 13, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4970), "Intermediate", 5, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4970), 2m },
                    { 1057, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4970), 19, true, new DateTime(2025, 4, 10, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4970), "Beginner", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4970), 1m },
                    { 1058, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4970), 19, true, new DateTime(2025, 4, 20, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4970), "Expert", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4970), 8m },
                    { 1059, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4970), 20, false, new DateTime(2025, 2, 20, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4970), "Intermediate", 5, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4970), 4m },
                    { 1060, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4990), 20, true, new DateTime(2025, 6, 11, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4990), "Expert", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4990), 6m },
                    { 1061, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4990), 20, true, new DateTime(2025, 3, 30, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4990), "Beginner", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4990), 2m },
                    { 1062, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4990), 20, false, new DateTime(2025, 1, 29, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4990), "Advanced", 12, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4990), 8m },
                    { 1063, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4990), 20, false, new DateTime(2025, 11, 24, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4990), "Expert", 16, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4990), 3m },
                    { 1064, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4990), 20, false, new DateTime(2025, 12, 22, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4990), "Expert", 15, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(4990), 4m },
                    { 1065, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5000), 21, true, new DateTime(2025, 4, 23, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5000), "Advanced", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5000), 8m },
                    { 1066, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5000), 21, false, new DateTime(2025, 8, 2, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5000), "Advanced", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5000), 2m },
                    { 1067, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5000), 21, true, new DateTime(2025, 4, 6, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5000), "Intermediate", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5000), 9m },
                    { 1068, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5000), 21, false, new DateTime(2025, 4, 30, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5000), "Expert", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5000), 3m },
                    { 1069, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5000), 21, false, new DateTime(2025, 3, 8, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5000), "Advanced", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5000), 6m },
                    { 1070, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5000), 22, true, new DateTime(2025, 9, 25, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5000), "Intermediate", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5000), 7m },
                    { 1071, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5010), 22, true, new DateTime(2025, 9, 20, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5010), "Intermediate", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5010), 2m },
                    { 1072, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5010), 22, false, new DateTime(2025, 11, 8, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5010), "Intermediate", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5010), 5m },
                    { 1073, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5010), 23, true, new DateTime(2025, 8, 25, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5010), "Intermediate", 12, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5010), 4m },
                    { 1074, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5010), 23, false, new DateTime(2025, 8, 28, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5010), "Beginner", 5, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5010), 1m },
                    { 1075, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5010), 23, false, new DateTime(2025, 3, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5010), "Advanced", 13, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5010), 1m },
                    { 1076, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5020), 24, false, new DateTime(2025, 7, 20, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5020), "Beginner", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5020), 2m },
                    { 1077, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5020), 24, true, new DateTime(2025, 6, 25, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5020), "Intermediate", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5020), 2m },
                    { 1078, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5020), 24, false, new DateTime(2025, 1, 13, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5020), "Expert", 14, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5020), 2m },
                    { 1079, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5020), 24, true, new DateTime(2025, 4, 29, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5020), "Expert", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5020), 2m },
                    { 1080, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5020), 24, false, new DateTime(2025, 3, 30, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5020), "Advanced", 3, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5020), 2m },
                    { 1081, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5020), 24, true, new DateTime(2025, 8, 5, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5020), "Beginner", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5020), 2m },
                    { 1082, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), 25, false, new DateTime(2025, 3, 25, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), "Advanced", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), 1m },
                    { 1083, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), 25, true, new DateTime(2025, 7, 15, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), "Beginner", 15, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), 1m },
                    { 1084, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), 25, true, new DateTime(2025, 11, 12, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), "Advanced", 3, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), 1m },
                    { 1085, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), 25, true, new DateTime(2025, 12, 21, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), "Intermediate", 11, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), 1m },
                    { 1086, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), 26, false, new DateTime(2025, 7, 13, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), "Expert", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), 7m },
                    { 1087, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), 26, true, new DateTime(2025, 2, 9, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), "Beginner", 4, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), 3m },
                    { 1088, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), 26, true, new DateTime(2025, 9, 18, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5030), "Intermediate", 11, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), 3m },
                    { 1089, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), 26, true, new DateTime(2025, 9, 26, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), "Advanced", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), 1m },
                    { 1090, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), 27, false, new DateTime(2025, 8, 25, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), "Beginner", 4, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), 9m },
                    { 1091, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), 27, true, new DateTime(2025, 8, 17, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), "Beginner", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), 9m },
                    { 1092, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), 27, true, new DateTime(2025, 7, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), "Advanced", 5, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), 1m },
                    { 1093, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), 27, false, new DateTime(2025, 9, 19, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), "Intermediate", 14, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), 9m },
                    { 1094, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), 27, true, new DateTime(2025, 8, 22, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), "Expert", 11, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5040), 2m },
                    { 1095, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5050), 28, true, new DateTime(2025, 3, 31, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5050), "Expert", 3, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5050), 2m },
                    { 1096, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5050), 28, true, new DateTime(2025, 2, 11, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5050), "Advanced", 12, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5050), 4m },
                    { 1097, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5050), 28, true, new DateTime(2025, 8, 18, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5050), "Advanced", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5050), 8m },
                    { 1098, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5050), 28, false, new DateTime(2025, 11, 21, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5050), "Beginner", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5050), 3m },
                    { 1099, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), 29, true, new DateTime(2025, 3, 12, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), "Advanced", 15, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), 1m },
                    { 1100, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), 29, true, new DateTime(2025, 4, 10, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), "Expert", 14, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), 9m },
                    { 1101, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), 29, false, new DateTime(2025, 8, 13, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), "Expert", 4, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), 5m },
                    { 1102, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), 30, true, new DateTime(2025, 7, 31, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), "Expert", 9, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), 3m },
                    { 1103, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), 30, true, new DateTime(2025, 12, 6, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), "Beginner", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), 3m },
                    { 1104, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), 30, false, new DateTime(2025, 10, 19, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), "Expert", 6, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), 1m },
                    { 1105, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), 30, true, new DateTime(2025, 10, 15, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), "Beginner", 10, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5060), 3m },
                    { 1106, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5070), 31, true, new DateTime(2025, 6, 3, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5070), "Intermediate", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5070), 5m },
                    { 1107, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5070), 31, true, new DateTime(2025, 2, 19, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5070), "Advanced", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5070), 3m },
                    { 1108, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5070), 31, false, new DateTime(2025, 6, 18, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5070), "Intermediate", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5070), 8m },
                    { 1109, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5070), 31, false, new DateTime(2025, 2, 7, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5070), "Expert", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5070), 7m },
                    { 1110, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5070), 31, true, new DateTime(2025, 11, 28, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5070), "Expert", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5070), 2m },
                    { 1111, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), 32, true, new DateTime(2025, 4, 7, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), "Beginner", 5, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), 5m },
                    { 1112, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), 32, false, new DateTime(2025, 9, 3, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), "Expert", 4, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), 2m },
                    { 1113, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), 32, false, new DateTime(2025, 3, 19, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), "Beginner", 13, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), 8m },
                    { 1114, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), 32, true, new DateTime(2025, 3, 20, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), "Advanced", 11, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), 9m },
                    { 1115, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), 32, true, new DateTime(2025, 2, 25, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), "Beginner", 12, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), 3m },
                    { 1116, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), 33, false, new DateTime(2025, 11, 18, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), "Intermediate", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), 3m },
                    { 1117, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), 33, true, new DateTime(2025, 10, 19, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), "Intermediate", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5080), 3m },
                    { 1118, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), 33, true, new DateTime(2025, 11, 25, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), "Advanced", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), 3m },
                    { 1119, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), 33, false, new DateTime(2025, 9, 15, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), "Beginner", 15, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), 3m },
                    { 1120, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), 33, true, new DateTime(2025, 12, 10, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), "Advanced", 16, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), 3m },
                    { 1121, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), 34, true, new DateTime(2025, 2, 21, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), "Advanced", 12, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), 9m },
                    { 1122, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), 34, false, new DateTime(2025, 6, 16, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), "Expert", 4, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), 4m },
                    { 1123, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), 34, false, new DateTime(2025, 2, 16, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), "Advanced", 5, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), 1m },
                    { 1124, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), 34, true, new DateTime(2025, 1, 8, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), "Intermediate", 15, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5090), 5m },
                    { 1125, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5100), 35, false, new DateTime(2025, 7, 24, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5100), "Beginner", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5100), 1m },
                    { 1126, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5100), 35, true, new DateTime(2025, 10, 9, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5100), "Beginner", 4, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5100), 1m },
                    { 1127, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5100), 35, false, new DateTime(2025, 4, 5, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5100), "Beginner", 11, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5100), 9m },
                    { 1128, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5100), 36, false, new DateTime(2025, 10, 21, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5100), "Beginner", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5100), 4m },
                    { 1129, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5110), 36, false, new DateTime(2025, 11, 16, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5110), "Advanced", 4, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5110), 8m },
                    { 1130, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5110), 36, false, new DateTime(2025, 10, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5110), "Expert", 5, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5110), 4m },
                    { 1131, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5120), 37, true, new DateTime(2025, 8, 23, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5120), "Beginner", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5120), 1m },
                    { 1132, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5120), 37, true, new DateTime(2025, 8, 1, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5120), "Expert", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5120), 1m },
                    { 1133, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5120), 37, true, new DateTime(2025, 11, 23, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5120), "Beginner", 15, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5120), 1m },
                    { 1134, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5120), 37, false, new DateTime(2025, 7, 16, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5120), "Beginner", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5120), 1m },
                    { 1135, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), 38, false, new DateTime(2025, 2, 22, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), "Advanced", 3, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), 8m },
                    { 1136, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), 38, false, new DateTime(2025, 1, 15, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), "Advanced", 15, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), 3m },
                    { 1137, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), 38, false, new DateTime(2025, 10, 2, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), "Expert", 5, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), 5m },
                    { 1138, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), 38, true, new DateTime(2025, 1, 15, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), "Expert", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), 8m },
                    { 1139, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), 38, true, new DateTime(2025, 9, 5, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), "Beginner", 14, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), 8m },
                    { 1140, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), 38, false, new DateTime(2025, 10, 12, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), "Advanced", 11, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), 2m },
                    { 1141, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), 39, false, new DateTime(2025, 7, 21, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), "Advanced", 10, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), 5m },
                    { 1142, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), 39, false, new DateTime(2025, 8, 19, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5130), "Advanced", 9, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), 2m },
                    { 1143, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), 39, false, new DateTime(2025, 8, 30, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), "Beginner", 8, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), 3m },
                    { 1144, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), 39, true, new DateTime(2025, 8, 17, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), "Beginner", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), 1m },
                    { 1145, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), 39, false, new DateTime(2025, 5, 17, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), "Expert", 6, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), 5m },
                    { 1146, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), 39, true, new DateTime(2025, 10, 11, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), "Expert", 7, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), 5m },
                    { 1147, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), 40, false, new DateTime(2025, 8, 12, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), "Advanced", 15, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), 3m },
                    { 1148, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), 40, false, new DateTime(2025, 12, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), "Expert", 11, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), 3m },
                    { 1149, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), 40, true, new DateTime(2025, 10, 26, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), "Beginner", 3, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5140), 4m },
                    { 1150, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5150), 41, false, new DateTime(2025, 11, 19, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5150), "Beginner", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5150), 6m },
                    { 1151, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5150), 41, false, new DateTime(2025, 11, 13, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5150), "Expert", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5150), 4m },
                    { 1152, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5150), 41, true, new DateTime(2025, 7, 10, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5150), "Expert", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5150), 4m },
                    { 1153, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5150), 42, false, new DateTime(2025, 12, 31, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5150), "Advanced", 11, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5150), 9m },
                    { 1154, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), 42, true, new DateTime(2025, 11, 7, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), "Intermediate", 16, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), 1m },
                    { 1155, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), 42, true, new DateTime(2025, 1, 26, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), "Expert", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), 6m },
                    { 1156, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), 42, false, new DateTime(2025, 10, 2, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), "Advanced", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), 10m },
                    { 1157, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), 42, true, new DateTime(2025, 5, 31, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), "Expert", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), 10m },
                    { 1158, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), 43, true, new DateTime(2025, 6, 5, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), "Expert", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), 4m },
                    { 1159, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), 43, false, new DateTime(2025, 6, 9, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), "Expert", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), 2m },
                    { 1160, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), 43, false, new DateTime(2025, 11, 28, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), "Beginner", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), 2m },
                    { 1161, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), 43, false, new DateTime(2025, 4, 16, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), "Expert", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5160), 4m },
                    { 1162, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5170), 43, false, new DateTime(2025, 5, 25, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5170), "Advanced", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5170), 5m },
                    { 1163, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5170), 44, true, new DateTime(2025, 3, 16, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5170), "Intermediate", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5170), 2m },
                    { 1164, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5170), 44, true, new DateTime(2025, 9, 29, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5170), "Beginner", 7, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5170), 2m },
                    { 1165, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5170), 44, false, new DateTime(2025, 1, 14, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5170), "Advanced", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5170), 2m },
                    { 1166, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5170), 44, true, new DateTime(2025, 5, 15, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5170), "Intermediate", 8, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5170), 2m },
                    { 1167, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5180), 45, false, new DateTime(2025, 1, 11, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5180), "Intermediate", 3, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5180), 2m },
                    { 1168, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5180), 45, true, new DateTime(2025, 5, 20, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5180), "Expert", 4, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5180), 3m },
                    { 1169, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5180), 45, true, new DateTime(2025, 10, 8, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5180), "Advanced", 11, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5180), 6m },
                    { 1170, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5180), 45, false, new DateTime(2025, 9, 22, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5180), "Expert", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5180), 6m },
                    { 1171, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5180), 45, true, new DateTime(2025, 11, 30, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5180), "Expert", 14, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5180), 1m },
                    { 1172, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), 46, false, new DateTime(2025, 8, 22, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), "Advanced", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), 1m },
                    { 1173, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), 46, false, new DateTime(2025, 9, 10, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), "Beginner", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), 3m },
                    { 1174, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), 46, true, new DateTime(2025, 10, 8, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), "Beginner", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), 3m },
                    { 1175, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), 46, true, new DateTime(2025, 2, 22, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), "Advanced", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), 3m },
                    { 1176, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), 47, true, new DateTime(2025, 9, 25, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), "Beginner", 7, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), 3m },
                    { 1177, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), 47, false, new DateTime(2025, 7, 7, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), "Beginner", 10, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), 3m },
                    { 1178, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), 47, false, new DateTime(2025, 9, 23, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), "Advanced", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5190), 3m },
                    { 1179, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5200), 47, false, new DateTime(2025, 6, 23, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5200), "Intermediate", 9, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5200), 3m },
                    { 1180, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5200), 48, true, new DateTime(2025, 10, 14, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5200), "Beginner", 12, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5200), 3m },
                    { 1181, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5200), 48, false, new DateTime(2025, 9, 27, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5200), "Expert", 5, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5200), 1m },
                    { 1182, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5200), 48, false, new DateTime(2025, 11, 23, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5200), "Advanced", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5200), 7m },
                    { 1183, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5200), 48, false, new DateTime(2025, 2, 26, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5200), "Expert", 4, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5200), 1m },
                    { 1184, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), 49, true, new DateTime(2025, 12, 6, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), "Intermediate", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), 6m },
                    { 1185, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), 49, false, new DateTime(2025, 9, 26, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), "Beginner", 15, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), 2m },
                    { 1186, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), 49, false, new DateTime(2025, 12, 30, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), "Advanced", 13, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), 4m },
                    { 1187, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), 50, false, new DateTime(2026, 1, 3, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), "Beginner", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), 2m },
                    { 1188, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), 50, true, new DateTime(2025, 11, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), "Expert", 7, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), 3m },
                    { 1189, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), 50, false, new DateTime(2025, 8, 5, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), "Intermediate", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), 1m },
                    { 1190, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), 50, false, new DateTime(2025, 2, 28, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), "Advanced", 9, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5210), 3m },
                    { 1191, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5220), 50, true, new DateTime(2025, 10, 16, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5220), "Expert", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5220), 3m },
                    { 1192, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5220), 50, true, new DateTime(2025, 12, 21, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5220), "Expert", 8, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5220), 3m },
                    { 1193, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5220), 51, true, new DateTime(2025, 7, 31, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5220), "Advanced", 7, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5220), 7m },
                    { 1194, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5220), 51, false, new DateTime(2025, 10, 11, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5220), "Advanced", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5220), 3m },
                    { 1195, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5220), 51, false, new DateTime(2025, 12, 26, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5220), "Beginner", 6, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5220), 2m },
                    { 1196, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), 52, false, new DateTime(2025, 10, 19, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), "Expert", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), 3m },
                    { 1197, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), 52, false, new DateTime(2025, 6, 5, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), "Intermediate", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), 8m },
                    { 1198, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), 52, false, new DateTime(2025, 6, 11, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), "Expert", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), 1m },
                    { 1199, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), 53, true, new DateTime(2025, 6, 19, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), "Expert", 15, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), 5m },
                    { 1200, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), 53, true, new DateTime(2025, 6, 22, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), "Intermediate", 14, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), 1m },
                    { 1201, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), 53, false, new DateTime(2025, 12, 21, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), "Intermediate", 3, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), 5m },
                    { 1202, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), 53, true, new DateTime(2025, 3, 22, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), "Intermediate", 11, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5230), 3m },
                    { 1203, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5240), 54, true, new DateTime(2025, 5, 7, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5240), "Expert", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5240), 2m },
                    { 1204, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5240), 54, false, new DateTime(2025, 1, 9, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5240), "Advanced", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5240), 6m },
                    { 1205, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5240), 54, false, new DateTime(2025, 7, 10, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5240), "Expert", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5240), 2m },
                    { 1206, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5240), 54, false, new DateTime(2025, 2, 15, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5240), "Advanced", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5240), 6m },
                    { 1207, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5250), 55, false, new DateTime(2025, 2, 12, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5250), "Expert", 14, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5250), 10m },
                    { 1208, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5250), 55, true, new DateTime(2025, 2, 16, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5250), "Beginner", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5250), 5m },
                    { 1209, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5360), 55, true, new DateTime(2025, 6, 17, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5360), "Expert", 5, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5360), 4m },
                    { 1210, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5360), 55, false, new DateTime(2025, 6, 18, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5360), "Advanced", 13, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5360), 8m },
                    { 1211, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5360), 55, true, new DateTime(2025, 2, 9, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5360), "Expert", 11, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5360), 7m },
                    { 1212, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5370), 56, true, new DateTime(2025, 11, 16, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5370), "Advanced", 17, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5370), 9m },
                    { 1213, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5370), 56, true, new DateTime(2025, 4, 9, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5370), "Advanced", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5370), 7m },
                    { 1214, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5370), 56, false, new DateTime(2025, 10, 5, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5370), "Expert", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5370), 5m },
                    { 1215, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5370), 56, false, new DateTime(2025, 9, 23, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5370), "Beginner", 2, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5370), 7m },
                    { 1216, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5370), 56, false, new DateTime(2025, 2, 27, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5370), "Intermediate", 1, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5370), 8m },
                    { 1217, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5370), 57, true, new DateTime(2025, 5, 22, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5370), "Beginner", 8, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5370), 4m },
                    { 1218, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5380), 57, true, new DateTime(2025, 6, 26, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5380), "Beginner", 19, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5380), 2m },
                    { 1219, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5380), 57, true, new DateTime(2025, 9, 23, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5380), "Advanced", 18, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5380), 8m },
                    { 1220, new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5380), 57, false, new DateTime(2025, 6, 14, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5380), "Expert", 7, "Manual", new DateTime(2026, 1, 4, 14, 6, 8, 62, DateTimeKind.Utc).AddTicks(5380), 10m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "EmployeeSkillId",
                keyValue: 1220);

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
