﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetworkManagmentAPI.Data;

#nullable disable

namespace NetworkManagmentAPI.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NetworkManagementAPI.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("AddressType")
                        .HasColumnType("int");

                    b.Property<int>("DistributorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DistributorId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressName = "Rustaveli 5",
                            AddressType = 1,
                            DistributorId = 1
                        },
                        new
                        {
                            Id = 2,
                            AddressName = "Rustaveli 6",
                            AddressType = 2,
                            DistributorId = 1
                        },
                        new
                        {
                            Id = 3,
                            AddressName = "Pekini 21",
                            AddressType = 1,
                            DistributorId = 2
                        },
                        new
                        {
                            Id = 4,
                            AddressName = "Kostava 13",
                            AddressType = 1,
                            DistributorId = 3
                        },
                        new
                        {
                            Id = 5,
                            AddressName = "Tsereteli 5",
                            AddressType = 2,
                            DistributorId = 3
                        });
                });

            modelBuilder.Entity("NetworkManagementAPI.Entities.ContactInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ContactType")
                        .HasColumnType("int");

                    b.Property<int>("DistributorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DistributorId");

                    b.ToTable("ContactInfos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContactNumber = "555338877",
                            ContactType = 1,
                            DistributorId = 1
                        },
                        new
                        {
                            Id = 2,
                            ContactNumber = "giorgigiorgadze@gmail.com",
                            ContactType = 3,
                            DistributorId = 1
                        },
                        new
                        {
                            Id = 3,
                            ContactNumber = "davit123@gmail.com",
                            ContactType = 3,
                            DistributorId = 2
                        },
                        new
                        {
                            Id = 4,
                            ContactNumber = "551448877",
                            ContactType = 2,
                            DistributorId = 2
                        },
                        new
                        {
                            Id = 5,
                            ContactNumber = "558776932",
                            ContactType = 2,
                            DistributorId = 3
                        },
                        new
                        {
                            Id = 6,
                            ContactNumber = "anano@yahoo.com",
                            ContactType = 3,
                            DistributorId = 3
                        },
                        new
                        {
                            Id = 7,
                            ContactNumber = "123879",
                            ContactType = 4,
                            DistributorId = 3
                        });
                });

            modelBuilder.Entity("NetworkManagementAPI.Entities.Distributor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RecomendationsCount")
                        .HasColumnType("int");

                    b.Property<int>("RecomendatorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Distributors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1995, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Giorgi",
                            Gender = 1,
                            LastName = "Giorgadze",
                            RecomendationsCount = 0,
                            RecomendatorId = 0
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(2000, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Davit",
                            Gender = 1,
                            LastName = "Davitidze",
                            RecomendationsCount = 0,
                            RecomendatorId = 0
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1997, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Anano",
                            Gender = 2,
                            LastName = "Ananiashvili",
                            RecomendationsCount = 0,
                            RecomendatorId = 0
                        });
                });

            modelBuilder.Entity("NetworkManagementAPI.Entities.DistributorSell", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DistributorId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SellDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SellsCount")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DistributorId");

                    b.HasIndex("ProductId");

                    b.ToTable("DistributorSells");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DistributorId = 1,
                            ProductId = 1,
                            SellDate = new DateTime(2023, 12, 22, 17, 28, 15, 779, DateTimeKind.Local).AddTicks(4969),
                            SellsCount = 1,
                            TotalPrice = 1549m
                        },
                        new
                        {
                            Id = 2,
                            DistributorId = 2,
                            ProductId = 2,
                            SellDate = new DateTime(2023, 12, 22, 17, 28, 15, 779, DateTimeKind.Local).AddTicks(4978),
                            SellsCount = 3,
                            TotalPrice = 4347m
                        },
                        new
                        {
                            Id = 3,
                            DistributorId = 2,
                            ProductId = 3,
                            SellDate = new DateTime(2023, 12, 22, 17, 28, 15, 779, DateTimeKind.Local).AddTicks(4980),
                            SellsCount = 1,
                            TotalPrice = 1449m
                        },
                        new
                        {
                            Id = 4,
                            DistributorId = 3,
                            ProductId = 3,
                            SellDate = new DateTime(2023, 12, 22, 17, 28, 15, 779, DateTimeKind.Local).AddTicks(4981),
                            SellsCount = 2,
                            TotalPrice = 5000m
                        });
                });

            modelBuilder.Entity("NetworkManagementAPI.Entities.PersonalIdentifier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DistributorId")
                        .HasColumnType("int");

                    b.Property<string>("DocumentNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DocumentSeries")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("DocumentType")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("Date");

                    b.Property<string>("IssuingAuthority")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PersonalNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("Date");

                    b.HasKey("Id");

                    b.HasIndex("DistributorId");

                    b.ToTable("PersonalIdentifiers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DistributorId = 1,
                            DocumentNumber = "123",
                            DocumentSeries = "12345678",
                            DocumentType = 1,
                            ExpireDate = new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IssuingAuthority = "Justice house",
                            PersonalNumber = "0102487452",
                            ReleaseDate = new DateTime(2016, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            DistributorId = 1,
                            DocumentNumber = "332",
                            DocumentSeries = "115632",
                            DocumentType = 2,
                            ExpireDate = new DateTime(2015, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IssuingAuthority = "Justice house",
                            PersonalNumber = "012589632",
                            ReleaseDate = new DateTime(2010, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            DistributorId = 2,
                            DocumentNumber = "125",
                            DocumentSeries = "115633",
                            DocumentType = 1,
                            ExpireDate = new DateTime(2015, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IssuingAuthority = "Justice house",
                            PersonalNumber = "41587463983",
                            ReleaseDate = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            DistributorId = 3,
                            DocumentNumber = "658",
                            DocumentSeries = "215633",
                            DocumentType = 2,
                            ExpireDate = new DateTime(2015, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IssuingAuthority = "Justice house",
                            PersonalNumber = "158965822",
                            ReleaseDate = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("NetworkManagementAPI.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "cb58a2d8-47dd-452f-b7f3-f0343d14d431",
                            Price = 1549m,
                            Title = "Iphone 12"
                        },
                        new
                        {
                            Id = 2,
                            Code = "c5290d5a-77ff-4499-9975-ac8444b0375f",
                            Price = 1449m,
                            Title = "Iphone 11"
                        },
                        new
                        {
                            Id = 3,
                            Code = "1434be4d-9978-4305-98bc-d925c1561531",
                            Price = 1349m,
                            Title = "Iphone X"
                        },
                        new
                        {
                            Id = 4,
                            Code = "5cb5caa3-2097-4cf3-8210-0bbe3996ce74",
                            Price = 2500m,
                            Title = "PS5"
                        });
                });

            modelBuilder.Entity("NetworkManagementAPI.Entities.Address", b =>
                {
                    b.HasOne("NetworkManagementAPI.Entities.Distributor", "Distributor")
                        .WithMany("Addresses")
                        .HasForeignKey("DistributorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Distributor");
                });

            modelBuilder.Entity("NetworkManagementAPI.Entities.ContactInfo", b =>
                {
                    b.HasOne("NetworkManagementAPI.Entities.Distributor", "Distributor")
                        .WithMany("ContactInfos")
                        .HasForeignKey("DistributorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Distributor");
                });

            modelBuilder.Entity("NetworkManagementAPI.Entities.DistributorSell", b =>
                {
                    b.HasOne("NetworkManagementAPI.Entities.Distributor", "Distributor")
                        .WithMany("DistributorSells")
                        .HasForeignKey("DistributorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetworkManagementAPI.Entities.Product", "Product")
                        .WithMany("DistributorSells")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Distributor");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NetworkManagementAPI.Entities.PersonalIdentifier", b =>
                {
                    b.HasOne("NetworkManagementAPI.Entities.Distributor", "Distributor")
                        .WithMany("PersonalIdentifiers")
                        .HasForeignKey("DistributorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Distributor");
                });

            modelBuilder.Entity("NetworkManagementAPI.Entities.Distributor", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("ContactInfos");

                    b.Navigation("DistributorSells");

                    b.Navigation("PersonalIdentifiers");
                });

            modelBuilder.Entity("NetworkManagementAPI.Entities.Product", b =>
                {
                    b.Navigation("DistributorSells");
                });
#pragma warning restore 612, 618
        }
    }
}
