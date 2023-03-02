using DreamsNights_HotelBooking.Models;
using Microsoft.EntityFrameworkCore;

namespace DreamsNights_HotelBooking.Datafile
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; } = default;
        public virtual DbSet<Customer> Customers { get; set; } = default;
        public virtual DbSet<Booking> Bookings { get; set; } = default;
        public virtual DbSet<Room> Rooms { get; set; } = default;
        public virtual DbSet<Hotel> Hotels { get; set; } = default;
        public virtual DbSet<HotelFacility> HotelFacilities { get; set; } = default;
        public virtual DbSet<HotelOwner> HotelOwners { get; set; } = default;
        public virtual DbSet<RoomType> RoomTypes { get; set; } = default;


    }
}
