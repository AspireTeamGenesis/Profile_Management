using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "breakDurations",
                columns: new[] { "BreakDuration_Id", "CreatedBy", "CreatedOn", "EndingDuration", "IsActive", "PersonalDetailsId", "StartingDuration", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2019, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 2, null, null, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, new DateTime(2020, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 3, null, null, new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3, new DateTime(2020, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 4, null, null, new DateTime(2019, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4, new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 5, null, null, new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 5, new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 6, null, null, new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 5, new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null }
                });

            migrationBuilder.InsertData(
                table: "languages",
                columns: new[] { "LanguageId", "CreatedBy", "CreatedOn", "IsActive", "LanguageName", "PersonalDetailsId", "Read", "Speak", "UpdatedBy", "UpdatedOn", "Write" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4052), true, "English", 1, true, true, null, null, true },
                    { 2, null, new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4065), true, "Tamil", 2, true, true, null, null, true },
                    { 3, null, new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4066), true, "Hindi", 3, true, true, null, null, true },
                    { 4, null, new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4067), true, "Telugu", 4, true, true, null, null, true },
                    { 5, null, new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4068), true, "Malayalam", 5, true, true, null, null, true },
                    { 6, null, new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4092), true, "Kannada", 3, true, true, null, null, true },
                    { 7, null, new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4093), true, "Bengali", 4, true, true, null, null, true },
                    { 8, null, new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4094), true, "Marathi", 3, true, true, null, null, true },
                    { 9, null, new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4095), true, "Urdu", 1, true, true, null, null, true },
                    { 10, null, new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4096), true, "French", 2, true, true, null, null, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "breakDurations",
                keyColumn: "BreakDuration_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "breakDurations",
                keyColumn: "BreakDuration_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "breakDurations",
                keyColumn: "BreakDuration_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "breakDurations",
                keyColumn: "BreakDuration_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "breakDurations",
                keyColumn: "BreakDuration_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "breakDurations",
                keyColumn: "BreakDuration_Id",
                keyValue: 6);

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
        }
    }
}
