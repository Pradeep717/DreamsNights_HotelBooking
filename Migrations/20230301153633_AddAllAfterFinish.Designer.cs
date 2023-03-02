﻿// <auto-generated />
using System;
using DreamsNights_HotelBooking.Datafile;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DreamsNights_HotelBooking.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230301153633_AddAllAfterFinish")]
    partial class AddAllAfterFinish
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DreamsNights_HotelBooking.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("DreamsNights_HotelBooking.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"), 1L, 1);

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BookingId");

                    b.HasIndex("AdminId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RoomId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("DreamsNights_HotelBooking.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DreamsNights_HotelBooking.Models.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<int>("HotelFacilityId")
                        .HasColumnType("int");

                    b.Property<int>("HotelOwnerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Rating")
                        .HasMaxLength(10)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("HotelId");

                    b.HasIndex("AdminId");

                    b.HasIndex("HotelOwnerId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("DreamsNights_HotelBooking.Models.HotelFacility", b =>
                {
                    b.Property<int>("FacilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacilityId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("FacilityName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.HasKey("FacilityId");

                    b.ToTable("HotelFacilities");
                });

            modelBuilder.Entity("DreamsNights_HotelBooking.Models.HotelOwner", b =>
                {
                    b.Property<int>("HotelOwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelOwnerId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelOwnerId");

                    b.ToTable("HotelOwners");
                });

            modelBuilder.Entity("DreamsNights_HotelBooking.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomId"), 1L, 1);

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<int>("NumBeds")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("DreamsNights_HotelBooking.Models.RoomType", b =>
                {
                    b.Property<int>("RoomTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomTypeId"), 1L, 1);

                    b.Property<decimal>("BasePrice")
                        .HasMaxLength(20)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<int>("MaxOccupancy")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoomTypeId");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("HotelHotelFacility", b =>
                {
                    b.Property<int>("HotelFacilitiesFacilityId")
                        .HasColumnType("int");

                    b.Property<int>("HotelsHotelId")
                        .HasColumnType("int");

                    b.HasKey("HotelFacilitiesFacilityId", "HotelsHotelId");

                    b.HasIndex("HotelsHotelId");

                    b.ToTable("HotelHotelFacility");
                });

            modelBuilder.Entity("HotelRoom", b =>
                {
                    b.Property<int>("HotelsHotelId")
                        .HasColumnType("int");

                    b.Property<int>("RoomsRoomId")
                        .HasColumnType("int");

                    b.HasKey("HotelsHotelId", "RoomsRoomId");

                    b.HasIndex("RoomsRoomId");

                    b.ToTable("HotelRoom");
                });

            modelBuilder.Entity("HotelRoomType", b =>
                {
                    b.Property<int>("HotelsHotelId")
                        .HasColumnType("int");

                    b.Property<int>("RoomTypesRoomTypeId")
                        .HasColumnType("int");

                    b.HasKey("HotelsHotelId", "RoomTypesRoomTypeId");

                    b.HasIndex("RoomTypesRoomTypeId");

                    b.ToTable("HotelRoomType");
                });

            modelBuilder.Entity("RoomRoomType", b =>
                {
                    b.Property<int>("RoomTypesRoomTypeId")
                        .HasColumnType("int");

                    b.Property<int>("RoomsRoomId")
                        .HasColumnType("int");

                    b.HasKey("RoomTypesRoomTypeId", "RoomsRoomId");

                    b.HasIndex("RoomsRoomId");

                    b.ToTable("RoomRoomType");
                });

            modelBuilder.Entity("DreamsNights_HotelBooking.Models.Booking", b =>
                {
                    b.HasOne("DreamsNights_HotelBooking.Models.Admin", "Admin")
                        .WithMany("Bookings")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DreamsNights_HotelBooking.Models.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DreamsNights_HotelBooking.Models.Room", "Room")
                        .WithMany("Bookings")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Customer");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("DreamsNights_HotelBooking.Models.Hotel", b =>
                {
                    b.HasOne("DreamsNights_HotelBooking.Models.Admin", "Admin")
                        .WithMany("Hotels")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DreamsNights_HotelBooking.Models.HotelOwner", "HotelOwner")
                        .WithMany("Hotels")
                        .HasForeignKey("HotelOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("HotelOwner");
                });

            modelBuilder.Entity("HotelHotelFacility", b =>
                {
                    b.HasOne("DreamsNights_HotelBooking.Models.HotelFacility", null)
                        .WithMany()
                        .HasForeignKey("HotelFacilitiesFacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DreamsNights_HotelBooking.Models.Hotel", null)
                        .WithMany()
                        .HasForeignKey("HotelsHotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HotelRoom", b =>
                {
                    b.HasOne("DreamsNights_HotelBooking.Models.Hotel", null)
                        .WithMany()
                        .HasForeignKey("HotelsHotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DreamsNights_HotelBooking.Models.Room", null)
                        .WithMany()
                        .HasForeignKey("RoomsRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HotelRoomType", b =>
                {
                    b.HasOne("DreamsNights_HotelBooking.Models.Hotel", null)
                        .WithMany()
                        .HasForeignKey("HotelsHotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DreamsNights_HotelBooking.Models.RoomType", null)
                        .WithMany()
                        .HasForeignKey("RoomTypesRoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoomRoomType", b =>
                {
                    b.HasOne("DreamsNights_HotelBooking.Models.RoomType", null)
                        .WithMany()
                        .HasForeignKey("RoomTypesRoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DreamsNights_HotelBooking.Models.Room", null)
                        .WithMany()
                        .HasForeignKey("RoomsRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DreamsNights_HotelBooking.Models.Admin", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Hotels");
                });

            modelBuilder.Entity("DreamsNights_HotelBooking.Models.Customer", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("DreamsNights_HotelBooking.Models.HotelOwner", b =>
                {
                    b.Navigation("Hotels");
                });

            modelBuilder.Entity("DreamsNights_HotelBooking.Models.Room", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}