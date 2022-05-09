using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "personalDetails",
                columns: table => new
                {
                    PersonalDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Objective = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNo = table.Column<long>(type: "bigint", nullable: false),
                    DateOfJoinig = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personalDetails", x => x.PersonalDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "breakDurations",
                columns: table => new
                {
                    BreakDuration_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Starting_Month = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Starting_Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ending_Month = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ending_Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonalDetailsId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_breakDurations", x => x.BreakDuration_Id);
                    table.ForeignKey(
                        name: "FK_breakDurations_personalDetails_PersonalDetailsId",
                        column: x => x.PersonalDetailsId,
                        principalTable: "personalDetails",
                        principalColumn: "PersonalDetailsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "educations",
                columns: table => new
                {
                    Education_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Course = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Starting_Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ending_Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Percentage = table.Column<float>(type: "real", nullable: false),
                    PersonalDetailsId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_educations", x => x.Education_Id);
                    table.ForeignKey(
                        name: "FK_educations_personalDetails_PersonalDetailsId",
                        column: x => x.PersonalDetailsId,
                        principalTable: "personalDetails",
                        principalColumn: "PersonalDetailsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    Language_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Read = table.Column<bool>(type: "bit", nullable: false),
                    Write = table.Column<bool>(type: "bit", nullable: false),
                    Speak = table.Column<bool>(type: "bit", nullable: false),
                    PersonalDetailsId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.Language_Id);
                    table.ForeignKey(
                        name: "FK_languages_personalDetails_PersonalDetailsId",
                        column: x => x.PersonalDetailsId,
                        principalTable: "personalDetails",
                        principalColumn: "PersonalDetailsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    Project_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    project_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Project_Starting_Month = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Project_Starting_Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Project_Ending_Month = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Project_Ending_Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonalDetailsId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.Project_Id);
                    table.ForeignKey(
                        name: "FK_projects_personalDetails_PersonalDetailsId",
                        column: x => x.PersonalDetailsId,
                        principalTable: "personalDetails",
                        principalColumn: "PersonalDetailsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "skills",
                columns: table => new
                {
                    Skill_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Technology = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalDetailsId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skills", x => x.Skill_Id);
                    table.ForeignKey(
                        name: "FK_skills_personalDetails_PersonalDetailsId",
                        column: x => x.PersonalDetailsId,
                        principalTable: "personalDetails",
                        principalColumn: "PersonalDetailsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    SocialMedia_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialMedia_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialMedia_Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalDetailsId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.SocialMedia_Id);
                    table.ForeignKey(
                        name: "FK_SocialMedias_personalDetails_PersonalDetailsId",
                        column: x => x.PersonalDetailsId,
                        principalTable: "personalDetails",
                        principalColumn: "PersonalDetailsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_breakDurations_PersonalDetailsId",
                table: "breakDurations",
                column: "PersonalDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_educations_PersonalDetailsId",
                table: "educations",
                column: "PersonalDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_languages_PersonalDetailsId",
                table: "languages",
                column: "PersonalDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_projects_PersonalDetailsId",
                table: "projects",
                column: "PersonalDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_skills_PersonalDetailsId",
                table: "skills",
                column: "PersonalDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_PersonalDetailsId",
                table: "SocialMedias",
                column: "PersonalDetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "breakDurations");

            migrationBuilder.DropTable(
                name: "educations");

            migrationBuilder.DropTable(
                name: "languages");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "skills");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "personalDetails");
        }
    }
}
