﻿// <auto-generated />
using System;
using ElectricityUsageDashboard.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElectricityUsageDashboard.Migrations
{
    [DbContext(typeof(ReadingsDbContext))]
    [Migration("20230222215944_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ElectricityUsageDashboard.Models.Reading", b =>
                {
                    b.Property<int>("ReadingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReadingId"), 1L, 1);

                    b.Property<int>("CurrentReading")
                        .HasColumnType("int");

                    b.Property<bool>("IsBilledReading")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ReadingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ReadingId");

                    b.ToTable("Readings");
                });
#pragma warning restore 612, 618
        }
    }
}
