using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Designations",
                columns: new[] { "DesignationId", "DesignationName", "IsActive" },
                values: new object[,]
                {
                    { 1, "HR", false },
                    { 2, "Admin", false },
                    { 3, "CEO", false },
                    { 4, "VP", false },
                    { 5, "SLO", false },
                    { 6, "DM", false },
                    { 7, "PM", false },
                    { 8, "PL", false },
                    { 9, "ML", false },
                    { 10, "TL", false },
                    { 11, "SSE", false },
                    { 12, "SE", false }
                });

            migrationBuilder.InsertData(
                table: "Domains",
                columns: new[] { "DomainId", "DomainName", "IsActive" },
                values: new object[,]
                {
                    { 1, "IT", false },
                    { 2, "Marketing", false },
                    { 3, "R&D", false },
                    { 4, "Gaming", false },
                    { 5, "AI", false },
                    { 6, "Logistics", false },
                    { 7, "Hospitality", false },
                    { 8, "Finance", false },
                    { 9, "Food", false },
                    { 10, "Travel", false }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "GenderId", "GenderName", "IsActive" },
                values: new object[,]
                {
                    { 1, "Male", false },
                    { 2, "Female", false },
                    { 3, "Others", false }
                });

            migrationBuilder.InsertData(
                table: "Organisations",
                columns: new[] { "OrganisationId", "IsActive", "OrganisationName" },
                values: new object[,]
                {
                    { 1, false, "Development" },
                    { 2, false, "Testing" },
                    { 3, false, "Support" },
                    { 4, false, "Cloud" },
                    { 5, false, "Server" },
                    { 6, false, "AI" },
                    { 7, false, "UI/UX" },
                    { 8, false, "R&D" },
                    { 9, false, "HR" },
                    { 10, false, "Food" }
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "TechnologyId", "IsActive", "TechnologyName" },
                values: new object[,]
                {
                    { 1, false, "Java" },
                    { 2, false, "DotNet" },
                    { 3, false, "Lamp" },
                    { 4, false, "BFS" },
                    { 5, false, "Sql" },
                    { 6, false, "Python" },
                    { 7, false, "EBA" }
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "TechnologyId", "IsActive", "TechnologyName" },
                values: new object[] { 8, false, "Angular" });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "TechnologyId", "IsActive", "TechnologyName" },
                values: new object[] { 9, false, "C" });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "TechnologyId", "IsActive", "TechnologyName" },
                values: new object[] { 10, false, "Pearl" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "GenderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "GenderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "GenderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 10);
        }
    }
}
