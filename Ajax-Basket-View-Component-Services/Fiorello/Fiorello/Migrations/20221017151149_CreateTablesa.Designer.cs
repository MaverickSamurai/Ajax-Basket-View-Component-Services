﻿// <auto-generated />
using System;
using Fiorello.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fiorello.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221017151149_CreateTablesa")]
    partial class CreateTablesa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fiorello.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2022, 10, 17, 19, 11, 48, 751, DateTimeKind.Local).AddTicks(9797),
                            Desc = "Desc1",
                            Image = "blog-feature-img-1.jpg",
                            IsDeleted = false,
                            Title = "Blog1"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2022, 10, 17, 19, 11, 48, 753, DateTimeKind.Local).AddTicks(4075),
                            Desc = "Desc2",
                            Image = "blog-feature-img-3.jpg",
                            IsDeleted = false,
                            Title = "Blog2"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2022, 10, 17, 19, 11, 48, 753, DateTimeKind.Local).AddTicks(4125),
                            Desc = "Desc3",
                            Image = "blog-feature-img-4.jpg",
                            IsDeleted = false,
                            Title = "Blog3"
                        });
                });

            modelBuilder.Entity("Fiorello.Models.Footer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Archive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("SocialMedia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Footers");
                });

            modelBuilder.Entity("Fiorello.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Key = "HeaderLogo",
                            Value = "logo.png"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Key = "Phone",
                            Value = "6516516516"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Key = "ProductTake",
                            Value = "4"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            Key = "Email",
                            Value = "Azerrh@code.edu.az"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
