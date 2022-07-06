using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "SocialMedia_Id", "CreatedBy", "CreatedOn", "IsActive", "PersonalDetailsId", "SocialMedia_Link", "SocialMedia_Name", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, null, true, 5, "www.linkedin.com", "LinkedIn", null, null },
                    { 2, null, null, true, 4, "www.telegram.com", "Telegram", null, null },
                    { 3, null, null, true, 3, "www.facebook.com", "Facebook", null, null },
                    { 4, null, null, true, 2, "www.twitter.com", "Twitter", null, null },
                    { 5, null, null, true, 1, "www.instagram.com", "Instagram", null, null }
                });

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 33, 6, 535, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 33, 6, 535, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 33, 6, 535, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 33, 6, 535, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 33, 6, 535, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 33, 6, 535, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 33, 6, 535, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 33, 6, 535, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 33, 6, 535, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 33, 6, 535, DateTimeKind.Local).AddTicks(7885));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "SocialMedia_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "SocialMedia_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "SocialMedia_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "SocialMedia_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "SocialMedia_Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 32, 8, 347, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 32, 8, 347, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 32, 8, 347, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 32, 8, 347, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 32, 8, 347, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 32, 8, 347, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 32, 8, 347, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 32, 8, 347, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 32, 8, 347, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 5, 23, 32, 8, 347, DateTimeKind.Local).AddTicks(8811));
        }
    }
}
