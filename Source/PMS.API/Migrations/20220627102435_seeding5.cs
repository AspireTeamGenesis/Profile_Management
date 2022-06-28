using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class seeding5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "educations",
                keyColumn: "EducationId",
                keyValue: 10,
                column: "IsActive",
                value: true);

            migrationBuilder.InsertData(
                table: "profilehistory",
                columns: new[] { "ProfileHistoryId", "ApprovedDate", "IsActive", "ProfileId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 2, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3 },
                    { 3, new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 },
                    { 4, new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "profilehistory",
                keyColumn: "ProfileHistoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "profilehistory",
                keyColumn: "ProfileHistoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "profilehistory",
                keyColumn: "ProfileHistoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "profilehistory",
                keyColumn: "ProfileHistoryId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "educations",
                keyColumn: "EducationId",
                keyValue: 10,
                column: "IsActive",
                value: false);
        }
    }
}
