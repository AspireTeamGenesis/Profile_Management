﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PMS_API;

#nullable disable

namespace PMS_API.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220622050959_first3")]
    partial class first3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PMS_API.Achievements", b =>
                {
                    b.Property<int>("AchievementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AchievementId"), 1L, 1);

                    b.Property<int>("AchievementTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("base64header")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AchievementId");

                    b.HasIndex("AchievementTypeId");

                    b.HasIndex("ProfileId");

                    b.ToTable("achievements");
                });

            modelBuilder.Entity("PMS_API.AchievementType", b =>
                {
                    b.Property<int>("AchievementTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AchievementTypeId"), 1L, 1);

                    b.Property<string>("AchievementTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("AchievementTypeId");

                    b.ToTable("AchievementType");
                });

            modelBuilder.Entity("PMS_API.BreakDuration", b =>
                {
                    b.Property<int>("BreakDuration_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BreakDuration_Id"), 1L, 1);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("EndingBreakMonth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EndingBreakYear")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("PersonalDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("StartingBreakMonth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StartingBreakYear")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("BreakDuration_Id");

                    b.HasIndex("PersonalDetailsId");

                    b.ToTable("breakDurations");
                });

            modelBuilder.Entity("PMS_API.College", b =>
                {
                    b.Property<int>("CollegeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CollegeId"), 1L, 1);

                    b.Property<string>("CollegeName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("CollegeId");

                    b.ToTable("Colleges");
                });

            modelBuilder.Entity("PMS_API.CountryCode", b =>
                {
                    b.Property<int>("CountryCodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryCodeId"), 1L, 1);

                    b.Property<string>("CountryCodeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("CountryCodeId");

                    b.ToTable("CountryCodes");
                });

            modelBuilder.Entity("PMS_API.Designation", b =>
                {
                    b.Property<int>("DesignationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DesignationId"), 1L, 1);

                    b.Property<string>("DesignationName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("DesignationId");

                    b.ToTable("Designations");
                });

            modelBuilder.Entity("PMS_API.Domain", b =>
                {
                    b.Property<int>("DomainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DomainId"), 1L, 1);

                    b.Property<string>("DomainName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("TechnologyId")
                        .HasColumnType("int");

                    b.HasKey("DomainId");

                    b.HasIndex("TechnologyId");

                    b.ToTable("Domains");
                });

            modelBuilder.Entity("PMS_API.Education", b =>
                {
                    b.Property<int>("EducationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EducationId"), 1L, 1);

                    b.Property<string>("Course")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Ending")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<float>("Percentage")
                        .HasColumnType("real");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int?>("Starting")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("collegeid")
                        .HasColumnType("int");

                    b.HasKey("EducationId");

                    b.HasIndex("ProfileId");

                    b.HasIndex("collegeid");

                    b.ToTable("educations");
                });

            modelBuilder.Entity("PMS_API.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenderId"), 1L, 1);

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("GenderId");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("PMS_API.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LanguageId"), 1L, 1);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalDetailsId")
                        .HasColumnType("int");

                    b.Property<bool>("Read")
                        .HasColumnType("bit");

                    b.Property<bool>("Speak")
                        .HasColumnType("bit");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Write")
                        .HasColumnType("bit");

                    b.HasKey("LanguageId");

                    b.HasIndex("PersonalDetailsId");

                    b.ToTable("languages");
                });

            modelBuilder.Entity("PMS_API.Organisation", b =>
                {
                    b.Property<int>("OrganisationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrganisationId"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("OrganisationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrganisationId");

                    b.ToTable("Organisations");
                });

            modelBuilder.Entity("PMS_API.PersonalDetails", b =>
                {
                    b.Property<int>("PersonalDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonalDetailsId"), 1L, 1);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfJoining")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Objective")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("base64header")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonalDetailsId");

                    b.HasIndex("ProfileId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("personalDetails");
                });

            modelBuilder.Entity("PMS_API.Profile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfileId"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ProfileStatusId")
                        .HasColumnType("int");

                    b.HasKey("ProfileId");

                    b.HasIndex("ProfileStatusId");

                    b.ToTable("profile");
                });

            modelBuilder.Entity("PMS_API.ProfileHistory", b =>
                {
                    b.Property<int>("ProfileHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfileHistoryId"), 1L, 1);

                    b.Property<DateTime>("ApprovedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.HasKey("ProfileHistoryId");

                    b.HasIndex("ProfileId");

                    b.ToTable("profilehistory");
                });

            modelBuilder.Entity("PMS_API.ProfileStatus", b =>
                {
                    b.Property<int>("ProfileStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfileStatusId"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ProfileStatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfileStatusId");

                    b.ToTable("ProfileStatuss");
                });

            modelBuilder.Entity("PMS_API.Projects", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"), 1L, 1);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndingMonth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EndingYear")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<string>("ProjectDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartingMonth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StartingYear")
                        .HasColumnType("int");

                    b.Property<string>("ToolsUsed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ProjectId");

                    b.HasIndex("ProfileId");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("PMS_API.Skills", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkillId"), 1L, 1);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("DomainId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("SkillId");

                    b.HasIndex("DomainId");

                    b.HasIndex("ProfileId");

                    b.ToTable("skills");
                });

            modelBuilder.Entity("PMS_API.SocialMedia", b =>
                {
                    b.Property<int>("SocialMedia_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SocialMedia_Id"), 1L, 1);

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("PersonalDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("SocialMedia_Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialMedia_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("SocialMedia_Id");

                    b.HasIndex("PersonalDetailsId");

                    b.ToTable("SocialMedias");
                });

            modelBuilder.Entity("PMS_API.Technology", b =>
                {
                    b.Property<int>("TechnologyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TechnologyId"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("TechnologyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TechnologyId");

                    b.ToTable("Technologies");
                });

            modelBuilder.Entity("PMS_API.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<int?>("CountryCodeId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("DesignationId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganisationId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportingPersonUsername")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("CountryCodeId");

                    b.HasIndex("DesignationId");

                    b.HasIndex("GenderId");

                    b.HasIndex("OrganisationId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("PMS_API.Achievements", b =>
                {
                    b.HasOne("PMS_API.AchievementType", "achievementtype")
                        .WithMany("achievements")
                        .HasForeignKey("AchievementTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS_API.Profile", "profile")
                        .WithMany("achievements")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("achievementtype");

                    b.Navigation("profile");
                });

            modelBuilder.Entity("PMS_API.BreakDuration", b =>
                {
                    b.HasOne("PMS_API.PersonalDetails", "personalDetails")
                        .WithMany("breakDuration")
                        .HasForeignKey("PersonalDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("personalDetails");
                });

            modelBuilder.Entity("PMS_API.Domain", b =>
                {
                    b.HasOne("PMS_API.Technology", "technology")
                        .WithMany("domains")
                        .HasForeignKey("TechnologyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("technology");
                });

            modelBuilder.Entity("PMS_API.Education", b =>
                {
                    b.HasOne("PMS_API.Profile", "profile")
                        .WithMany("education")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS_API.College", "college")
                        .WithMany("education")
                        .HasForeignKey("collegeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("college");

                    b.Navigation("profile");
                });

            modelBuilder.Entity("PMS_API.Language", b =>
                {
                    b.HasOne("PMS_API.PersonalDetails", "personalDetails")
                        .WithMany("language")
                        .HasForeignKey("PersonalDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("personalDetails");
                });

            modelBuilder.Entity("PMS_API.PersonalDetails", b =>
                {
                    b.HasOne("PMS_API.Profile", "profile")
                        .WithOne("personalDetails")
                        .HasForeignKey("PMS_API.PersonalDetails", "ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS_API.User", "users")
                        .WithOne("personalDetails")
                        .HasForeignKey("PMS_API.PersonalDetails", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("profile");

                    b.Navigation("users");
                });

            modelBuilder.Entity("PMS_API.Profile", b =>
                {
                    b.HasOne("PMS_API.ProfileStatus", "profilestatus")
                        .WithMany()
                        .HasForeignKey("ProfileStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("profilestatus");
                });

            modelBuilder.Entity("PMS_API.ProfileHistory", b =>
                {
                    b.HasOne("PMS_API.Profile", "profile")
                        .WithMany()
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("profile");
                });

            modelBuilder.Entity("PMS_API.Projects", b =>
                {
                    b.HasOne("PMS_API.Profile", "profile")
                        .WithMany("projects")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("profile");
                });

            modelBuilder.Entity("PMS_API.Skills", b =>
                {
                    b.HasOne("PMS_API.Domain", "domain")
                        .WithMany("skills")
                        .HasForeignKey("DomainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS_API.Profile", "profile")
                        .WithMany("skills")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("domain");

                    b.Navigation("profile");
                });

            modelBuilder.Entity("PMS_API.SocialMedia", b =>
                {
                    b.HasOne("PMS_API.PersonalDetails", "personalDetails")
                        .WithMany("socialmedia")
                        .HasForeignKey("PersonalDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("personalDetails");
                });

            modelBuilder.Entity("PMS_API.User", b =>
                {
                    b.HasOne("PMS_API.CountryCode", "countrycode")
                        .WithMany("users")
                        .HasForeignKey("CountryCodeId");

                    b.HasOne("PMS_API.Designation", "designation")
                        .WithMany("users")
                        .HasForeignKey("DesignationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS_API.Gender", "gender")
                        .WithMany("users")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS_API.Organisation", "organisation")
                        .WithMany("users")
                        .HasForeignKey("OrganisationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("countrycode");

                    b.Navigation("designation");

                    b.Navigation("gender");

                    b.Navigation("organisation");
                });

            modelBuilder.Entity("PMS_API.AchievementType", b =>
                {
                    b.Navigation("achievements");
                });

            modelBuilder.Entity("PMS_API.College", b =>
                {
                    b.Navigation("education");
                });

            modelBuilder.Entity("PMS_API.CountryCode", b =>
                {
                    b.Navigation("users");
                });

            modelBuilder.Entity("PMS_API.Designation", b =>
                {
                    b.Navigation("users");
                });

            modelBuilder.Entity("PMS_API.Domain", b =>
                {
                    b.Navigation("skills");
                });

            modelBuilder.Entity("PMS_API.Gender", b =>
                {
                    b.Navigation("users");
                });

            modelBuilder.Entity("PMS_API.Organisation", b =>
                {
                    b.Navigation("users");
                });

            modelBuilder.Entity("PMS_API.PersonalDetails", b =>
                {
                    b.Navigation("breakDuration");

                    b.Navigation("language");

                    b.Navigation("socialmedia");
                });

            modelBuilder.Entity("PMS_API.Profile", b =>
                {
                    b.Navigation("achievements");

                    b.Navigation("education");

                    b.Navigation("personalDetails");

                    b.Navigation("projects");

                    b.Navigation("skills");
                });

            modelBuilder.Entity("PMS_API.Technology", b =>
                {
                    b.Navigation("domains");
                });

            modelBuilder.Entity("PMS_API.User", b =>
                {
                    b.Navigation("personalDetails");
                });
#pragma warning restore 612, 618
        }
    }
}