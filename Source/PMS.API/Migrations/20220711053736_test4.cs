using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_achievements_AchievementType_AchievementTypeId",
                table: "achievements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AchievementType",
                table: "AchievementType");

            migrationBuilder.RenameTable(
                name: "AchievementType",
                newName: "achievementtype");

            migrationBuilder.AddPrimaryKey(
                name: "PK_achievementtype",
                table: "achievementtype",
                column: "AchievementTypeId");

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 11, 7, 35, 818, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 11, 7, 35, 818, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 11, 7, 35, 818, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 11, 7, 35, 818, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 11, 7, 35, 818, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 11, 7, 35, 818, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 11, 7, 35, 818, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 11, 7, 35, 818, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 11, 7, 35, 818, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 11, 7, 35, 818, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.AddForeignKey(
                name: "FK_achievements_achievementtype_AchievementTypeId",
                table: "achievements",
                column: "AchievementTypeId",
                principalTable: "achievementtype",
                principalColumn: "AchievementTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_achievements_achievementtype_AchievementTypeId",
                table: "achievements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_achievementtype",
                table: "achievementtype");

            migrationBuilder.RenameTable(
                name: "achievementtype",
                newName: "AchievementType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AchievementType",
                table: "AchievementType",
                column: "AchievementTypeId");

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 10, 59, 21, 469, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 10, 59, 21, 469, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 10, 59, 21, 469, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 10, 59, 21, 469, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 10, 59, 21, 469, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 10, 59, 21, 469, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 10, 59, 21, 469, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 10, 59, 21, 469, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 10, 59, 21, 469, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 11, 10, 59, 21, 469, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.AddForeignKey(
                name: "FK_achievements_AchievementType_AchievementTypeId",
                table: "achievements",
                column: "AchievementTypeId",
                principalTable: "AchievementType",
                principalColumn: "AchievementTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
