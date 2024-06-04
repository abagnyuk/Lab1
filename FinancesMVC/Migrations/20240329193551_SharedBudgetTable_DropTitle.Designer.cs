﻿// <auto-generated />
using System;
using FinancesMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinancesMVC.Migrations
{
    [DbContext(typeof(Db1Context))]
    [Migration("20240329193551_SharedBudgetTable_DropTitle")]
    partial class SharedBudgetTable_DropTitle
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinancesMVC.Models.Achievement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("status");

                    b.Property<string>("Text")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("text");

                    b.HasKey("Id")
                        .HasName("PK__achievem__3213E83F0637D22E");

                    b.ToTable("achievements", (string)null);
                });

            modelBuilder.Entity("FinancesMVC.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("ExpenditureLimit")
                        .IsRequired()
                        .HasColumnType("float")
                        .HasColumnName("expenditureLimit");

                    b.Property<bool>("IsParentControl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("isParentControl");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("name");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("userId");

                    b.HasKey("Id")
                        .HasName("PK__categori__3213E83F930CEC60");

                    b.HasIndex("UserId");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("FinancesMVC.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Text")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("text");

                    b.Property<string>("Type")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("type");

                    b.HasKey("Id")
                        .HasName("PK__messages__3213E83F01993062");

                    b.HasIndex(new[] { "Type" }, "UQ__messages__E3F852480E6B4C46")
                        .IsUnique()
                        .HasFilter("[type] IS NOT NULL");

                    b.ToTable("messages", (string)null);
                });

            modelBuilder.Entity("FinancesMVC.Models.SharedBudget", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddedUsersId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("addedUserId");

                    b.Property<int>("CommonCategoryId")
                        .HasColumnType("int")
                        .HasColumnName("commonCategoryId");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id")
                        .HasName("PK__shared_b__3213E83F19DEC5E4");

                    b.HasIndex("CommonCategoryId");

                    b.HasIndex("OwnerId");

                    b.ToTable("sharedBudget", (string)null);
                });

            modelBuilder.Entity("FinancesMVC.Models.Stat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("CalculatedExpances")
                        .HasColumnType("float")
                        .HasColumnName("calculatedExpances");

                    b.Property<int?>("ChosenCategoryId")
                        .HasColumnType("int")
                        .HasColumnName("chosenCategoryId");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("endTime");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("startTime");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("userId");

                    b.HasKey("Id")
                        .HasName("PK__stats__3213E83F27BC9641");

                    b.HasIndex("ChosenCategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("stats", (string)null);
                });

            modelBuilder.Entity("FinancesMVC.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("BudgetOverflown")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("budgetOverflown");

                    b.Property<int?>("CompletedAchievementId")
                        .HasColumnType("int")
                        .HasColumnName("completedAchievementId");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("date");

                    b.Property<int?>("ExpenditureCategoryId")
                        .HasColumnType("int")
                        .HasColumnName("expenditureCategoryId");

                    b.Property<string>("ExpenditureNote")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("expenditureNote");

                    b.Property<int?>("MessageId")
                        .HasColumnType("int")
                        .HasColumnName("messageId");

                    b.Property<decimal>("MoneySpent")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("moneySpent");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("userId");

                    b.HasKey("Id")
                        .HasName("PK__transact__3213E83FC90F2F93");

                    b.HasIndex("CompletedAchievementId");

                    b.HasIndex("ExpenditureCategoryId");

                    b.HasIndex("MessageId");

                    b.HasIndex("UserId");

                    b.ToTable("transactions", (string)null);
                });

            modelBuilder.Entity("FinancesMVC.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("BirthYear")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("createdAt");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMature")
                        .HasColumnType("bit")
                        .HasColumnName("isMature");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("PK__users__3213E83F0DCBB468");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("FinancesMVC.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AboutMe")
                        .HasColumnType("text")
                        .HasColumnName("aboutMe");

                    b.Property<DateOnly?>("Birthdate")
                        .HasColumnType("date")
                        .HasColumnName("birthdate");

                    b.Property<string>("Country")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("country");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("firstName");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("lastName");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("userId");

                    b.HasKey("Id")
                        .HasName("PK__UserProf__3213E83F7E505319");

                    b.HasIndex(new[] { "Id" }, "UQ_UserProfiles_id")
                        .IsUnique();

                    b.HasIndex(new[] { "UserId" }, "UQ_UserProfiles_userId")
                        .IsUnique()
                        .HasFilter("[userId] IS NOT NULL");

                    b.ToTable("userProfiles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FinancesMVC.Models.Category", b =>
                {
                    b.HasOne("FinancesMVC.Models.User", "User")
                        .WithMany("Categories")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__categorie__userI__4D94879B");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FinancesMVC.Models.SharedBudget", b =>
                {
                    b.HasOne("FinancesMVC.Models.Category", "CommonCategory")
                        .WithMany("SharedBudgets")
                        .HasForeignKey("CommonCategoryId")
                        .IsRequired()
                        .HasConstraintName("FK_sharedBudget_categories");

                    b.HasOne("FinancesMVC.Models.User", "OwnerUser")
                        .WithMany("SharedBudgets")
                        .HasForeignKey("OwnerId")
                        .IsRequired()
                        .HasConstraintName("FK_sharedBudget_OwnerUser");

                    b.Navigation("CommonCategory");

                    b.Navigation("OwnerUser");
                });

            modelBuilder.Entity("FinancesMVC.Models.Stat", b =>
                {
                    b.HasOne("FinancesMVC.Models.Category", "ChosenCategory")
                        .WithMany("Stats")
                        .HasForeignKey("ChosenCategoryId")
                        .HasConstraintName("FK__stats__chosenCat__46E78A0C");

                    b.HasOne("FinancesMVC.Models.User", "User")
                        .WithMany("Stats")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__stats__userId__4CA06362");

                    b.Navigation("ChosenCategory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FinancesMVC.Models.Transaction", b =>
                {
                    b.HasOne("FinancesMVC.Models.Achievement", "CompletedAchievement")
                        .WithMany("Transactions")
                        .HasForeignKey("CompletedAchievementId")
                        .HasConstraintName("FK_transactions_achievements");

                    b.HasOne("FinancesMVC.Models.Category", "ExpenditureCategory")
                        .WithMany("Transactions")
                        .HasForeignKey("ExpenditureCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK__transacti__expen__4BAC3F29");

                    b.HasOne("FinancesMVC.Models.Message", "Message")
                        .WithMany("Transactions")
                        .HasForeignKey("MessageId")
                        .HasConstraintName("FK_transactions_messages");

                    b.HasOne("FinancesMVC.Models.User", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__transacti__userI__48CFD27E");

                    b.Navigation("CompletedAchievement");

                    b.Navigation("ExpenditureCategory");

                    b.Navigation("Message");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FinancesMVC.Models.UserProfile", b =>
                {
                    b.HasOne("FinancesMVC.Models.User", "User")
                        .WithOne("UserProfile")
                        .HasForeignKey("FinancesMVC.Models.UserProfile", "UserId")
                        .HasConstraintName("FK_UserProfiles_Users");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("FinancesMVC.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("FinancesMVC.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinancesMVC.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("FinancesMVC.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinancesMVC.Models.Achievement", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("FinancesMVC.Models.Category", b =>
                {
                    b.Navigation("SharedBudgets");

                    b.Navigation("Stats");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("FinancesMVC.Models.Message", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("FinancesMVC.Models.User", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("SharedBudgets");

                    b.Navigation("Stats");

                    b.Navigation("Transactions");

                    b.Navigation("UserProfile");
                });
#pragma warning restore 612, 618
        }
    }
}
