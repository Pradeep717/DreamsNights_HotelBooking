using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamsNights_HotelBooking.Models
{
    public class Hotel
    {
        public Hotel()
        {
            this.Rooms = new List<Room>();
            this.HotelFacilities = new List<HotelFacility>();
            this.RoomTypes = new List<RoomType>();

        }
        [Key]
        public int HotelId { get; set; }      // The unique identifier for this hotel.
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = default;      // The name of the hotel.
        [Required]
        [StringLength(1000)]
        public string Address { get; set; } = default;   // The address of the hotel.
        [Required]
        [MaxLength(10)]
        public decimal Rating { get; set; }   // The rating of the hotel.
        [ForeignKey("Admin")]
        public int AdminId { get; set; }      // The ID of the admin who manages the hotel.
        [ForeignKey("HotelOwner")]
        public int HotelOwnerId { get; set; } // The ID of the hotel owner who owns the hotel.

        [ForeignKey("HotelFacility")]
        public int HotelFacilityId { get; set; }
 
        // Navigation properties to the related entities.
        public Admin Admin { get; set; } = default;      // The admin who manages the hotel.
        public HotelOwner HotelOwner { get; set; } = default; // The hotel owner who owns the hotel.
        public ICollection<Room> Rooms { get; set; } // The rooms available in the hotel.
        public ICollection<HotelFacility> HotelFacilities { get; set; } // The facilities available in the hotel.
        public ICollection<RoomType> RoomTypes { get; set; } // The rooms available in the hotel.

    }
}
