﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Protests.Data.Database;

namespace Protests.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Protests.Data.Car", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("DriverId")
                        .HasColumnType("bigint");

                    b.Property<string>("LicencePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2020, 8, 6, 13, 31, 14, 453, DateTimeKind.Local).AddTicks(8700),
                            DriverId = 1L,
                            LicencePlate = "ZG0123BK"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2020, 8, 6, 13, 31, 14, 463, DateTimeKind.Local).AddTicks(8520),
                            DriverId = 1L,
                            LicencePlate = "KA280JA"
                        });
                });

            modelBuilder.Entity("Protests.Data.Driver", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2020, 8, 6, 13, 31, 14, 465, DateTimeKind.Local).AddTicks(8440),
                            FirstName = "Josip",
                            LastName = "Josić"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2020, 8, 6, 13, 31, 14, 465, DateTimeKind.Local).AddTicks(9490),
                            FirstName = "Marko",
                            LastName = "Marić"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2020, 8, 6, 13, 31, 14, 465, DateTimeKind.Local).AddTicks(9520),
                            FirstName = "Ivan",
                            LastName = "Ivan"
                        });
                });

            modelBuilder.Entity("Protests.Data.Entities.AppUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Protests.Data.Entities.City", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Protests.Data.Entities.Comment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(2048)")
                        .HasMaxLength(2048);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("ProtestId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProtestId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Protests.Data.Entities.Organizer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Organizers");
                });

            modelBuilder.Entity("Protests.Data.Entities.Protest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CityId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(10000);

                    b.Property<long>("OrganizerId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("OrganizerId");

                    b.ToTable("Protests");
                });

            modelBuilder.Entity("Protests.Data.Repair", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CarId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("RepairOptionId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("RepairedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Repairs");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CarId = 1L,
                            CreatedAt = new DateTime(2020, 8, 6, 13, 31, 14, 466, DateTimeKind.Local).AddTicks(3180),
                            RepairOptionId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            CarId = 2L,
                            CreatedAt = new DateTime(2020, 8, 6, 13, 31, 14, 466, DateTimeKind.Local).AddTicks(4120),
                            RepairOptionId = 2L
                        });
                });

            modelBuilder.Entity("Protests.Data.RepairOption", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("RepairOptions");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2020, 8, 6, 13, 31, 14, 466, DateTimeKind.Local).AddTicks(7690),
                            Name = "Vulkanizacija",
                            Price = 5.0
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2020, 8, 6, 13, 31, 14, 466, DateTimeKind.Local).AddTicks(8680),
                            Name = "Redovni servis",
                            Price = 5.0
                        });
                });

            modelBuilder.Entity("Protests.Data.Entities.Comment", b =>
                {
                    b.HasOne("Protests.Data.Entities.Protest", "Protest")
                        .WithMany("Comments")
                        .HasForeignKey("ProtestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Protests.Data.Entities.Protest", b =>
                {
                    b.HasOne("Protests.Data.Entities.City", "City")
                        .WithMany("Protests")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Protests.Data.Entities.Organizer", "Organizer")
                        .WithMany("Protests")
                        .HasForeignKey("OrganizerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
