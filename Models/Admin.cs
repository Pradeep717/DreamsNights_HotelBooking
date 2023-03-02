using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DreamsNights_HotelBooking.Models
{
    public class Admin
    {
        public Admin() 
        {
            this.Bookings = new List<Booking>();
            this.Hotels = new List<Hotel>();
        }
        [Key]
        public int AdminId { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; } = default;
        [Required]
        [StringLength(50)]
        public string Password { get; set; } = String.Empty;

        //Navigation property
        public ICollection<Booking> Bookings { get; set; } // The bookings made for this room.
        public ICollection<Hotel> Hotels { get; set; } // The bookings made for this room.

    }
}
