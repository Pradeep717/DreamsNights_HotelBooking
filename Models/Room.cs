using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamsNights_HotelBooking.Models
{
    public class Room
    {
        public Room() 
        {
            this.Bookings=new List<Booking>();
            this.RoomTypes = new List<RoomType>();
            this.Hotels = new List<Hotel>();
        }

        [Key]
        public int RoomId { get; set; }      // The unique identifier for this room.
        [ForeignKey("Hotel")]
        public int HotelId { get; set; }

        public int NumBeds { get; set; }     // The number of beds in the room.
        [Required]
        public decimal Price { get; set; }   // The price of the room per night.
        [Required]
        public string Status { get; set; } = String.Empty;  // The status of the room (e.g. available, booked, etc.).
        [Required]

        //Navigation property
        public ICollection<Booking> Bookings { get; set; } // The bookings made for this room.
        public ICollection<RoomType> RoomTypes { get; set; } // The facilities available in the hotel.
        public ICollection<Hotel> Hotels { get; set; } // The facilities available in the hotel.


    }
}
