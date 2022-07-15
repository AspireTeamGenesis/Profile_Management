using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class seeding_status_updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProfileStatuss",
                keyColumn: "ProfileStatusId",
                keyValue: 2,
                column: "ProfileStatusName",
                value: "Waiting For Approval");

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 15, 11, 18, 7, 974, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 15, 11, 18, 7, 974, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 15, 11, 18, 7, 974, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 15, 11, 18, 7, 974, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 15, 11, 18, 7, 974, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 15, 11, 18, 7, 974, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 15, 11, 18, 7, 974, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 15, 11, 18, 7, 974, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 15, 11, 18, 7, 974, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 15, 11, 18, 7, 974, DateTimeKind.Local).AddTicks(8706));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProfileStatuss",
                keyColumn: "ProfileStatusId",
                keyValue: 2,
                column: "ProfileStatusName",
                value: "Waiting");

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 13, 0, 10, 43, 745, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 13, 0, 10, 43, 745, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 13, 0, 10, 43, 745, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 13, 0, 10, 43, 745, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 13, 0, 10, 43, 745, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 13, 0, 10, 43, 745, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 13, 0, 10, 43, 745, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 13, 0, 10, 43, 745, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 13, 0, 10, 43, 745, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 13, 0, 10, 43, 745, DateTimeKind.Local).AddTicks(3578));
        }
    }
}
