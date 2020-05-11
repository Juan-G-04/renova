﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Renova.Data;

namespace Renova.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Renova.Models.Gallery.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("Directory")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Images")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Directory = "/images/gallery/Millwoods/after/",
                            Images = "house1_after_backentrance.jpg;house1_after_bathroom.jpg;house1_after_bathroom2.jpg;house1_after_decoratedwide.jpg;house1_after_diningarea.jpg;house1_after_kitchen1.jpg;house1_after_kitchen2.jpg;house1_after_kitchen3.jpg;house1_after_kitchen4.jpg;house1_after_livingroom.jpg;house1_after_livingroom2.jpg;house1_after_livingroom3.jpg;house1_after_wideshot.jpg;kitchen1_after_1.jpg",
                            Name = "Millwoods Project"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
