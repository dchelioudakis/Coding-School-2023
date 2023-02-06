﻿// <auto-generated />
using System;
using CarSercviceCenter.Orm.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarSercviceCenter.Orm.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230205211919_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CustomerEngineer", b =>
                {
                    b.Property<Guid>("CustomersId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EngineersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CustomersId", "EngineersId");

                    b.HasIndex("EngineersId");

                    b.ToTable("CustomerEngineer");
                });

            modelBuilder.Entity("CustomerManager", b =>
                {
                    b.Property<Guid>("CustomersId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ManagersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CustomersId", "ManagersId");

                    b.HasIndex("ManagersId");

                    b.ToTable("CustomerManager");
                });

            modelBuilder.Entity("LibCarService.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CarRegistrationNumber")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Car", (string)null);
                });

            modelBuilder.Entity("LibCarService.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TIN")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("LibCarService.Engineer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EngineerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ManagerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("SalaryPerMonth")
                        .HasMaxLength(50)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("EngineerId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Engineer", (string)null);
                });

            modelBuilder.Entity("LibCarService.Manager", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EngineerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ManagerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("SalaryPerMonth")
                        .HasMaxLength(50)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("EngineerId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Manager", (string)null);
                });

            modelBuilder.Entity("LibCarService.ServiceTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Code")
                        .HasMaxLength(20)
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Hours")
                        .HasMaxLength(5)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("ServiceTask", (string)null);
                });

            modelBuilder.Entity("LibCarService.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EngineerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ManagerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EngineerId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Transaction", (string)null);
                });

            modelBuilder.Entity("LibCarService.TransactionLine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EngineerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Hours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PricePerHour")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ServiceTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EngineerId");

                    b.HasIndex("ServiceTaskId");

                    b.HasIndex("TransactionId");

                    b.ToTable("TransactionLine", (string)null);
                });

            modelBuilder.Entity("CustomerEngineer", b =>
                {
                    b.HasOne("LibCarService.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibCarService.Engineer", null)
                        .WithMany()
                        .HasForeignKey("EngineersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerManager", b =>
                {
                    b.HasOne("LibCarService.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibCarService.Manager", null)
                        .WithMany()
                        .HasForeignKey("ManagersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LibCarService.Customer", b =>
                {
                    b.HasOne("LibCarService.Customer", null)
                        .WithMany("Customers")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("LibCarService.Engineer", b =>
                {
                    b.HasOne("LibCarService.Engineer", null)
                        .WithMany("Engineers")
                        .HasForeignKey("EngineerId");

                    b.HasOne("LibCarService.Manager", "Manager")
                        .WithMany("Engineers")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("LibCarService.Manager", b =>
                {
                    b.HasOne("LibCarService.Engineer", null)
                        .WithMany("Managers")
                        .HasForeignKey("EngineerId");

                    b.HasOne("LibCarService.Manager", null)
                        .WithMany("Managers")
                        .HasForeignKey("ManagerId");
                });

            modelBuilder.Entity("LibCarService.Transaction", b =>
                {
                    b.HasOne("LibCarService.Car", "Car")
                        .WithMany("Transactions")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibCarService.Customer", "Customer")
                        .WithMany("Transactions")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibCarService.Engineer", null)
                        .WithMany("Transactions")
                        .HasForeignKey("EngineerId");

                    b.HasOne("LibCarService.Manager", "Manager")
                        .WithMany("Transactions")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Customer");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("LibCarService.TransactionLine", b =>
                {
                    b.HasOne("LibCarService.Engineer", "Engineer")
                        .WithMany("TransactionLines")
                        .HasForeignKey("EngineerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibCarService.ServiceTask", "ServiceTask")
                        .WithMany("TransactionLines")
                        .HasForeignKey("ServiceTaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibCarService.Transaction", "Transaction")
                        .WithMany("TransactionLines")
                        .HasForeignKey("TransactionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Engineer");

                    b.Navigation("ServiceTask");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("LibCarService.Car", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("LibCarService.Customer", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("LibCarService.Engineer", b =>
                {
                    b.Navigation("Engineers");

                    b.Navigation("Managers");

                    b.Navigation("TransactionLines");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("LibCarService.Manager", b =>
                {
                    b.Navigation("Engineers");

                    b.Navigation("Managers");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("LibCarService.ServiceTask", b =>
                {
                    b.Navigation("TransactionLines");
                });

            modelBuilder.Entity("LibCarService.Transaction", b =>
                {
                    b.Navigation("TransactionLines");
                });
#pragma warning restore 612, 618
        }
    }
}