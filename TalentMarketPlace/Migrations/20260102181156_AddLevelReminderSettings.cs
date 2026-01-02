using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TalentMarketPlace.Migrations
{
    /// <inheritdoc />
    public partial class AddLevelReminderSettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LevelReminderSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeLevel = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DefaultEmailCount = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LevelReminderSettings", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LevelReminderSettings_EmployeeLevel",
                table: "LevelReminderSettings",
                column: "EmployeeLevel",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LevelReminderSettings");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(4220), new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(5200), new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(5210), new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(5210), new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(5210), new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(5210), new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(5210), new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(3540));
        }
    }
}
