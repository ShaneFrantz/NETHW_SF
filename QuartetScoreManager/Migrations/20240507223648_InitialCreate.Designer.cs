﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuartetScoreManager.Databases;

#nullable disable

namespace QuartetScoreManager.Migrations
{
    [DbContext(typeof(QuartetScoreDbContext))]
    [Migration("20240507223648_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuartetScoreManager.Models.QuartetScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("MusScore")
                        .HasColumnType("decimal(4,1)");

                    b.Property<decimal>("PerScore")
                        .HasColumnType("decimal(4,1)");

                    b.Property<string>("QuartetName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("SngScore")
                        .HasColumnType("decimal(4,1)");

                    b.HasKey("Id");

                    b.ToTable("QuartetScores");
                });
#pragma warning restore 612, 618
        }
    }
}