using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_API.Migrations
{
    public partial class pms2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndingBreakMonth",
                table: "breakDurations");

            migrationBuilder.DropColumn(
                name: "EndingBreakYear",
                table: "breakDurations");

            migrationBuilder.DropColumn(
                name: "StartingBreakMonth",
                table: "breakDurations");

            migrationBuilder.DropColumn(
                name: "StartingBreakYear",
                table: "breakDurations");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndingDuration",
                table: "breakDurations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartingDuration",
                table: "breakDurations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AchievementType",
                columns: new[] { "AchievementTypeId", "AchievementTypeName", "IsActive" },
                values: new object[,]
                {
                    { 1, "Awards", true },
                    { 2, "Certificates", true }
                });

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "CollegeId", "CollegeName", "IsActive" },
                values: new object[,]
                {
                    { 1, "SKCET", true },
                    { 2, "SKCT", true },
                    { 3, "BIT", true },
                    { 4, "SA", true },
                    { 5, "PSNA", true },
                    { 6, "CIT", true },
                    { 7, "PSG", true },
                    { 8, "Kumaraguru", true },
                    { 9, "MIT", true },
                    { 10, "GCT", true }
                });

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

            migrationBuilder.InsertData(
                table: "Designations",
                columns: new[] { "DesignationId", "DesignationName", "IsActive" },
                values: new object[,]
                {
                    { 1, "HR", true },
                    { 2, "Admin", true },
                    { 3, "CEO", true },
                    { 4, "VP", true },
                    { 5, "SLO", true },
                    { 6, "DM", true },
                    { 7, "PM", true },
                    { 8, "PL", true },
                    { 9, "ML", true },
                    { 10, "TL", true },
                    { 11, "SSE", true },
                    { 12, "SE", true }
                });

            migrationBuilder.InsertData(
                table: "Domains",
                columns: new[] { "DomainId", "DomainName", "IsActive" },
                values: new object[,]
                {
                    { 1, "IT", true },
                    { 2, "Marketing", true },
                    { 3, "R&D", true },
                    { 4, "Gaming", true },
                    { 5, "AI", true },
                    { 6, "Logistics", true },
                    { 7, "Hospitality", true },
                    { 8, "Finance", true }
                });

            migrationBuilder.InsertData(
                table: "Domains",
                columns: new[] { "DomainId", "DomainName", "IsActive" },
                values: new object[,]
                {
                    { 9, "Food", true },
                    { 10, "Travel", true }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "GenderId", "GenderName", "IsActive" },
                values: new object[,]
                {
                    { 1, "Male", true },
                    { 2, "Female", true },
                    { 3, "Others", true }
                });

            migrationBuilder.InsertData(
                table: "Organisations",
                columns: new[] { "OrganisationId", "IsActive", "OrganisationName" },
                values: new object[,]
                {
                    { 1, true, "Development" },
                    { 2, true, "Testing" },
                    { 3, true, "Support" },
                    { 4, true, "Cloud" },
                    { 5, true, "Server" },
                    { 6, true, "AI" },
                    { 7, true, "UI/UX" },
                    { 8, true, "R&D" },
                    { 9, true, "HR" },
                    { 10, true, "Food" }
                });

            migrationBuilder.InsertData(
                table: "ProfileStatuss",
                columns: new[] { "ProfileStatusId", "IsActive", "ProfileStatusName" },
                values: new object[,]
                {
                    { 1, true, "Approved" },
                    { 2, true, "Waiting" },
                    { 3, true, "Declined" }
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "TechnologyId", "IsActive", "TechnologyName" },
                values: new object[,]
                {
                    { 1, true, "Java" },
                    { 2, true, "DotNet" },
                    { 3, true, "Lamp" },
                    { 4, true, "BFS" },
                    { 5, true, "Sql" },
                    { 6, true, "Python" },
                    { 7, true, "EBA" },
                    { 8, true, "Angular" },
                    { 9, true, "C" },
                    { 10, true, "Pearl" }
                });

            migrationBuilder.InsertData(
                table: "profile",
                columns: new[] { "ProfileId", "IsActive", "ProfileStatusId" },
                values: new object[,]
                {
                    { 1, true, 1 },
                    { 2, true, 3 },
                    { 3, true, 1 },
                    { 4, true, 2 },
                    { 5, true, 2 },
                    { 6, true, 1 },
                    { 7, true, 3 },
                    { 8, true, 2 },
                    { 9, true, 3 },
                    { 10, true, 1 }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "UserId", "CountryCodeId", "CreatedBy", "CreatedOn", "DesignationId", "Email", "GenderId", "IsActive", "MobileNumber", "Name", "OrganisationId", "Password", "ReportingPersonUsername", "UpdatedBy", "UpdatedOn", "UserName" },
                values: new object[,]
                {
                    { 1, 1, null, null, 2, "chittu123@gmail.com", 1, true, "8610805521", "Chitrarasu", 3, "Chitra@2321", "Jaya19", null, null, "Chittu@25" },
                    { 2, 1, null, null, 2, "guganrb@gmail.com", 1, true, "9994660926", "Gugan", 1, "Gugan45@1924", "Savitha25", null, null, "gugan@45" },
                    { 3, 1, null, null, 3, "harinir@gmail.com", 2, true, "8610806522", "Harini", 2, "harini@2626", "snigdha30", null, null, "harini@22" },
                    { 4, 2, null, null, 3, "kishore45@gmail.com", 1, true, "8610805513", "Kishore", 1, "kishore@6754", "Jaya19", null, null, "kishore@65" },
                    { 5, 1, null, null, 2, "brindham@gmail.com", 2, true, "9610805522", "Brindha", 4, "brindha@1234", "Savitha25", null, null, "Brindha@77" }
                });

            migrationBuilder.InsertData(
                table: "achievements",
                columns: new[] { "AchievementId", "AchievementImage", "AchievementTypeId", "CreatedBy", "CreatedOn", "IsActive", "ProfileId", "UpdatedBy", "UpdatedOn", "base64header" },
                values: new object[,]
                {
                    { 1, null, 1, null, null, true, 1, null, null, "abc" },
                    { 2, null, 2, null, null, true, 2, null, null, "abc" },
                    { 3, null, 1, null, null, true, 3, null, null, "abc" },
                    { 4, null, 2, null, null, true, 4, null, null, "abc" },
                    { 5, null, 1, null, null, true, 5, null, null, "abc" }
                });

            migrationBuilder.InsertData(
                table: "educations",
                columns: new[] { "EducationId", "CollegeId", "Course", "CreatedBy", "CreatedOn", "Degree", "Ending", "IsActive", "Percentage", "ProfileId", "Starting", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 2, "ECE", null, null, "BE", 2022, true, 85.6f, 1, 2018, null, null },
                    { 2, 1, "IT", null, null, "BTech", 2022, true, 96.8f, 2, 2018, null, null },
                    { 3, 4, "CSE", null, null, "Bsc", 2022, true, 91f, 3, 2018, null, null },
                    { 4, 10, "CSE", null, null, "ME", 2022, true, 89.5f, 4, 2020, null, null },
                    { 5, 6, "IT", null, null, "MTech", 2022, true, 83.6f, 5, 2020, null, null },
                    { 6, 5, "MCT", null, null, "BE", 2022, true, 81.6f, 6, 2018, null, null },
                    { 7, 8, "CSE", null, null, "ME", 2022, true, 94.5f, 7, 2020, null, null },
                    { 8, 9, "EEE", null, null, "BE", 2022, true, 81.8f, 8, 2018, null, null },
                    { 9, 3, "IT", null, null, "MTech", 2022, true, 90.3f, 9, 2020, null, null },
                    { 10, 7, "IT", null, null, "BTech", 2022, true, 85f, 10, 2018, null, null }
                });

            migrationBuilder.InsertData(
                table: "personalDetails",
                columns: new[] { "PersonalDetailsId", "CreatedBy", "CreatedOn", "DateOfBirth", "DateOfJoining", "Image", "IsActive", "Nationality", "Objective", "ProfileId", "UpdatedBy", "UpdatedOn", "UserId", "base64header" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(11), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(24), null, true, "Indian", "My description", 1, null, null, 1, "abc" },
                    { 2, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(86), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(24), null, true, "Indian", "My description", 2, null, null, 2, "qwe" },
                    { 3, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(10), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(24), null, true, "Indian", "My description", 3, null, null, 3, "abc" },
                    { 4, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(9), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(30), null, true, "Indian", "My description", 4, null, null, 4, "abc" },
                    { 5, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(11), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(12), null, true, "Indian", "My description", 5, null, null, 5, "abc" }
                });

            migrationBuilder.InsertData(
                table: "profilehistory",
                columns: new[] { "ProfileHistoryId", "ApprovedDate", "IsActive", "ProfileId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 2, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3 },
                    { 3, new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 },
                    { 4, new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 10 }
                });

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

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "SocialMedia_Id", "CreatedBy", "CreatedOn", "IsActive", "PersonalDetailsId", "SocialMedia_Link", "SocialMedia_Name", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, null, true, 5, "www.linkedin.com", "LinkedIn", null, null },
                    { 2, null, null, true, 4, "www.telegram.com", "Telegram", null, null },
                    { 3, null, null, true, 3, "www.facebook.com", "Facebook", null, null },
                    { 4, null, null, true, 2, "www.twitter.com", "Twitter", null, null },
                    { 5, null, null, true, 1, "www.instagram.com", "Instagram", null, null }
                });

            migrationBuilder.InsertData(
                table: "breakDurations",
                columns: new[] { "BreakDuration_Id", "CreatedBy", "CreatedOn", "EndingDuration", "IsActive", "PersonalDetailsId", "StartingDuration", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(22), true, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(134), null, null },
                    { 2, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(19), true, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(11), null, null },
                    { 3, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(11), true, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(33), null, null },
                    { 4, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(22), true, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(134), null, null },
                    { 5, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(67), true, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(11), null, null }
                });

            migrationBuilder.InsertData(
                table: "languages",
                columns: new[] { "LanguageId", "CreatedBy", "CreatedOn", "IsActive", "LanguageName", "PersonalDetailsId", "Read", "Speak", "UpdatedBy", "UpdatedOn", "Write" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 6, 30, 9, 12, 10, 652, DateTimeKind.Local).AddTicks(2521), true, "English", 1, true, true, null, null, true },
                    { 2, null, new DateTime(2022, 6, 30, 9, 12, 10, 652, DateTimeKind.Local).AddTicks(2533), true, "Tamil", 2, true, true, null, null, true },
                    { 3, null, new DateTime(2022, 6, 30, 9, 12, 10, 652, DateTimeKind.Local).AddTicks(2534), true, "Hindi", 3, true, true, null, null, true },
                    { 4, null, new DateTime(2022, 6, 30, 9, 12, 10, 652, DateTimeKind.Local).AddTicks(2535), true, "Telugu", 4, true, true, null, null, true },
                    { 5, null, new DateTime(2022, 6, 30, 9, 12, 10, 652, DateTimeKind.Local).AddTicks(2536), true, "Malayalam", 5, true, true, null, null, true },
                    { 6, null, new DateTime(2022, 6, 30, 9, 12, 10, 652, DateTimeKind.Local).AddTicks(2537), true, "Kannada", 3, true, true, null, null, true },
                    { 7, null, new DateTime(2022, 6, 30, 9, 12, 10, 652, DateTimeKind.Local).AddTicks(2538), true, "Bengali", 4, true, true, null, null, true },
                    { 8, null, new DateTime(2022, 6, 30, 9, 12, 10, 652, DateTimeKind.Local).AddTicks(2539), true, "Marathi", 3, true, true, null, null, true },
                    { 9, null, new DateTime(2022, 6, 30, 9, 12, 10, 652, DateTimeKind.Local).AddTicks(2540), true, "Urdu", 1, true, true, null, null, true },
                    { 10, null, new DateTime(2022, 6, 30, 9, 12, 10, 652, DateTimeKind.Local).AddTicks(2541), true, "French", 2, true, true, null, null, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 1);

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
                table: "Gender",
                keyColumn: "GenderId",
                keyValue: 3);

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
                table: "achievements",
                keyColumn: "AchievementId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "achievements",
                keyColumn: "AchievementId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "achievements",
                keyColumn: "AchievementId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "achievements",
                keyColumn: "AchievementId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "achievements",
                keyColumn: "AchievementId",
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
                table: "profilehistory",
                keyColumn: "ProfileHistoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "profilehistory",
                keyColumn: "ProfileHistoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "profilehistory",
                keyColumn: "ProfileHistoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "profilehistory",
                keyColumn: "ProfileHistoryId",
                keyValue: 4);

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

            migrationBuilder.DeleteData(
                table: "AchievementType",
                keyColumn: "AchievementTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AchievementType",
                keyColumn: "AchievementTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "CollegeId",
                keyValue: 10);

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
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "profile",
                keyColumn: "ProfileId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "UserId",
                keyValue: 1);

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

            migrationBuilder.DeleteData(
                table: "CountryCodes",
                keyColumn: "CountryCodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CountryCodes",
                keyColumn: "CountryCodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "DesignationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "GenderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "GenderId",
                keyValue: 2);

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

            migrationBuilder.DropColumn(
                name: "EndingDuration",
                table: "breakDurations");

            migrationBuilder.DropColumn(
                name: "StartingDuration",
                table: "breakDurations");

            migrationBuilder.AddColumn<string>(
                name: "EndingBreakMonth",
                table: "breakDurations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EndingBreakYear",
                table: "breakDurations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartingBreakMonth",
                table: "breakDurations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StartingBreakYear",
                table: "breakDurations",
                type: "int",
                nullable: true);
        }
    }
}
