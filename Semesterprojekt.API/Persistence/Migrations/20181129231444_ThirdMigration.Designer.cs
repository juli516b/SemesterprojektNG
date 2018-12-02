﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Semesterprojekt.Persistence;

namespace Semesterprojekt.Migrations
{
    [DbContext(typeof(GoTrainDbContext))]
    [Migration("20181129231444_ThirdMigration")]
    partial class ThirdMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Semesterprojekt.Core.Entites.TrainingSession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("TrainingSessions");
                });

            modelBuilder.Entity("Semesterprojekt.Core.Entites.Trophy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("Goal");

                    b.Property<string>("Name")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Trophies");
                });

            modelBuilder.Entity("Semesterprojekt.Core.Entites.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<int>("PhoneNumber");

                    b.Property<string>("UserName");

                    b.Property<int>("ZipCode")
                        .HasMaxLength(4);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Semesterprojekt.Core.Entites.UserTrainingSession", b =>
                {
                    b.Property<int>("TrainingSessionId");

                    b.Property<int>("UserId");

                    b.HasKey("TrainingSessionId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserTrainingSessions");
                });

            modelBuilder.Entity("Semesterprojekt.Core.Entites.UserTrophy", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("TrophyId");

                    b.Property<int>("Counter");

                    b.HasKey("UserId", "TrophyId");

                    b.HasIndex("TrophyId");

                    b.ToTable("UserTrophies");
                });

            modelBuilder.Entity("Semesterprojekt.Core.Entites.UserTrainingSession", b =>
                {
                    b.HasOne("Semesterprojekt.Core.Entites.TrainingSession", "TrainingSession")
                        .WithMany("UserTrainingSessions")
                        .HasForeignKey("TrainingSessionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Semesterprojekt.Core.Entites.User", "User")
                        .WithMany("UserTrainingSessions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Semesterprojekt.Core.Entites.UserTrophy", b =>
                {
                    b.HasOne("Semesterprojekt.Core.Entites.Trophy", "Trophy")
                        .WithMany("UserTrophies")
                        .HasForeignKey("TrophyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Semesterprojekt.Core.Entites.User", "User")
                        .WithMany("UserTrophies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
