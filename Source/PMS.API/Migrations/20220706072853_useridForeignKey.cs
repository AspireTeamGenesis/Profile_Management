using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class useridForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "profile",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 6, 12, 58, 52, 426, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 6, 12, 58, 52, 426, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 6, 12, 58, 52, 426, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 6, 12, 58, 52, 426, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 6, 12, 58, 52, 426, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 6, 12, 58, 52, 426, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 6, 12, 58, 52, 426, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 6, 12, 58, 52, 426, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 6, 12, 58, 52, 426, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 6, 12, 58, 52, 426, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 1,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 2,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 3,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 4,
                column: "UserId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 5,
                column: "UserId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 6,
                column: "UserId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 7,
                column: "UserId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 8,
                column: "UserId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 9,
                column: "UserId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 10,
                column: "UserId",
                value: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "profile");

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 36, 19, 352, DateTimeKind.Local).AddTicks(4096));
        }
    }
}
