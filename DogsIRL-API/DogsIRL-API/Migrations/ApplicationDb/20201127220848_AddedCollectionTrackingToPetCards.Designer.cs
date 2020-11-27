﻿// <auto-generated />
using System;
using DogsIRL_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DogsIRL_API.Migrations.ApplicationDb
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201127220848_AddedCollectionTrackingToPetCards")]
    partial class AddedCollectionTrackingToPetCards
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DogsIRL_API.Models.CollectedPetCard", b =>
                {
                    b.Property<int>("PetCardID")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PetCardID", "Username");

                    b.ToTable("CollectedPetCards");
                });

            modelBuilder.Entity("DogsIRL_API.Models.Interaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConversationLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GoodbyeLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GoodbyeLineOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningLineOther")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Interactions");
                });

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

                    b.Property<int>("Collections")
                        .HasColumnType("int");

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
                            Collections = 0,
                            DateCollected = new DateTime(2020, 11, 27, 14, 8, 47, 761, DateTimeKind.Local).AddTicks(6328),
                            DateCreated = new DateTime(2020, 11, 27, 14, 8, 47, 758, DateTimeKind.Local).AddTicks(1641),
                            Energy = (short)8,
                            Floofiness = (short)1,
                            GoodDog = (short)8,
                            ImageURL = "https://dogsirl.blob.core.windows.net/dogs/Tucker.png",
                            Name = "Tucker",
                            Owner = "andrewbc",
                            Sex = "Male",
                            Snuggles = (short)8
                        });
                });

            modelBuilder.Entity("DogsIRL_API.Models.CollectedPetCard", b =>
                {
                    b.HasOne("DogsIRL_API.Models.PetCard", "PetCard")
                        .WithMany()
                        .HasForeignKey("PetCardID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
