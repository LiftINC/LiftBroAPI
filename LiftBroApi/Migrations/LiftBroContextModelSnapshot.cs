﻿// <auto-generated />
using LiftBroAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace LiftBroApi.Migrations
{
    [DbContext(typeof(LiftBroContext))]
    partial class LiftBroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("LiftBroAPI.Entities.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("LiftBroAPI.Entities.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ActivityId");

                    b.Property<int>("Repitations");

                    b.Property<int>("Sets");

                    b.Property<double>("Weight");

                    b.Property<int?>("WorkoutId");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("LiftBroAPI.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LiftBroAPI.Entities.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Workout");
                });

            modelBuilder.Entity("LiftBroAPI.Entities.Exercise", b =>
                {
                    b.HasOne("LiftBroAPI.Entities.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId");

                    b.HasOne("LiftBroAPI.Entities.Workout")
                        .WithMany("Exercises")
                        .HasForeignKey("WorkoutId");
                });

            modelBuilder.Entity("LiftBroAPI.Entities.Workout", b =>
                {
                    b.HasOne("LiftBroAPI.Entities.User")
                        .WithMany("Workouts")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
