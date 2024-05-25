﻿// <auto-generated />
using System;
using Africuisine.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Africuisine.Infrastructure.Migrations
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20240303200227_InitializeDatabase")]
    partial class InitializeDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Africuisine.Domain.Entities.User.CulturalGroup", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Creation")
                        .HasColumnType("datetime2");

                    b.Property<string>("LUserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeqNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CulturalGroups", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3541bf74-89df-4c4d-af2e-59c6cfe36b7b",
                            Creation = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2631),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2632),
                            Name = "Zulu",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "1d6238b4-5044-4231-b04d-1d5c86efd60f",
                            Creation = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2636),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2636),
                            Name = "Xhosa",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "9e1aebc8-1729-4c22-8e46-91f8e67b6409",
                            Creation = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2639),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2639),
                            Name = "Tswana",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "02d4db1b-3317-4d12-a8ed-6c46f773c052",
                            Creation = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2652),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2652),
                            Name = "Sotho",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "3d8c07ce-066e-47bd-af20-7fdb08e726db",
                            Creation = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2654),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2654),
                            Name = "Swazi",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "86cd9dd1-5e5e-45c5-841f-71afa4fc1615",
                            Creation = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2658),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2658),
                            Name = "Venda",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "9a5d85f7-8461-4a6c-b3eb-0f37f368dd2f",
                            Creation = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2660),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2661),
                            Name = "Tsonga",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "7b12fec3-cba8-4ae9-bc8d-41ad4d9e435b",
                            Creation = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2663),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2663),
                            Name = "Ndebele",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "0e6905f3-0426-4379-ba47-9a9e41e68529",
                            Creation = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2665),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2665),
                            Name = "BaPedi",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "c3078d6c-d38d-4af2-b338-4827fe3c692a",
                            Creation = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2668),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2668),
                            Name = "Khoisan",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "08a2421e-ddd6-431b-ae6f-815158f24c17",
                            Creation = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2670),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2671),
                            Name = "Griqua",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "8a76ab46-3d31-4c94-9576-626240339d12",
                            Creation = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2675),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2675),
                            Name = "Coloured",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "5feafb11-ccae-4d67-b9c3-b9d3982c6890",
                            Creation = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2677),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2677),
                            Name = "Indian",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "0020e6c2-cae2-4e2f-9a95-1701706c0da7",
                            Creation = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2679),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2679),
                            Name = "English",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "ceef2312-f9aa-4d07-b68a-2d2ebfe16188",
                            Creation = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2682),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(2682),
                            Name = "Afrikaaner",
                            SeqNo = 0
                        });
                });

            modelBuilder.Entity("Africuisine.Domain.Entities.User.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Creation")
                        .HasColumnType("datetime2");

                    b.Property<string>("LUserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("SeqNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "166c241b-1f3a-43b7-95d8-867e18b399c8",
                            ConcurrencyStamp = "91e143db-2107-4859-961f-0db5c0d63c26",
                            Creation = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(1821),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(1823),
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "f471b403-1802-496d-bf24-e87e11d0ff7b",
                            ConcurrencyStamp = "4c2e2ea4-f118-46ff-ad67-5b9c40d0d4ea",
                            Creation = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(1882),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 3, 20, 2, 26, 909, DateTimeKind.Utc).AddTicks(1882),
                            Name = "Mobile",
                            NormalizedName = "MOBILE",
                            SeqNo = 0
                        });
                });

            modelBuilder.Entity("Africuisine.Domain.Entities.User.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Africuisine.Domain.Entities.User.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Creation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("LCulturalGroup")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LUserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int>("SeqNo")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("LCulturalGroup");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("IX_Users_UserName")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Africuisine.Domain.Entities.User.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Africuisine.Domain.Entities.User.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Africuisine.Domain.Entities.User.UserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("Africuisine.Domain.Entities.User.UserToken", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Name")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserToken", (string)null);
                });

            modelBuilder.Entity("Africuisine.Domain.Entities.Users.Profile", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Creation")
                        .HasColumnType("datetime2");

                    b.Property<string>("LUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LUserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SeqNo")
                        .HasColumnType("int");

                    b.Property<string>("Uri")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Id", "LUser");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Africuisine.Domain.Entities.User.RoleClaim", b =>
                {
                    b.HasOne("Africuisine.Domain.Entities.User.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Africuisine.Domain.Entities.User.User", b =>
                {
                    b.HasOne("Africuisine.Domain.Entities.User.CulturalGroup", null)
                        .WithMany()
                        .HasForeignKey("LCulturalGroup");
                });

            modelBuilder.Entity("Africuisine.Domain.Entities.User.UserClaim", b =>
                {
                    b.HasOne("Africuisine.Domain.Entities.User.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Africuisine.Domain.Entities.User.UserLogin", b =>
                {
                    b.HasOne("Africuisine.Domain.Entities.User.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Africuisine.Domain.Entities.User.UserRole", b =>
                {
                    b.HasOne("Africuisine.Domain.Entities.User.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Africuisine.Domain.Entities.User.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Africuisine.Domain.Entities.User.UserToken", b =>
                {
                    b.HasOne("Africuisine.Domain.Entities.User.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
