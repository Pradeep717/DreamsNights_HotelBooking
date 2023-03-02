using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamsNights_HotelBooking.Models
{
    public class HotelFacility
    {
        public HotelFacility()
        {
            this.Hotels = new List<Hotel>();
        }
        [Key]
        public int FacilityId { get; set; }         // The unique identifier for this hotel facility.
        [Required]
        [MaxLength(100)]
        public string FacilityName { get; set; } = default;   // The name of the hotel facility (e.g. gym, pool, etc.).
        [Required]
        [MaxLength(1000)]
        public string Description { get; set; } = default;    // The description of the hotel facility.

        [ForeignKey("Hotel")]
        public int HotelId { get; set; }
        //Navigation property
        public ICollection<Hotel> Hotels { get; set; } // The facilities available in the hotel.


    }
}
