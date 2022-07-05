using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class personaldetailsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 6, 8, 161, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 6, 8, 161, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 6, 8, 161, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 6, 8, 161, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 6, 8, 161, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 6, 8, 161, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 6, 8, 161, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 6, 8, 161, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 6, 8, 161, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 6, 8, 161, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.InsertData(
                table: "personalDetails",
                columns: new[] { "PersonalDetailsId", "CreatedBy", "CreatedOn", "DateOfBirth", "DateOfJoining", "Image", "IsActive", "Nationality", "Objective", "ProfileId", "UpdatedBy", "UpdatedOn", "UserId", "base64header" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2000, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Indian", "My description", 1, null, null, 1, "abc" },
                    { 2, null, null, new DateTime(2000, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Indian", "My description", 2, null, null, 2, "qwe" },
                    { 3, null, null, new DateTime(2000, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Indian", "My description", 3, null, null, 3, "abc" },
                    { 4, null, null, new DateTime(2000, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Indian", "My description", 4, null, null, 4, "abc" },
                    { 5, null, null, new DateTime(2000, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Indian", "My description", 5, null, null, 5, "abc" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "personalDetails",
                keyColumn: "PersonalDetailsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "personalDetails",
                keyColumn: "PersonalDetailsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "personalDetails",
                keyColumn: "PersonalDetailsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "personalDetails",
                keyColumn: "PersonalDetailsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "personalDetails",
                keyColumn: "PersonalDetailsId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 5, 21, 514, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 5, 21, 514, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 5, 21, 514, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 5, 21, 514, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 5, 21, 514, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 5, 21, 514, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 5, 21, 514, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 5, 21, 514, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 5, 21, 514, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 5, 21, 514, DateTimeKind.Local).AddTicks(2429));
        }
    }
}
