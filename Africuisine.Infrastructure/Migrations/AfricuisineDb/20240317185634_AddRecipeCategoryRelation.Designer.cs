﻿// <auto-generated />
using System;
using Africuisine.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Africuisine.Infrastructure.Migrations.AfricuisineDb
{
    [DbContext(typeof(AfricuisineDbContext))]
    [Migration("20240317185634_AddRecipeCategoryRelation")]
    partial class AddRecipeCategoryRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Africuisine.Domain.Entities.Ingredients.IngredientCategory", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Creation")
                        .HasColumnType("datetime2");

                    b.Property<string>("LUserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SeqNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("IX_IngredientCategories_Name");

                    b.ToTable("IngredientCategories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c5ed7f3d-186a-4cc5-b4bb-4fdeded6df52",
                            Creation = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1137),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1146),
                            Name = "Proteins",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "bf21bc90-62a3-4896-b98c-2f30eaafdf9d",
                            Creation = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1212),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1213),
                            Name = "Vegetables And Herbs",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "3d989f92-2cae-48ea-bfb9-c732c16768f2",
                            Creation = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1220),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1220),
                            Name = "Fruits",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "be8e9c13-9884-4f6f-995e-51737dcbfa74",
                            Creation = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1234),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1234),
                            Name = "Grains And Starches",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "89b581c2-3fe6-4877-abdf-a492b70f46d9",
                            Creation = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1249),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1249),
                            Name = "Dairy And Dairy Alternatives",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "5e61ae3f-2baa-4229-a870-20eea0c949b6",
                            Creation = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1275),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1275),
                            Name = "Condiments And Sauces",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "bf6fe9db-ef42-44d5-a763-c86a7bfd6b7c",
                            Creation = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1288),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1289),
                            Name = "Spices And Seasonings",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "f8b5a6c0-f3ad-4ae6-8c9e-d147d3f691c3",
                            Creation = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1298),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1298),
                            Name = "Baking Ingredients",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "8eda88d4-d3ea-4eba-b607-a9b02f7ba346",
                            Creation = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1310),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1310),
                            Name = "Nuts And Seeds",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "e2dee698-4b1f-495b-a1ff-e4c5bd6c9343",
                            Creation = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1317),
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(1317),
                            Name = "Beverages",
                            SeqNo = 0
                        });
                });

            modelBuilder.Entity("Africuisine.Domain.Entities.Ingredients.Measurement", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Abbreviation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Creation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LUserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SeqNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("IX_Measurements_Name");

                    b.ToTable("Measurements", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "daa2a106-c8f4-45db-a805-ea50d4449080",
                            Abbreviation = "ml",
                            Creation = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(2123),
                            Description = "Used for liquids, such as water, milk, and oil",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(2125),
                            Name = "Milliliter",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "d7e8d50f-366f-4ee0-b5ea-a4eef97521ad",
                            Abbreviation = "l",
                            Creation = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(2131),
                            Description = "Larger volume measurements, often used for bulk liquids.",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(2131),
                            Name = "Liters",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "aa14a336-b711-463d-8a90-aa9d74e0c0d4",
                            Abbreviation = "g",
                            Creation = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(2136),
                            Description = "Common unit for measuring dry ingredients like flour, sugar, and spices.",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(2136),
                            Name = "Grams",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "480e6333-c9ce-446d-9df2-b4665fca713b",
                            Abbreviation = "kg",
                            Creation = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(2145),
                            Description = "Larger mass measurements, especially for bulk ingredients.",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(2146),
                            Name = "Kilograms",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "1493ae77-5d25-4933-834c-c639c8282fb7",
                            Abbreviation = "tsp.",
                            Creation = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(2149),
                            Description = "Approximately 5 ml.",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(2150),
                            Name = "Teaspoon",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "62d912ca-8922-4b02-b224-7b72ccd4b295",
                            Abbreviation = "Tbsp",
                            Creation = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(2155),
                            Description = "Approximately 15 ml.",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(2155),
                            Name = "Tablespoon",
                            SeqNo = 0
                        },
                        new
                        {
                            Id = "06259263-5102-4234-8972-8c8e7c1ccd0c",
                            Abbreviation = "250 ml",
                            Creation = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(2213),
                            Description = "Used for both liquid and dry ingredients.",
                            LUserUpdate = "",
                            LastUpdate = new DateTime(2024, 3, 17, 20, 56, 34, 740, DateTimeKind.Local).AddTicks(2214),
                            Name = "Cup",
                            SeqNo = 0
                        });
                });

            modelBuilder.Entity("Africuisine.Domain.Entities.Recipes.RecipeCategory", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
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

                    b.ToTable("RecipeCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
