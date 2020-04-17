﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectAthena.Data;

namespace ProjectAthena.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200410063541_ReportLastEditDate")]
    partial class ReportLastEditDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ProjectAthena.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ManagerID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<bool>("UserActive")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ProjectAthena.Models.Campaign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CampaignActive")
                        .HasColumnType("bit");

                    b.Property<string>("DataColumn10Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumn1Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumn2Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumn3Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumn4Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumn5Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumn6Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumn7Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumn8Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumn9Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnATitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnBTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnCTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnDTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnETitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnFTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnGTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnHTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnITitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnJTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManagerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberDataColumnCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TextDataColumnCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Campaign");
                });

            modelBuilder.Entity("ProjectAthena.Models.CampaignUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicationUserFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CampaignId")
                        .HasColumnType("int");

                    b.Property<string>("CampaignName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CampaignId");

                    b.ToTable("CampaignUser");
                });

            modelBuilder.Entity("ProjectAthena.Models.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicationUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CampaignId")
                        .HasColumnType("int");

                    b.Property<string>("CampaignName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DataColumn1")
                        .HasColumnType("int");

                    b.Property<int>("DataColumn10")
                        .HasColumnType("int");

                    b.Property<int>("DataColumn2")
                        .HasColumnType("int");

                    b.Property<int>("DataColumn3")
                        .HasColumnType("int");

                    b.Property<int>("DataColumn4")
                        .HasColumnType("int");

                    b.Property<int>("DataColumn5")
                        .HasColumnType("int");

                    b.Property<int>("DataColumn6")
                        .HasColumnType("int");

                    b.Property<int>("DataColumn7")
                        .HasColumnType("int");

                    b.Property<int>("DataColumn8")
                        .HasColumnType("int");

                    b.Property<int>("DataColumn9")
                        .HasColumnType("int");

                    b.Property<string>("DataColumnA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataColumnJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastEditDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ManagerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SubmissionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CampaignId");

                    b.ToTable("Report");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ProjectAthena.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ProjectAthena.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAthena.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ProjectAthena.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectAthena.Models.CampaignUser", b =>
                {
                    b.HasOne("ProjectAthena.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("ProjectAthena.Models.Campaign", "Campaign")
                        .WithMany()
                        .HasForeignKey("CampaignId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectAthena.Models.Report", b =>
                {
                    b.HasOne("ProjectAthena.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("ProjectAthena.Models.Campaign", "Campaign")
                        .WithMany()
                        .HasForeignKey("CampaignId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
