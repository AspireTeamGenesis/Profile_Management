using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class seeding6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "projects",
                columns: new[] { "ProjectId", "CreatedBy", "CreatedOn", "Designation", "EndingMonth", "EndingYear", "IsActive", "ProfileId", "ProjectDescription", "ProjectName", "StartingMonth", "StartingYear", "ToolsUsed", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, null, "SE", "October", 2019, true, 1, "Create a Profile", "PMS", "October", 2018, "Figma", null, null },
                    { 2, null, null, "SSE", "July", 2021, true, 2, "Monitor the Trainee", "TMS", "April", 2018, "Balsamic", null, null },
                    { 3, null, null, "SE", "June", 2020, true, 3, "Interview process", "IMS", "January", 2019, "JIRA", null, null },
                    { 4, null, null, "ML", "February", 2021, true, 4, "Award Distribution", "AMS", "November", 2020, "Figma", null, null },
                    { 5, null, null, "PM", "September", 2020, true, 5, "Query Management", "QMS", "December", 2019, "JIRA", null, null }
                });

            migrationBuilder.InsertData(
                table: "skills",
                columns: new[] { "SkillId", "CreatedBy", "CreatedOn", "DomainId", "IsActive", "ProfileId", "TechnologyId", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, null, 6, true, 1, 7, null, null },
                    { 2, null, null, 2, true, 3, 2, null, null },
                    { 3, null, null, 7, true, 4, 5, null, null },
                    { 4, null, null, 3, true, 2, 1, null, null },
                    { 5, null, null, 1, true, 5, 10, null, null },
                    { 6, null, null, 10, true, 1, 8, null, null },
                    { 7, null, null, 8, true, 9, 6, null, null },
                    { 8, null, null, 5, true, 10, 4, null, null },
                    { 9, null, null, 9, true, 8, 3, null, null },
                    { 10, null, null, 4, true, 6, 9, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "ProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "projects",
                keyColumn: "ProjectId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "SkillId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "SkillId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "SkillId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "SkillId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "SkillId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "SkillId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "SkillId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "SkillId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "SkillId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "skills",
                keyColumn: "SkillId",
                keyValue: 10);
        }
    }
}
