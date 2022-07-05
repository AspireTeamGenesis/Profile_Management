using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class dummy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 42, 56, 44, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 42, 56, 44, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 42, 56, 44, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 42, 56, 44, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 42, 56, 44, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 42, 56, 44, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 42, 56, 44, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 42, 56, 44, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 42, 56, 44, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 42, 56, 44, DateTimeKind.Local).AddTicks(7898));
        }
    }
}
