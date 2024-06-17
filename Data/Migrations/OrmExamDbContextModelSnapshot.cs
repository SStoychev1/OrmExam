﻿// <auto-generated />
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(OrmExamDbContext))]
    partial class OrmExamDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OrmExam.Models.ItemInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ItemInfos");
                });

            modelBuilder.Entity("OrmExam.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrderDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderPriority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrederId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shipingId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("shipingId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("OrmExam.Models.Shiping", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SalesChanel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("shipings");
                });

            modelBuilder.Entity("OrmExam.Models.Totals", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("TotalCosts")
                        .HasColumnType("float");

                    b.Property<double>("TotalProfit")
                        .HasColumnType("float");

                    b.Property<double>("TotalRevenue")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("totals");
                });

            modelBuilder.Entity("OrmExam.Models.Units", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("UnitCost")
                        .HasColumnType("float");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.Property<int>("UnitSold")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("OrmExam.Models.ItemInfo", b =>
                {
                    b.HasOne("OrmExam.Models.Units", "Units")
                        .WithOne("ItemInfo")
                        .HasForeignKey("OrmExam.Models.ItemInfo", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Units");
                });

            modelBuilder.Entity("OrmExam.Models.Order", b =>
                {
                    b.HasOne("OrmExam.Models.Shiping", "shiping")
                        .WithMany("orders")
                        .HasForeignKey("shipingId");

                    b.Navigation("shiping");
                });

            modelBuilder.Entity("OrmExam.Models.Totals", b =>
                {
                    b.HasOne("OrmExam.Models.Order", "Order")
                        .WithMany("totals")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("OrmExam.Models.Order", b =>
                {
                    b.Navigation("totals");
                });

            modelBuilder.Entity("OrmExam.Models.Shiping", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("OrmExam.Models.Units", b =>
                {
                    b.Navigation("ItemInfo")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
