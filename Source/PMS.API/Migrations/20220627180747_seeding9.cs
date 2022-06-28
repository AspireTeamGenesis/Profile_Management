using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class seeding9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ChangePasswords",
                columns: new[] { "ChangePasswordId", "ConfirmPassword", "IsActive", "NewPassword" },
                values: new object[,]
                {
                    { 1, "qwerty@123", true, "qwerty@123" },
                    { 2, "zxcvbn@321", true, "zxcvbn@321" },
                    { 3, "asdfgh@111", true, "asdfgh@111" },
                    { 4, "lkjhgf@999", true, "lkjhgf@999" },
                    { 5, "poiuyt@777", true, "poiuyt@777" }
                });

            migrationBuilder.InsertData(
                table: "personalDetails",
                columns: new[] { "PersonalDetailsId", "CreatedBy", "CreatedOn", "DateOfBirth", "DateOfJoining", "Image", "IsActive", "Nationality", "Objective", "ProfileId", "UpdatedBy", "UpdatedOn", "UserId", "base64header" },
                values: new object[] { 1, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(11), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(24), null, true, "Indian", "My description", 1, null, null, 1, "abc" });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "MobileNumber", "Password" },
                values: new object[] { "8610805521", "Chitra@2321" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "UserId", "CountryCodeId", "CreatedBy", "CreatedOn", "DesignationId", "Email", "GenderId", "IsActive", "MobileNumber", "Name", "OrganisationId", "Password", "ReportingPersonUsername", "UpdatedBy", "UpdatedOn", "UserName" },
                values: new object[,]
                {
                    { 2, 1, null, null, 2, "guganrb@gmail.com", 1, true, "9994660926", "Gugan", 1, "Gugan45@1924", "Savitha25", null, null, "gugan@45" },
                    { 3, 1, null, null, 3, "harinir@gmail.com", 2, true, "8610806522", "Harini", 2, "harini@2626", "snigdha30", null, null, "harini@22" },
                    { 4, 2, null, null, 3, "kishore45@gmail.com", 1, true, "8610805513", "Kishore", 1, "kishore@6754", "Jaya19", null, null, "kishore@65" },
                    { 5, 1, null, null, 2, "brindham@gmail.com", 2, true, "9610805522", "Brindha", 4, "brindha@1234", "Savitha25", null, null, "Brindha@77" }
                });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "SocialMedia_Id", "CreatedBy", "CreatedOn", "IsActive", "PersonalDetailsId", "SocialMedia_Link", "SocialMedia_Name", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 5, null, null, true, 1, "www.instagram.com", "Instagram", null, null });

            migrationBuilder.InsertData(
                table: "breakDurations",
                columns: new[] { "BreakDuration_Id", "CreatedBy", "CreatedOn", "EndingBreakMonth", "EndingBreakYear", "IsActive", "PersonalDetailsId", "StartingBreakMonth", "StartingBreakYear", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 1, null, null, "October", 2019, true, 1, "October", 2018, null, null });

            migrationBuilder.InsertData(
                table: "languages",
                columns: new[] { "LanguageId", "CreatedBy", "CreatedOn", "IsActive", "LanguageName", "PersonalDetailsId", "Read", "Speak", "UpdatedBy", "UpdatedOn", "Write" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(7994), true, "English", 1, true, true, null, null, true },
                    { 9, null, new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(8016), true, "Urdu", 1, true, true, null, null, true }
                });

            migrationBuilder.InsertData(
                table: "personalDetails",
                columns: new[] { "PersonalDetailsId", "CreatedBy", "CreatedOn", "DateOfBirth", "DateOfJoining", "Image", "IsActive", "Nationality", "Objective", "ProfileId", "UpdatedBy", "UpdatedOn", "UserId", "base64header" },
                values: new object[,]
                {
                    { 2, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(86), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(24), null, true, "Indian", "My description", 2, null, null, 2, "qwe" },
                    { 3, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(10), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(24), null, true, "Indian", "My description", 3, null, null, 3, "abc" },
                    { 4, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(9), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(24), null, true, "Indian", "My description", 4, null, null, 4, "abc" },
                    { 5, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(11), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(24), null, true, "Indian", "My description", 5, null, null, 5, "abc" }
                });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "SocialMedia_Id", "CreatedBy", "CreatedOn", "IsActive", "PersonalDetailsId", "SocialMedia_Link", "SocialMedia_Name", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, null, true, 5, "www.linkedin.com", "LinkedIn", null, null },
                    { 2, null, null, true, 4, "www.telegram.com", "Telegram", null, null },
                    { 3, null, null, true, 3, "www.facebook.com", "Facebook", null, null },
                    { 4, null, null, true, 2, "www.twitter.com", "Twitter", null, null }
                });

            migrationBuilder.InsertData(
                table: "breakDurations",
                columns: new[] { "BreakDuration_Id", "CreatedBy", "CreatedOn", "EndingBreakMonth", "EndingBreakYear", "IsActive", "PersonalDetailsId", "StartingBreakMonth", "StartingBreakYear", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 2, null, null, "November", 2018, true, 2, "May", 2017, null, null },
                    { 3, null, null, "October", 2020, true, 3, "Jan", 2019, null, null },
                    { 4, null, null, "December", 2019, true, 4, "August", 2018, null, null },
                    { 5, null, null, "October", 2020, true, 5, "May", 2020, null, null }
                });

            migrationBuilder.InsertData(
                table: "languages",
                columns: new[] { "LanguageId", "CreatedBy", "CreatedOn", "IsActive", "LanguageName", "PersonalDetailsId", "Read", "Speak", "UpdatedBy", "UpdatedOn", "Write" },
                values: new object[,]
                {
                    { 2, null, new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(8007), true, "Tamil", 2, true, true, null, null, true },
                    { 3, null, new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(8008), true, "Hindi", 3, true, true, null, null, true },
                    { 4, null, new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(8011), true, "Telugu", 4, true, true, null, null, true },
                    { 5, null, new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(8012), true, "Malayalam", 5, true, true, null, null, true },
                    { 6, null, new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(8013), true, "Kannada", 3, true, true, null, null, true },
                    { 7, null, new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(8014), true, "Bengali", 4, true, true, null, null, true },
                    { 8, null, new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(8015), true, "Marathi", 3, true, true, null, null, true },
                    { 10, null, new DateTime(2022, 6, 27, 23, 37, 47, 104, DateTimeKind.Local).AddTicks(8016), true, "French", 2, true, true, null, null, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChangePasswords",
                keyColumn: "ChangePasswordId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ChangePasswords",
                keyColumn: "ChangePasswordId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ChangePasswords",
                keyColumn: "ChangePasswordId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ChangePasswords",
                keyColumn: "ChangePasswordId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ChangePasswords",
                keyColumn: "ChangePasswordId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "SocialMedia_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "SocialMedia_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "SocialMedia_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "SocialMedia_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "SocialMedia_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "breakDurations",
                keyColumn: "BreakDuration_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "breakDurations",
                keyColumn: "BreakDuration_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "breakDurations",
                keyColumn: "BreakDuration_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "breakDurations",
                keyColumn: "BreakDuration_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "breakDurations",
                keyColumn: "BreakDuration_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "languages",
                keyColumn: "LanguageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "personalDetails",
                keyColumn: "PersonalDetailsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "personalDetails",
                keyColumn: "PersonalDetailsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "personalDetails",
                keyColumn: "PersonalDetailsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "personalDetails",
                keyColumn: "PersonalDetailsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "personalDetails",
                keyColumn: "PersonalDetailsId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "MobileNumber", "Password" },
                values: new object[] { "8610805522", "Chitra@2419" });
        }
    }
}
