using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TalentMarketPlace.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ManagerFeedback",
                table: "Applications",
                type: "TEXT",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "CoverLetter",
                table: "Applications",
                type: "TEXT",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "AIRecommendation",
                table: "Applications",
                type: "TEXT",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 1000);

            migrationBuilder.AddColumn<DateTime>(
                name: "ApplicationDate",
                table: "Applications",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5700), new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5710), new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5720), new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5720), new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5720), new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5720), new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5720), new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 18, 10, 59, 40, 970, DateTimeKind.Utc).AddTicks(5680));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationDate",
                table: "Applications");

            migrationBuilder.AlterColumn<string>(
                name: "ManagerFeedback",
                table: "Applications",
                type: "TEXT",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoverLetter",
                table: "Applications",
                type: "TEXT",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AIRecommendation",
                table: "Applications",
                type: "TEXT",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9640), new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9650), new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9650), new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9650), new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9650), new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9660), new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9660), new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 12, 18, 31, 34, 908, DateTimeKind.Utc).AddTicks(9610));
        }
    }
}
