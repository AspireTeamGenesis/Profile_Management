using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class seeding7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "UserId", "CountryCodeId", "CreatedBy", "CreatedOn", "DesignationId", "Email", "GenderId", "IsActive", "MobileNumber", "Name", "OrganisationId", "Password", "ReportingPersonUsername", "UpdatedBy", "UpdatedOn", "UserName" },
                values: new object[] { 1, 1, null, null, 2, "chittu123@gmail.com", 1, true, "8610805522", "Chitrarasu", 3, "Chitra@2419", "Jaya19", null, null, "Chittu@25" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 1);
        }
    }
}
