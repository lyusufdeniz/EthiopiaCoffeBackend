﻿// <auto-generated />
using System;
using EthiopiaCoffe.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EthiopiaCoffe.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240513153904_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EthiopiaCoffe.Domain.Concrete.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2c728509-57b5-4c66-ae3f-7f088d902e14"),
                            CreateDate = new DateTime(2024, 5, 13, 18, 39, 4, 323, DateTimeKind.Local).AddTicks(6551),
                            Description = "Serinletici içeceklerle yazın sıcağında keyifli anlar yaşayın!",
                            IsDeleted = false,
                            Name = "Soğuk İçecekler"
                        },
                        new
                        {
                            Id = new Guid("dd316510-d189-4463-ae25-a73256d3da49"),
                            CreateDate = new DateTime(2024, 5, 13, 18, 39, 4, 323, DateTimeKind.Local).AddTicks(6568),
                            Description = "Kahve tutkunları için enfes sıcak içecekler! ",
                            IsDeleted = false,
                            Name = "Sıcak İçecekler"
                        },
                        new
                        {
                            Id = new Guid("0e37f945-1e8b-4bdd-a47d-ebe651fc788a"),
                            CreateDate = new DateTime(2024, 5, 13, 18, 39, 4, 323, DateTimeKind.Local).AddTicks(6583),
                            Description = "Kekler, kurabiyeler, muffinler, sandviçler ve daha fazlası",
                            IsDeleted = false,
                            Name = "Tatlılar ve Atıştırmalıklar"
                        },
                        new
                        {
                            Id = new Guid("d76f24b0-f0e2-4a56-8386-0b7f8939e5f9"),
                            CreateDate = new DateTime(2024, 5, 13, 18, 39, 4, 323, DateTimeKind.Local).AddTicks(6584),
                            Description = "Çeşitli kahve çekirdekleri özel karışımlar",
                            IsDeleted = false,
                            Name = "Kahve Çekirdekleri ve Çeşniler"
                        },
                        new
                        {
                            Id = new Guid("9db55c49-7b5a-436d-b99b-50b986e5af4a"),
                            CreateDate = new DateTime(2024, 5, 13, 18, 39, 4, 323, DateTimeKind.Local).AddTicks(6659),
                            Description = "Mevsimlik özel içecekler, meyve suları, smoothie'ler, spesiyal tarifler",
                            IsDeleted = false,
                            Name = "Özel İçecekler"
                        });
                });

            modelBuilder.Entity("EthiopiaCoffe.Domain.Concrete.Entities.Offer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("EthiopiaCoffe.Domain.Concrete.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EthiopiaCoffe.Domain.Concrete.Entities.Offer", b =>
                {
                    b.HasOne("EthiopiaCoffe.Domain.Concrete.Entities.Category", "Category")
                        .WithMany("Offers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EthiopiaCoffe.Domain.Concrete.Entities.Product", b =>
                {
                    b.HasOne("EthiopiaCoffe.Domain.Concrete.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EthiopiaCoffe.Domain.Concrete.Entities.Category", b =>
                {
                    b.Navigation("Offers");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}