﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Renova.Data;

namespace Renova.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200521191446_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Renova.Models.Gallery.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Images")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("ThumbnailImage")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            DisplayName = "Before and After Gallery",
                            Images = "/images/gallery/before-after/duggan_after_livingroom.jpg;/images/gallery/before-after/duggan_before_livingroom.jpg;/images/gallery/before-after/duggan_before_bathroom.jpg;/images/gallery/before-after/duggan_after_bathroom.jpg",
                            Name = "before-after",
                            ThumbnailImage = ""
                        },
                        new
                        {
                            ProjectId = 2,
                            DisplayName = "Duggan Project",
                            Images = "/images/gallery/duggan/duggan_after_kitchen2.jpg;/images/gallery/duggan/duggan_after_kitchen5.jpg;/images/gallery/duggan/duggan_after_livingroom3.jpg;/images/gallery/duggan/duggan_after_bathroom2.jpg;/images/gallery/duggan/duggan_after_livingroom.jpg;/images/gallery/duggan/duggan_after_wideshot.jpg;/images/gallery/duggan/duggan_after_diningarea.jpg;/images/gallery/duggan/duggan_after_kitchen1.jpg;/images/gallery/duggan/duggan_after_kitchen4.jpg;/images/gallery/duggan/duggan_after_kitchen3.jpg;/images/gallery/duggan/duggan_after_bathroom.jpg;/images/gallery/duggan/duggan_after_decoratedwide.jpg;/images/gallery/duggan/duggan_after_livingroom2.jpg;/images/gallery/duggan/duggan_after_backentrance.jpg",
                            Name = "duggan",
                            ThumbnailImage = ""
                        },
                        new
                        {
                            ProjectId = 3,
                            DisplayName = "Millwoods Project",
                            Images = "/images/gallery/millwoods/millwoods_after_bathroom1.jpg;/images/gallery/millwoods/millwoods_after_dining1.jpg;/images/gallery/millwoods/millwoods_after_bathroom3.jpg;/images/gallery/millwoods/millwoods_after_kitchen2.jpg;/images/gallery/millwoods/millwoods_after_bathroom2.jpg;/images/gallery/millwoods/millwoods_after_kitchen1.jpg",
                            Name = "millwoods",
                            ThumbnailImage = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}