﻿// <auto-generated />
using System;
using Automarket.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Automarket.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230422045622_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Automarket.Domain.Entity.Basket", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Baskets", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            UserId = 1L
                        });
                });

            modelBuilder.Entity("Automarket.Domain.Entity.Car", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<byte[]>("Avatar")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("Speed")
                        .HasColumnType("float");

                    b.Property<int>("TypeCar")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateCreate = new DateTime(2023, 4, 22, 14, 56, 21, 864, DateTimeKind.Local).AddTicks(5105),
                            Description = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
                            Model = "BMW",
                            Name = "ITHomester",
                            Price = 0m,
                            Speed = 230.0,
                            TypeCar = 0
                        });
                });

            modelBuilder.Entity("Automarket.Domain.Entity.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("BasketId")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<long?>("CarId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("Automarket.Domain.Entity.Profile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte>("Age")
                        .HasColumnType("tinyint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profiles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Age = (byte)0,
                            UserId = 1L
                        });
                });

            modelBuilder.Entity("Automarket.Domain.Entity.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Admin",
                            Password = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",
                            Role = 2
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Moderator",
                            Password = "481f6cc0511143ccdd7e2d1b1b94faf0a700a8b49cd13922a70b5ae28acaa8c5",
                            Role = 1
                        });
                });

            modelBuilder.Entity("Automarket.Domain.Entity.Basket", b =>
                {
                    b.HasOne("Automarket.Domain.Entity.User", "User")
                        .WithOne("Basket")
                        .HasForeignKey("Automarket.Domain.Entity.Basket", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Automarket.Domain.Entity.Order", b =>
                {
                    b.HasOne("Automarket.Domain.Entity.Basket", "Basket")
                        .WithMany("Orders")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");
                });

            modelBuilder.Entity("Automarket.Domain.Entity.Profile", b =>
                {
                    b.HasOne("Automarket.Domain.Entity.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("Automarket.Domain.Entity.Profile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Automarket.Domain.Entity.Basket", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Automarket.Domain.Entity.User", b =>
                {
                    b.Navigation("Basket")
                        .IsRequired();

                    b.Navigation("Profile")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
