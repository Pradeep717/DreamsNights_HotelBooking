using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamsNights_HotelBooking.Models
{
    public class RoomType
    {
        public RoomType()
        {
            this.Rooms = new List<Room>();
            this.Hotels = new List<Hotel>();
        }
        [Key]
        public int RoomTypeId { get; set; }        // The unique identifier for this room type.
        [ForeignKey("Hotel")]
        public int HotelId { get; set; }
        [Required]
        [StringLength(50)]
        public string TypeName { get; set; } = default;      // The name of the room type (e.g. standard, suite, etc.).
        [Required]
        [StringLength(1000)]
        public string Description { get; set; } = default;    // The description of the room type.
        [Required]
        [MaxLength(10)]
        public int MaxOccupancy { get; set; }      // The maximum number of occupants allowed in the room type.
        [Required]
        [MaxLength(20)]
        public decimal BasePrice { get; set; }     // The base price of the room type per night.

        //Navigation property
        public ICollection<Room> Rooms { get; set; } // The facilities available in the hotel.
        public ICollection<Hotel> Hotels { get; set; } // The facilities available in the hotel.


    }
}
