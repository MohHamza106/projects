﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using entity_framework.entity;

#nullable disable

namespace entity_framework.Migrations
{
    [DbContext(typeof(CompanyDbContext))]
    [Migration("20250307150805_test")]
    partial class test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("entity_framework.Models.Department", b =>
                {
                    b.Property<int>("depId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("depId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasDefaultValue("alex")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(10)
                        .HasColumnType("varchar")
                        .HasColumnName("deptNAme");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("int ");

                    b.HasKey("depId");

                    b.ToTable("department", (string)null);
                });

            modelBuilder.Entity("entity_framework.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasDefaultValue("monsoure")
                        .HasColumnName("Employeeadress");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employee", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
