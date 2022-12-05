﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(EfDbContext))]
    partial class EfDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.11");

            modelBuilder.Entity("Entities.Concrete.Brand", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BrandOrigin")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("brands");
                });

            modelBuilder.Entity("Entities.Concrete.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerMail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerTaxNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerTaxOffice")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("Entities.Concrete.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Deadline")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Inch")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PackageType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WashType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("brandid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("customerid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("k28")
                        .HasColumnType("INTEGER");

                    b.Property<int>("k30")
                        .HasColumnType("INTEGER");

                    b.Property<int>("k32")
                        .HasColumnType("INTEGER");

                    b.Property<int>("k34")
                        .HasColumnType("INTEGER");

                    b.Property<int>("k36")
                        .HasColumnType("INTEGER");

                    b.Property<int>("k38")
                        .HasColumnType("INTEGER");

                    b.Property<int>("k40")
                        .HasColumnType("INTEGER");

                    b.Property<int>("k42")
                        .HasColumnType("INTEGER");

                    b.Property<int>("k44")
                        .HasColumnType("INTEGER");

                    b.Property<int>("k46")
                        .HasColumnType("INTEGER");

                    b.Property<int>("k48")
                        .HasColumnType("INTEGER");

                    b.Property<int>("k50")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("kCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("s28")
                        .HasColumnType("INTEGER");

                    b.Property<int>("s30")
                        .HasColumnType("INTEGER");

                    b.Property<int>("s32")
                        .HasColumnType("INTEGER");

                    b.Property<int>("s34")
                        .HasColumnType("INTEGER");

                    b.Property<int>("s36")
                        .HasColumnType("INTEGER");

                    b.Property<int>("s38")
                        .HasColumnType("INTEGER");

                    b.Property<int>("s40")
                        .HasColumnType("INTEGER");

                    b.Property<int>("s42")
                        .HasColumnType("INTEGER");

                    b.Property<int>("s44")
                        .HasColumnType("INTEGER");

                    b.Property<int>("s46")
                        .HasColumnType("INTEGER");

                    b.Property<int>("s48")
                        .HasColumnType("INTEGER");

                    b.Property<int>("s50")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("sCount")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("status")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("brandid");

                    b.HasIndex("customerid");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("Entities.Concrete.Order", b =>
                {
                    b.HasOne("Entities.Concrete.Brand", "brand")
                        .WithMany()
                        .HasForeignKey("brandid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("customerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("brand");

                    b.Navigation("customer");
                });
#pragma warning restore 612, 618
        }
    }
}
