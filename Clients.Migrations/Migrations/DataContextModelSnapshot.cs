﻿// <auto-generated />
using System;
using Clients.Migrations.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Clients.Migrations.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Clients.Model.Client", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Clients.Model.PolygonRequest", b =>
                {
                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RequestTypeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("TickerID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("RequestTypeID");

                    b.HasIndex("TickerID");

                    b.ToTable("PolygonRequests");
                });

            modelBuilder.Entity("Clients.Model.PolygonRequestType", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID");

                    b.ToTable("PolygonRequestTypes");
                });

            modelBuilder.Entity("Clients.Model.PolygonTicker", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID");

                    b.ToTable("PolygonTickers");
                });

            modelBuilder.Entity("Clients.Model.PreviousCloseResponse", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<DateTime>("AggregateWindowDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ClosePrice")
                        .HasPrecision(16, 4)
                        .HasColumnType("decimal(16,4)");

                    b.Property<decimal>("HighestPrice")
                        .HasPrecision(16, 4)
                        .HasColumnType("decimal(16,4)");

                    b.Property<bool>("IsClientsNotified")
                        .HasColumnType("bit");

                    b.Property<decimal>("LowestPrice")
                        .HasPrecision(16, 4)
                        .HasColumnType("decimal(16,4)");

                    b.Property<decimal>("OpenPrice")
                        .HasPrecision(16, 4)
                        .HasColumnType("decimal(16,4)");

                    b.Property<Guid>("RequestID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TradingVolume")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("TransactionsCount")
                        .HasColumnType("bigint");

                    b.Property<decimal>("VolumeWeightedAveragePrice")
                        .HasPrecision(16, 4)
                        .HasColumnType("decimal(16,4)");

                    b.HasKey("ID");

                    b.HasIndex("RequestID");

                    b.ToTable("PreviousCloseResponses");
                });

            modelBuilder.Entity("Clients.Model.PolygonRequest", b =>
                {
                    b.HasOne("Clients.Model.PolygonRequestType", "RequestType")
                        .WithMany("PolygonRequests")
                        .HasForeignKey("RequestTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clients.Model.PolygonTicker", "Ticker")
                        .WithMany("PolygonRequests")
                        .HasForeignKey("TickerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RequestType");

                    b.Navigation("Ticker");
                });

            modelBuilder.Entity("Clients.Model.PreviousCloseResponse", b =>
                {
                    b.HasOne("Clients.Model.PolygonRequest", "Request")
                        .WithMany("PreviousCloseResponses")
                        .HasForeignKey("RequestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Request");
                });

            modelBuilder.Entity("Clients.Model.PolygonRequest", b =>
                {
                    b.Navigation("PreviousCloseResponses");
                });

            modelBuilder.Entity("Clients.Model.PolygonRequestType", b =>
                {
                    b.Navigation("PolygonRequests");
                });

            modelBuilder.Entity("Clients.Model.PolygonTicker", b =>
                {
                    b.Navigation("PolygonRequests");
                });
#pragma warning restore 612, 618
        }
    }
}
