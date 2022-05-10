using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS.API.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "SocialMedias",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "projects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "personalDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "breakDurationid",
                table: "personalDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "languageid",
                table: "personalDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "socialmediaid",
                table: "personalDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "languages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "educations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "breakDurations",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "skills");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "personalDetails");

            migrationBuilder.DropColumn(
                name: "breakDurationid",
                table: "personalDetails");

            migrationBuilder.DropColumn(
                name: "languageid",
                table: "personalDetails");

            migrationBuilder.DropColumn(
                name: "socialmediaid",
                table: "personalDetails");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "languages");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "educations");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "breakDurations");
        }
    }
}
