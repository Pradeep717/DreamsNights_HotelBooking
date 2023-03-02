using System.ComponentModel.DataAnnotations;

namespace DreamsNights_HotelBooking.Models
{
    public class HotelOwner
    {
        public HotelOwner()
        {
            this.Hotels = new List<Hotel>();
        }
        [Key]
        public int HotelOwnerId { get; set; }       // The unique identifier for this hotel owner.
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = default;     // The first name of the hotel owner.
        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = default;       // The last name of the hotel owner.
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = default;         // The email address of the hotel owner.
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; } = default;           // The phone number of the hotel owner.
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = default;        // The password for the hotel owner's account.

        //Navigation property
        public ICollection<Hotel> Hotels { get; set; } // The facilities available in the hotel.


    }
}
