using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TalentMarketPlace.Migrations
{
    /// <inheritdoc />
    public partial class RenamePhoneToPhoneNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Employees",
                newName: "PhoneNumber");

            migrationBuilder.AlterColumn<decimal>(
                name: "YearsOfExperience",
                table: "Employees",
                type: "decimal(4,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate", "YearsOfExperience" },
                values: new object[] { new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1671), new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1671), 5m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate", "YearsOfExperience" },
                values: new object[] { new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1690), new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1691), 4m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FullName", "UpdatedDate", "YearsOfExperience" },
                values: new object[] { new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1696), "Rajesh Veerasamy", new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1697), 3m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate", "YearsOfExperience" },
                values: new object[] { new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1702), new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1702), 2m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "FullName", "UpdatedDate", "YearsOfExperience" },
                values: new object[] { new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1707), "Vikram Raja", new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1707), 8m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate", "YearsOfExperience" },
                values: new object[] { new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1712), new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1712), 10m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate", "YearsOfExperience" },
                values: new object[] { new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1717), new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1717), 12m });

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 4, 15, 36, 19, 646, DateTimeKind.Utc).AddTicks(1555));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Employees",
                newName: "Phone");

            migrationBuilder.AlterColumn<int>(
                name: "YearsOfExperience",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate", "YearsOfExperience" },
                values: new object[] { new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5672), new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5672), 5 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate", "YearsOfExperience" },
                values: new object[] { new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5683), new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5683), 4 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FullName", "UpdatedDate", "YearsOfExperience" },
                values: new object[] { new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5687), "Rajesh Nair", new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5688), 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate", "YearsOfExperience" },
                values: new object[] { new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5690), new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5690), 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "FullName", "UpdatedDate", "YearsOfExperience" },
                values: new object[] { new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5692), "Vikram Reddy", new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5692), 8 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate", "YearsOfExperience" },
                values: new object[] { new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5694), new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5694), 10 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate", "YearsOfExperience" },
                values: new object[] { new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5696), new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5696), 12 });

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "SkillAliases",
                keyColumn: "AliasId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 11, 19, 16, 22, 45, 875, DateTimeKind.Utc).AddTicks(5628));
        }
    }
}
