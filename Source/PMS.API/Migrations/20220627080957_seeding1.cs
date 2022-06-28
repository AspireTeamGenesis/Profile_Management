using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class seeding1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 3,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 4,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 5,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 6,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 7,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 8,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 9,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 10,
                column: "IsActive",
                value: true);

            migrationBuilder.InsertData(
                table: "CountryCodes",
                columns: new[] { "CountryCodeId", "CountryCodeName", "IsActive" },
                values: new object[,]
                {
                    { 1, "+91", true },
                    { 2, "+1", true },
                    { 3, "+44", true },
                    { 4, "+61", true },
                    { 5, "+62", true },
                    { 6, "+86", true },
                    { 7, "+213", true },
                    { 8, "+355", true },
                    { 9, "+93", true },
                    { 10, "+54", true }
                });

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 3,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 4,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 5,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 6,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 7,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 8,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 9,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 10,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 11,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 12,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 3,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 4,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 5,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 6,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 7,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 8,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 9,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 10,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "GenderId",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "GenderId",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "GenderId",
                keyValue: 3,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 3,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 4,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 5,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 6,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 7,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 8,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 9,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 10,
                column: "IsActive",
                value: true);

            migrationBuilder.InsertData(
                table: "ProfileStatuss",
                columns: new[] { "ProfileStatusId", "IsActive", "ProfileStatusName" },
                values: new object[,]
                {
                    { 1, true, "Approved" },
                    { 2, true, "Waiting" },
                    { 3, true, "Declined" }
                });

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 3,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 4,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 5,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 6,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 7,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 8,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 9,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 10,
                column: "IsActive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CountryCodes",
                keyColumn: "CountryCodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CountryCodes",
                keyColumn: "CountryCodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CountryCodes",
                keyColumn: "CountryCodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CountryCodes",
                keyColumn: "CountryCodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CountryCodes",
                keyColumn: "CountryCodeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CountryCodes",
                keyColumn: "CountryCodeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CountryCodes",
                keyColumn: "CountryCodeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CountryCodes",
                keyColumn: "CountryCodeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CountryCodes",
                keyColumn: "CountryCodeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CountryCodes",
                keyColumn: "CountryCodeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProfileStatuss",
                keyColumn: "ProfileStatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProfileStatuss",
                keyColumn: "ProfileStatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProfileStatuss",
                keyColumn: "ProfileStatusId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 1,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 2,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 3,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 4,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 5,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 6,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 7,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 8,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 9,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 10,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 1,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 2,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 3,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 4,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 5,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 6,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 7,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 8,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 9,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 10,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 11,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 12,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 1,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 2,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 3,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 4,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 5,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 6,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 7,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 8,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 9,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "DomainId",
                keyValue: 10,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "GenderId",
                keyValue: 1,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "GenderId",
                keyValue: 2,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "GenderId",
                keyValue: 3,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 1,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 2,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 3,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 4,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 5,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 6,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 7,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 8,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 9,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Organisations",
                keyColumn: "OrganisationId",
                keyValue: 10,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 1,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 2,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 3,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 4,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 5,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 6,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 7,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 8,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 9,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Technologies",
                keyColumn: "TechnologyId",
                keyValue: 10,
                column: "IsActive",
                value: false);
        }
    }
}
