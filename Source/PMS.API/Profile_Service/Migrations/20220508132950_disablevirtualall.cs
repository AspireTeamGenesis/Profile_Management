using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS.API.Migrations
{
    public partial class disablevirtualall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_breakDurations_personalDetails_PersonalDetailsId",
                table: "breakDurations");

            migrationBuilder.DropForeignKey(
                name: "FK_educations_personalDetails_PersonalDetailsId",
                table: "educations");

            migrationBuilder.DropForeignKey(
                name: "FK_languages_personalDetails_PersonalDetailsId",
                table: "languages");

            migrationBuilder.DropForeignKey(
                name: "FK_projects_personalDetails_PersonalDetailsId",
                table: "projects");

            migrationBuilder.DropForeignKey(
                name: "FK_skills_personalDetails_PersonalDetailsId",
                table: "skills");

            migrationBuilder.DropIndex(
                name: "IX_skills_PersonalDetailsId",
                table: "skills");

            migrationBuilder.DropIndex(
                name: "IX_projects_PersonalDetailsId",
                table: "projects");

            migrationBuilder.DropIndex(
                name: "IX_languages_PersonalDetailsId",
                table: "languages");

            migrationBuilder.DropIndex(
                name: "IX_educations_PersonalDetailsId",
                table: "educations");

            migrationBuilder.DropIndex(
                name: "IX_breakDurations_PersonalDetailsId",
                table: "breakDurations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_skills_PersonalDetailsId",
                table: "skills",
                column: "PersonalDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_projects_PersonalDetailsId",
                table: "projects",
                column: "PersonalDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_languages_PersonalDetailsId",
                table: "languages",
                column: "PersonalDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_educations_PersonalDetailsId",
                table: "educations",
                column: "PersonalDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_breakDurations_PersonalDetailsId",
                table: "breakDurations",
                column: "PersonalDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_breakDurations_personalDetails_PersonalDetailsId",
                table: "breakDurations",
                column: "PersonalDetailsId",
                principalTable: "personalDetails",
                principalColumn: "PersonalDetailsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_educations_personalDetails_PersonalDetailsId",
                table: "educations",
                column: "PersonalDetailsId",
                principalTable: "personalDetails",
                principalColumn: "PersonalDetailsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_languages_personalDetails_PersonalDetailsId",
                table: "languages",
                column: "PersonalDetailsId",
                principalTable: "personalDetails",
                principalColumn: "PersonalDetailsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_projects_personalDetails_PersonalDetailsId",
                table: "projects",
                column: "PersonalDetailsId",
                principalTable: "personalDetails",
                principalColumn: "PersonalDetailsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_skills_personalDetails_PersonalDetailsId",
                table: "skills",
                column: "PersonalDetailsId",
                principalTable: "personalDetails",
                principalColumn: "PersonalDetailsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
