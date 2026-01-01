using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TalentMarketPlace.Migrations
{
    /// <inheritdoc />
    public partial class AddSQLSkillAlias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "SkillAliases",
                columns: new[] { "AliasId", "AliasName", "CreatedDate", "SkillId" },
                values: new object[] { 10, "SQL", new DateTime(2026, 1, 1, 12, 51, 10, 113, DateTimeKind.Utc).AddTicks(3020), 17 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 31, 17, 15, 56, 776, DateTimeKind.Utc).AddTicks(3088), new DateTime(2025, 12, 31, 17, 15, 56, 776, DateTimeKind.Utc).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(12), new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(22), new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(27), new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(31), new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(35), new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(38), new DateTime(2025, 12, 31, 17, 15, 56, 777, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 774, DateTimeKind.Utc).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 31, 17, 15, 56, 775, DateTimeKind.Utc).AddTicks(6115));
        }
    }
}
