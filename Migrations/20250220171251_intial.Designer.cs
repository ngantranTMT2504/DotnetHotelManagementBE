﻿// <auto-generated />
using System;
using HotelManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelManagement.Migrations
{
    [DbContext(typeof(HotelManagementDbContext))]
    [Migration("20250220171251_intial")]
    partial class intial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelManagement.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DateCheckout")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DateCkeckin")
                        .HasColumnType("date");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<int>("TotalRoom")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Booking", (string)null);

                    b
                        .HasAnnotation("SqlServer:IsTemporal", false)
                        .HasAnnotation("SqlServer:TemporalPeriodEndPropertyName", null)
                        .HasAnnotation("SqlServer:TemporalPeriodStartPropertyName", null);
                });

            modelBuilder.Entity("HotelManagement.Models.BookingService", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BookingId");

                    b.HasIndex("ServiceId");

                    b.ToTable("BookingService", (string)null);

                    b
                        .HasAnnotation("SqlServer:IsTemporal", false)
                        .HasAnnotation("SqlServer:TemporalPeriodEndPropertyName", null)
                        .HasAnnotation("SqlServer:TemporalPeriodStartPropertyName", null);
                });

            modelBuilder.Entity("HotelManagement.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<int>("Method")
                        .HasColumnType("int");

                    b.Property<DateOnly>("PaymentDate")
                        .HasColumnType("date");

                    b.Property<decimal>("UpFrontPayment")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BookingId")
                        .IsUnique();

                    b.ToTable("Payment", (string)null);

                    b
                        .HasAnnotation("SqlServer:IsTemporal", false)
                        .HasAnnotation("SqlServer:TemporalPeriodEndPropertyName", null)
                        .HasAnnotation("SqlServer:TemporalPeriodStartPropertyName", null);
                });

            modelBuilder.Entity("HotelManagement.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageRoom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberRoom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TypeRoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeRoomId");

                    b.ToTable("Room", (string)null);

                    b
                        .HasAnnotation("SqlServer:IsTemporal", false)
                        .HasAnnotation("SqlServer:TemporalPeriodEndPropertyName", null)
                        .HasAnnotation("SqlServer:TemporalPeriodStartPropertyName", null);
                });

            modelBuilder.Entity("HotelManagement.Models.RoomBooked", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DateBooked")
                        .HasColumnType("date");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomBooked", (string)null);

                    b
                        .HasAnnotation("SqlServer:IsTemporal", false)
                        .HasAnnotation("SqlServer:TemporalPeriodEndPropertyName", null)
                        .HasAnnotation("SqlServer:TemporalPeriodStartPropertyName", null);
                });

            modelBuilder.Entity("HotelManagement.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageService")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Service", (string)null);

                    b
                        .HasAnnotation("SqlServer:IsTemporal", false)
                        .HasAnnotation("SqlServer:TemporalPeriodEndPropertyName", null)
                        .HasAnnotation("SqlServer:TemporalPeriodStartPropertyName", null);
                });

            modelBuilder.Entity("HotelManagement.Models.TypeRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TypeRoom", (string)null);

                    b
                        .HasAnnotation("SqlServer:IsTemporal", false)
                        .HasAnnotation("SqlServer:TemporalPeriodEndPropertyName", null)
                        .HasAnnotation("SqlServer:TemporalPeriodStartPropertyName", null);
                });

            modelBuilder.Entity("HotelManagement.Models.BookingService", b =>
                {
                    b.HasOne("HotelManagement.Models.Booking", "Booking")
                        .WithMany("BookingServices")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelManagement.Models.Service", "Service")
                        .WithMany("BookingServices")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("HotelManagement.Models.Payment", b =>
                {
                    b.HasOne("HotelManagement.Models.Booking", "Booking")
                        .WithOne("Payment")
                        .HasForeignKey("HotelManagement.Models.Payment", "BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("HotelManagement.Models.Room", b =>
                {
                    b.HasOne("HotelManagement.Models.TypeRoom", "TypeRoom")
                        .WithMany("Room")
                        .HasForeignKey("TypeRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeRoom");
                });

            modelBuilder.Entity("HotelManagement.Models.RoomBooked", b =>
                {
                    b.HasOne("HotelManagement.Models.Booking", "Booking")
                        .WithMany("RoomBookeds")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelManagement.Models.Room", "Room")
                        .WithMany("RoomBookeds")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("HotelManagement.Models.Booking", b =>
                {
                    b.Navigation("BookingServices");

                    b.Navigation("Payment");

                    b.Navigation("RoomBookeds");
                });

            modelBuilder.Entity("HotelManagement.Models.Room", b =>
                {
                    b.Navigation("RoomBookeds");
                });

            modelBuilder.Entity("HotelManagement.Models.Service", b =>
                {
                    b.Navigation("BookingServices");
                });

            modelBuilder.Entity("HotelManagement.Models.TypeRoom", b =>
                {
                    b.Navigation("Room");
                });
#pragma warning restore 612, 618
        }
    }
}
