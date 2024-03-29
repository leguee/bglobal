﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using testApplication.Models;

namespace testApplication.Migrations
{
    [DbContext(typeof(VehicleContext))]
    [Migration("20191114001514_initial-update")]
    partial class initialupdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("testApplication.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Patente")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.Property<int>("Puertas");

                    b.Property<string>("Titular")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
