using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class breakduration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 59, 43, 371, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 59, 43, 371, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 59, 43, 371, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 59, 43, 371, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 59, 43, 371, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 59, 43, 371, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 59, 43, 371, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 59, 43, 371, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 59, 43, 371, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 14, 59, 43, 371, DateTimeKind.Local).AddTicks(9947));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
