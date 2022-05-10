using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "breakDurations",
                columns: table => new
                {
                    BreakDuration_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Starting_Month = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Starting_Year = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ending_Month = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ending_Year = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_breakDurations", x => x.BreakDuration_Id);
                });

            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Read = table.Column<bool>(type: "bit", nullable: false),
                    Write = table.Column<bool>(type: "bit", nullable: false),
                    Speak = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    SocialMedia_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialMedia_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialMedia_Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.SocialMedia_Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNo = table.Column<long>(type: "bigint", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reporting_Person = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "personalDetails",
                columns: table => new
                {
                    PersonalDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Objective = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNo = table.Column<long>(type: "bigint", nullable: false),
                    DateOfJoinig = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    languageid = table.Column<int>(type: "int", nullable: false),
                    breakDurationid = table.Column<int>(type: "int", nullable: false),
                    socialmediaid = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personalDetails", x => x.PersonalDetailsId);
                    table.ForeignKey(
                        name: "FK_personalDetails_breakDurations_breakDurationid",
                        column: x => x.breakDurationid,
                        principalTable: "breakDurations",
                        principalColumn: "BreakDuration_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personalDetails_languages_languageid",
                        column: x => x.languageid,
                        principalTable: "languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personalDetails_SocialMedias_socialmediaid",
                        column: x => x.socialmediaid,
                        principalTable: "SocialMedias",
                        principalColumn: "SocialMedia_Id",
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
                    Starting_Year = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ending_Year = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Percentage = table.Column<float>(type: "real", nullable: false),
                    personaldetailsid = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_educations", x => x.Education_Id);
                    table.ForeignKey(
                        name: "FK_educations_personalDetails_personaldetailsid",
                        column: x => x.personaldetailsid,
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
                    Project_Starting_Month = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Project_Starting_Year = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Project_Ending_Month = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Project_Ending_Year = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PersonalDetailsId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
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
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_educations_personaldetailsid",
                table: "educations",
                column: "personaldetailsid");

            migrationBuilder.CreateIndex(
                name: "IX_personalDetails_breakDurationid",
                table: "personalDetails",
                column: "breakDurationid");

            migrationBuilder.CreateIndex(
                name: "IX_personalDetails_languageid",
                table: "personalDetails",
                column: "languageid");

            migrationBuilder.CreateIndex(
                name: "IX_personalDetails_socialmediaid",
                table: "personalDetails",
                column: "socialmediaid");

            migrationBuilder.CreateIndex(
                name: "IX_projects_PersonalDetailsId",
                table: "projects",
                column: "PersonalDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_skills_PersonalDetailsId",
                table: "skills",
                column: "PersonalDetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "educations");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "skills");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "personalDetails");

            migrationBuilder.DropTable(
                name: "breakDurations");

            migrationBuilder.DropTable(
                name: "languages");

            migrationBuilder.DropTable(
                name: "SocialMedias");
        }
    }
}
