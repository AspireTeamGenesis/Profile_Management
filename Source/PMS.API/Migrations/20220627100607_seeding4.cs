using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class seeding4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "educations",
                columns: new[] { "EducationId", "Course", "CreatedBy", "CreatedOn", "Degree", "Ending", "IsActive", "Percentage", "ProfileId", "Starting", "UpdatedBy", "UpdatedOn", "collegeid" },
                values: new object[,]
                {
                    { 1, "ECE", null, null, "BE", 2022, true, 85.6f, 1, 2018, null, null, 2 },
                    { 2, "IT", null, null, "BTech", 2022, true, 96.8f, 2, 2018, null, null, 1 },
                    { 3, "CSE", null, null, "Bsc", 2022, true, 91f, 3, 2018, null, null, 4 },
                    { 4, "CSE", null, null, "ME", 2022, true, 89.5f, 4, 2020, null, null, 10 },
                    { 5, "IT", null, null, "MTech", 2022, true, 83.6f, 5, 2020, null, null, 6 },
                    { 6, "MCT", null, null, "BE", 2022, true, 81.6f, 6, 2018, null, null, 5 },
                    { 7, "CSE", null, null, "ME", 2022, true, 94.5f, 7, 2020, null, null, 8 },
                    { 8, "EEE", null, null, "BE", 2022, true, 81.8f, 8, 2018, null, null, 9 },
                    { 9, "IT", null, null, "MTech", 2022, true, 90.3f, 9, 2020, null, null, 3 },
                    { 10, "IT", null, null, "BTech", 2022, false, 85f, 10, 2018, null, null, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "educations",
                keyColumn: "EducationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "educations",
                keyColumn: "EducationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "educations",
                keyColumn: "EducationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "educations",
                keyColumn: "EducationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "educations",
                keyColumn: "EducationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "educations",
                keyColumn: "EducationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "educations",
                keyColumn: "EducationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "educations",
                keyColumn: "EducationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "educations",
                keyColumn: "EducationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "educations",
                keyColumn: "EducationId",
                keyValue: 10);
        }
    }
}
