using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS.API.Migrations
{
    public partial class disablevirtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_personalDetails_PersonalDetailsId",
                table: "SocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_SocialMedias_PersonalDetailsId",
                table: "SocialMedias");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_PersonalDetailsId",
                table: "SocialMedias",
                column: "PersonalDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_personalDetails_PersonalDetailsId",
                table: "SocialMedias",
                column: "PersonalDetailsId",
                principalTable: "personalDetails",
                principalColumn: "PersonalDetailsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
