using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class personaldetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 0, 13, 178, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 0, 13, 178, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 0, 13, 178, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 0, 13, 178, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 0, 13, 178, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 0, 13, 178, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 0, 13, 178, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 0, 13, 178, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 0, 13, 178, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 15, 0, 13, 178, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.InsertData(
                table: "personalDetails",
                columns: new[] { "PersonalDetailsId", "CreatedBy", "CreatedOn", "DateOfBirth", "DateOfJoining", "Image", "IsActive", "Nationality", "Objective", "ProfileId", "UpdatedBy", "UpdatedOn", "UserId", "base64header" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(11), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(24), null, true, "Indian", "My description", 1, null, null, 1, "abc" },
                    { 2, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(86), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(24), null, true, "Indian", "My description", 2, null, null, 2, "qwe" },
                    { 3, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(10), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(24), null, true, "Indian", "My description", 3, null, null, 3, "abc" },
                    { 4, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(90), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(30), null, true, "Indian", "My description", 4, null, null, 4, "abc" },
                    { 5, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(11), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(12), null, true, "Indian", "My description", 5, null, null, 5, "abc" }
                });
        }
    }
}
