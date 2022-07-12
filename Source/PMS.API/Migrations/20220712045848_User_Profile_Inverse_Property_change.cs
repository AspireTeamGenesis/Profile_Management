﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class User_Profile_Inverse_Property_change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfileUser");

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 10, 28, 47, 454, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 10, 28, 47, 454, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 10, 28, 47, 454, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 10, 28, 47, 454, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 10, 28, 47, 454, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 10, 28, 47, 454, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 10, 28, 47, 454, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 10, 28, 47, 454, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 10, 28, 47, 454, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 10, 28, 47, 454, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.CreateIndex(
                name: "IX_profile_UserId",
                table: "profile",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_profile_users_UserId",
                table: "profile",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_profile_users_UserId",
                table: "profile");

            migrationBuilder.DropIndex(
                name: "IX_profile_UserId",
                table: "profile");

            migrationBuilder.CreateTable(
                name: "ProfileUser",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileUser", x => new { x.UserId, x.UserId1 });
                    table.ForeignKey(
                        name: "FK_ProfileUser_profile_UserId",
                        column: x => x.UserId,
                        principalTable: "profile",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfileUser_users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 9, 33, 29, 317, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 9, 33, 29, 317, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 9, 33, 29, 317, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 9, 33, 29, 317, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 9, 33, 29, 317, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 9, 33, 29, 317, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 9, 33, 29, 317, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 9, 33, 29, 317, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 9, 33, 29, 317, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 7, 12, 9, 33, 29, 317, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.CreateIndex(
                name: "IX_ProfileUser_UserId1",
                table: "ProfileUser",
                column: "UserId1");
        }
    }
}
