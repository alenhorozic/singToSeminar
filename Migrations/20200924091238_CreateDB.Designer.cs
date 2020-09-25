﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using singToSeminar.Context;

namespace singToSeminar.Migrations
{
    [DbContext(typeof(ApplikationDbContext))]
    [Migration("20200924091238_CreateDB")]
    partial class CreateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

            modelBuilder.Entity("singToSeminar.Context.Booking", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("seminarId")
                        .HasColumnType("int");

                    b.Property<string>("surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("seminarId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("singToSeminar.Context.Seminar", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dateAndTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("durationTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numberOfSeats")
                        .HasColumnType("int");

                    b.Property<string>("sal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("speaker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("topic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Seminars");
                });

            modelBuilder.Entity("singToSeminar.Context.Booking", b =>
                {
                    b.HasOne("singToSeminar.Context.Seminar", null)
                        .WithMany("bookings")
                        .HasForeignKey("seminarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("singToSeminar.Context.Seminar", b =>
                {
                    b.Navigation("bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
