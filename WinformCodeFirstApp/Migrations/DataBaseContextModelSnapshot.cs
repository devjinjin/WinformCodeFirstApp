﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinformCodeFirstApp.Data;

#nullable disable

namespace WinformCodeFirstApp.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WinformCodeFirstApp.Models.DiagModel", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"), 1L, 1);

                    b.Property<byte>("actT")
                        .HasColumnType("tinyint");

                    b.Property<int?>("avaD")
                        .HasColumnType("int");

                    b.Property<short?>("b0T")
                        .HasColumnType("smallint");

                    b.Property<short?>("b0fT")
                        .HasColumnType("smallint");

                    b.Property<short?>("b1T")
                        .HasColumnType("smallint");

                    b.Property<short?>("b1fT")
                        .HasColumnType("smallint");

                    b.Property<short?>("bC")
                        .HasColumnType("smallint");

                    b.Property<int?>("bV")
                        .HasColumnType("int");

                    b.Property<byte?>("bms0S")
                        .HasColumnType("tinyint");

                    b.Property<long?>("bms0S_T")
                        .HasColumnType("bigint");

                    b.Property<byte?>("bms1S")
                        .HasColumnType("tinyint");

                    b.Property<bool>("brkB")
                        .HasColumnType("bit");

                    b.Property<long?>("brkB_T")
                        .HasColumnType("bigint");

                    b.Property<long?>("bsm1S_T")
                        .HasColumnType("bigint");

                    b.Property<byte?>("bstS")
                        .HasColumnType("tinyint");

                    b.Property<long?>("bstS_T")
                        .HasColumnType("bigint");

                    b.Property<short?>("coilT")
                        .HasColumnType("smallint");

                    b.Property<byte[]>("err")
                        .HasColumnType("varbinary(max)");

                    b.Property<long?>("err_T")
                        .HasColumnType("bigint");

                    b.Property<byte?>("mcuS")
                        .HasColumnType("tinyint");

                    b.Property<long?>("mcuS_T")
                        .HasColumnType("bigint");

                    b.Property<short?>("mcufT")
                        .HasColumnType("smallint");

                    b.Property<bool?>("regB")
                        .HasColumnType("bit");

                    b.Property<long?>("regB_T")
                        .HasColumnType("bigint");

                    b.Property<byte?>("soc0")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("soc1")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("tarT")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("tht")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("vcuS")
                        .HasColumnType("tinyint");

                    b.Property<long?>("vcuS_T")
                        .HasColumnType("bigint");

                    b.Property<byte?>("vehS")
                        .HasColumnType("tinyint");

                    b.Property<short?>("watT")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.ToTable("Diags");
                });

            modelBuilder.Entity("WinformCodeFirstApp.Models.DrivingModel", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"), 1L, 1);

                    b.Property<byte?>("avDS")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("aveE")
                        .HasColumnType("tinyint");

                    b.Property<float?>("driD")
                        .HasColumnType("real");

                    b.Property<int?>("idlT")
                        .HasColumnType("int");

                    b.Property<byte?>("mxDS")
                        .HasColumnType("tinyint");

                    b.Property<string>("offT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("onT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("raN")
                        .HasColumnType("int");

                    b.Property<int?>("rdN")
                        .HasColumnType("int");

                    b.Property<long?>("totD")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.ToTable("Drivings");
                });

            modelBuilder.Entity("WinformCodeFirstApp.Models.MonitorModel", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"), 1L, 1);

                    b.Property<byte?>("b1lf")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("b2lf")
                        .HasColumnType("tinyint");

                    b.Property<short?>("bc")
                        .HasColumnType("smallint");

                    b.Property<long?>("bcID")
                        .HasColumnType("bigint");

                    b.Property<short?>("bcc")
                        .HasColumnType("smallint");

                    b.Property<int?>("brkN")
                        .HasColumnType("int");

                    b.Property<byte?>("dm1T")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("dm2T")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("dm3T")
                        .HasColumnType("tinyint");

                    b.Property<int?>("ewpT")
                        .HasColumnType("int");

                    b.Property<long?>("kyID")
                        .HasColumnType("bigint");

                    b.Property<int?>("limB")
                        .HasColumnType("int");

                    b.Property<short?>("mcc")
                        .HasColumnType("smallint");

                    b.Property<byte?>("mnTA")
                        .HasColumnType("tinyint");

                    b.Property<short?>("mnb1T")
                        .HasColumnType("smallint");

                    b.Property<short?>("mnb2T")
                        .HasColumnType("smallint");

                    b.Property<byte?>("mnbV")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("mnbc0V")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("mnbc1V")
                        .HasColumnType("tinyint");

                    b.Property<short?>("mxCT")
                        .HasColumnType("smallint");

                    b.Property<short?>("mxMR")
                        .HasColumnType("smallint");

                    b.Property<short?>("mxMT")
                        .HasColumnType("smallint");

                    b.Property<byte?>("mxTA")
                        .HasColumnType("tinyint");

                    b.Property<short?>("mxWT")
                        .HasColumnType("smallint");

                    b.Property<short?>("mxb1T")
                        .HasColumnType("smallint");

                    b.Property<short?>("mxb2T")
                        .HasColumnType("smallint");

                    b.Property<byte?>("mxbV")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("mxbc0V")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("mxbc1V")
                        .HasColumnType("tinyint");

                    b.Property<int?>("sbV")
                        .HasColumnType("int");

                    b.Property<int?>("sopT")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Monitors");
                });

            modelBuilder.Entity("WinformCodeFirstApp.Models.StatusModel", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"), 1L, 1);

                    b.Property<bool?>("_lock")
                        .HasColumnType("bit");

                    b.Property<int?>("avaD")
                        .HasColumnType("int");

                    b.Property<string>("b1ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("b2ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("glatD")
                        .HasColumnType("smallint");

                    b.Property<decimal?>("glatI")
                        .HasColumnType("decimal(10,6)");

                    b.Property<short?>("glonD")
                        .HasColumnType("smallint");

                    b.Property<decimal?>("glonI")
                        .HasColumnType("decimal(10,6)");

                    b.Property<bool?>("gpsS")
                        .HasColumnType("bit");

                    b.Property<bool?>("mstat")
                        .HasColumnType("bit");

                    b.Property<byte?>("soc0")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("soc1")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("tp0")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("tp1")
                        .HasColumnType("tinyint");

                    b.HasKey("ID");

                    b.ToTable("Statuses");
                });
#pragma warning restore 612, 618
        }
    }
}