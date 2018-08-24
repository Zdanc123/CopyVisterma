﻿// <auto-generated />
using System;
using CopyVisterma;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CopyVisterma.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20180824105630_addTables")]
    partial class addTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CopyVisterma.Entities.BillingPeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuildingId");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartingDate");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("BillingPeriods");
                });

            modelBuilder.Entity("CopyVisterma.Entities.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<string>("Comments");

                    b.Property<string>("Number");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("CopyVisterma.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApartmentNumber");

                    b.Property<string>("BuildingNumber");

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<string>("NIP");

                    b.Property<string>("Name");

                    b.Property<string>("PersonGuardianId");

                    b.Property<string>("PersonHeatingId");

                    b.Property<string>("PersonWaterId");

                    b.Property<string>("Phone");

                    b.Property<string>("PostalCode");

                    b.Property<string>("REGON");

                    b.Property<string>("Street");

                    b.Property<int>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("PersonGuardianId");

                    b.HasIndex("PersonHeatingId");

                    b.HasIndex("PersonWaterId");

                    b.HasIndex("TypeId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("CopyVisterma.Entities.ClientTechnician", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<int>("ServiceTechnicianId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ServiceTechnicianId");

                    b.ToTable("ClientTechnicians");
                });

            modelBuilder.Entity("CopyVisterma.Entities.ClientType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ClientTypes");
                });

            modelBuilder.Entity("CopyVisterma.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<string>("Comments");

                    b.Property<string>("Email");

                    b.Property<string>("FullName");

                    b.Property<string>("PhoneLandline");

                    b.Property<string>("PhoneMobile");

                    b.Property<string>("Position");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CopyVisterma.Entities.ServiceTechnician", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName");

                    b.HasKey("Id");

                    b.ToTable("ServiceTechnicians");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("IdentityUser");
                });

            modelBuilder.Entity("CopyVisterma.Entities.BillingPeriod", b =>
                {
                    b.HasOne("CopyVisterma.Entities.Building", "Building")
                        .WithMany("BillingPeriods")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CopyVisterma.Entities.Building", b =>
                {
                    b.HasOne("CopyVisterma.Entities.Client", "Client")
                        .WithMany("Buildings")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CopyVisterma.Entities.Client", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "PersonGuardian")
                        .WithMany()
                        .HasForeignKey("PersonGuardianId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "PersonHeating")
                        .WithMany()
                        .HasForeignKey("PersonHeatingId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "PersonWater")
                        .WithMany()
                        .HasForeignKey("PersonWaterId");

                    b.HasOne("CopyVisterma.Entities.ClientType", "Type")
                        .WithMany("Clients")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CopyVisterma.Entities.ClientTechnician", b =>
                {
                    b.HasOne("CopyVisterma.Entities.Client", "Client")
                        .WithMany("ClientsTechnicians")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CopyVisterma.Entities.ServiceTechnician", "ServiceTechnician")
                        .WithMany("ClientsTechnicians")
                        .HasForeignKey("ServiceTechnicianId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CopyVisterma.Entities.Employee", b =>
                {
                    b.HasOne("CopyVisterma.Entities.Client", "Client")
                        .WithMany("Employees")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
