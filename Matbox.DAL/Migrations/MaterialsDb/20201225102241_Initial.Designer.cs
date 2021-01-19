﻿// <auto-generated />
using System;
using Matbox.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Matbox.DAL.Migrations.MaterialsDb
{
    [DbContext(typeof(MaterialsDbContext))]
    [Migration("20201225102241_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Matbox.DAL.Models.Material", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("category")
                        .HasColumnType("text");

                    b.Property<string>("materialName")
                        .HasColumnType("text");

                    b.Property<DateTime>("metaDateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("metaFileSize")
                        .HasColumnType("double precision");

                    b.Property<string>("path")
                        .HasColumnType("text");

                    b.Property<int>("versionNumber")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Materials");
                });
#pragma warning restore 612, 618
        }
    }
}