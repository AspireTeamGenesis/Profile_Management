using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class seeding2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "profile",
                columns: new[] { "ProfileId", "IsActive", "ProfileStatusId" },
                values: new object[,]
                {
                    { 1, true, 1 },
                    { 2, true, 3 },
                    { 3, true, 1 },
                    { 4, true, 2 },
                    { 5, true, 2 },
                    { 6, true, 1 },
                    { 7, true, 3 },
                    { 8, true, 2 },
                    { 9, true, 3 },
                    { 10, true, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "languages",
                columns: new[] { "LanguageId", "CreatedBy", "CreatedOn", "IsActive", "LanguageName", "PersonalDetailsId", "Read", "Speak", "UpdatedBy", "UpdatedOn", "Write" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(446), true, "English", 1, true, true, 1, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(459), true },
                    { 2, 2, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(461), true, "Tamil", 2, true, true, 1, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(461), true },
                    { 3, 3, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(462), true, "Hindi", 3, true, true, 1, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(463), true },
                    { 4, 1, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(466), true, "Telugu", 4, true, true, 1, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(467), true },
                    { 5, 2, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(468), true, "Malayalam", 5, true, true, 1, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(468), true },
                    { 6, 3, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(469), true, "Kannada", 6, true, true, 1, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(470), true },
                    { 7, 1, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(471), true, "Bengali", 7, true, true, 1, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(471), true },
                    { 8, 2, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(472), true, "Marathi", 8, true, true, 1, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(473), true },
                    { 9, 3, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(474), true, "Urdu", 9, true, true, 1, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(474), true },
                    { 10, 9, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(475), true, "French", 10, true, true, 1, new DateTime(2022, 6, 27, 14, 36, 3, 861, DateTimeKind.Local).AddTicks(476), true }
                });
        }
    }
}
