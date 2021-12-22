﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderBookSystem.Services;

namespace OrderBookSystem.Services.Migrations
{
    [DbContext(typeof(StockDbContext))]
    [Migration("20211222060138_SchemaChange")]
    partial class SchemaChange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("OrderBookSystem.Models.Stock", b =>
                {
                    b.Property<string>("StockId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ExecutedQty")
                        .HasColumnType("int");

                    b.Property<int>("ExecutionPrice")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderPrice")
                        .HasColumnType("int");

                    b.Property<int>("OrderQty")
                        .HasColumnType("int");

                    b.Property<int>("OrderType")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("StockName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StockId");

                    b.ToTable("Stocks");
                });
#pragma warning restore 612, 618
        }
    }
}
