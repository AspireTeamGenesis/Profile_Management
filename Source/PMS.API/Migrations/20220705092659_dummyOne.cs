using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class dummyOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "breakDurations",
                columns: new[] { "BreakDuration_Id", "CreatedBy", "CreatedOn", "EndingDuration", "IsActive", "PersonalDetailsId", "StartingDuration", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 6, null, null, new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 5, new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 56, 58, 660, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 56, 58, 660, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 56, 58, 660, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 56, 58, 660, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 56, 58, 660, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 56, 58, 660, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 56, 58, 660, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 56, 58, 660, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 56, 58, 660, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 56, 58, 660, DateTimeKind.Local).AddTicks(9115));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "breakDurations",
                keyColumn: "BreakDuration_Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 55, 13, 641, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 55, 13, 641, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 55, 13, 641, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 55, 13, 641, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 55, 13, 641, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 55, 13, 641, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 55, 13, 641, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 55, 13, 641, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 55, 13, 641, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 55, 13, 641, DateTimeKind.Local).AddTicks(3058));
        }
    }
}
