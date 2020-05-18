﻿// <auto-generated />
using System;
using DogsIRL_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DogsIRL_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200518215436_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DogsIRL_API.Models.PetCard", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgeYears")
                        .HasColumnType("int");

                    b.Property<short>("Appetite")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<short>("Bravery")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("DateCollected")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<short>("Energy")
                        .HasColumnType("smallint");

                    b.Property<short>("Floofiness")
                        .HasColumnType("smallint");

                    b.Property<short>("GoodDog")
                        .HasColumnType("smallint");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Snuggles")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.ToTable("PetCards");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AgeYears = 2,
                            Appetite = (short)8,
                            Birthday = new DateTime(2018, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Bravery = (short)9,
                            DateCollected = new DateTime(2020, 5, 18, 14, 54, 35, 993, DateTimeKind.Local).AddTicks(8350),
                            DateCreated = new DateTime(2020, 5, 18, 14, 54, 35, 978, DateTimeKind.Local).AddTicks(6240),
                            Energy = (short)8,
                            Floofiness = (short)1,
                            GoodDog = (short)8,
                            ImageURL = "",
                            Name = "Tucker",
                            Owner = "andrewbc",
                            Sex = "Male",
                            Snuggles = (short)8
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
