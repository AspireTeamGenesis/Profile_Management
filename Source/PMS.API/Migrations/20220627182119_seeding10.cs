using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class seeding10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AchievementType",
                columns: new[] { "AchievementTypeId", "AchievementTypeName", "IsActive" },
                values: new object[,]
                {
                    { 1, "Best Coder", true },
                    { 2, "Best Worker", true },
                    { 3, "Smart Learner", true },
                    { 4, "Best Leader", true },
                    { 5, "Lone Warrior", true }
                });

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 51, 18, 622, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 51, 18, 622, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 51, 18, 622, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 51, 18, 622, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 51, 18, 622, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 51, 18, 622, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 51, 18, 622, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 51, 18, 622, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 51, 18, 622, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 51, 18, 622, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.InsertData(
                table: "achievements",
                columns: new[] { "AchievementId", "AchievementImage", "AchievementTypeId", "CreatedBy", "CreatedOn", "IsActive", "ProfileId", "UpdatedBy", "UpdatedOn", "base64header" },
                values: new object[,]
                {
                    { 1, null, 1, null, null, true, 1, null, null, "abc" },
                    { 2, null, 2, null, null, true, 2, null, null, "abc" },
                    { 3, null, 3, null, null, true, 3, null, null, "abc" },
                    { 4, null, 4, null, null, true, 4, null, null, "abc" },
                    { 5, null, 5, null, null, true, 5, null, null, "abc" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "achievements",
                keyColumn: "AchievementId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "achievements",
                keyColumn: "AchievementId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "achievements",
                keyColumn: "AchievementId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "achievements",
                keyColumn: "AchievementId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "achievements",
                keyColumn: "AchievementId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AchievementType",
                keyColumn: "AchievementTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AchievementType",
                keyColumn: "AchievementTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AchievementType",
                keyColumn: "AchievementTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AchievementType",
                keyColumn: "AchievementTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AchievementType",
                keyColumn: "AchievementTypeId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(8016));
        }
    }
}
