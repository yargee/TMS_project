﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Utility.Migrations
{
    [DbContext(typeof(UtilityDbContext))]
    [Migration("20231216174213_elementsPricesTable")]
    partial class elementsPricesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("ElementPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Category")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ElementId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("FurnitureElementId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FurnitureElementId");

                    b.ToTable("ElementsPrice");
                });

            modelBuilder.Entity("FurnitureCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CollectionId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("FurnitureElement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CollectionId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ElementId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("FurnitureCollectionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FurnitureCollectionId");

                    b.ToTable("Elements");
                });

            modelBuilder.Entity("ElementPrice", b =>
                {
                    b.HasOne("FurnitureElement", null)
                        .WithMany("Prices")
                        .HasForeignKey("FurnitureElementId");
                });

            modelBuilder.Entity("FurnitureElement", b =>
                {
                    b.HasOne("FurnitureCollection", null)
                        .WithMany("Elements")
                        .HasForeignKey("FurnitureCollectionId");
                });

            modelBuilder.Entity("FurnitureCollection", b =>
                {
                    b.Navigation("Elements");
                });

            modelBuilder.Entity("FurnitureElement", b =>
                {
                    b.Navigation("Prices");
                });
#pragma warning restore 612, 618
        }
    }
}
