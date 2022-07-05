using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class pms4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 16, 56, 838, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 16, 56, 838, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 16, 56, 838, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 16, 56, 838, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 16, 56, 838, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 16, 56, 838, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 16, 56, 838, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 16, 56, 838, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 16, 56, 838, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 16, 56, 838, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "personalDetails",
                keyColumn: "PersonalDetailsId",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(90));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 6, 36, 323, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 6, 36, 323, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 6, 36, 323, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 6, 36, 323, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 6, 36, 323, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 6, 36, 323, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 6, 36, 323, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 6, 36, 323, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 6, 36, 323, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 6, 36, 323, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "personalDetails",
                keyColumn: "PersonalDetailsId",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(9));
        }
    }
}
