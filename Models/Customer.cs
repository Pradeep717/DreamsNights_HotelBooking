using System.ComponentModel.DataAnnotations;

namespace DreamsNights_HotelBooking.Models
{
    public class Customer
    {
        public Customer() 
        {
            this.Bookings = new List<Booking>();
        }
        [Key]
        public int CustomerId { get; set; }           // The unique identifier for this customer.
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = default;         // The first name of the customer.
        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = default;         // The last name of the customer.
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = String.Empty;           // The email address of the customer.
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; } = String.Empty;            // The phone number of the customer.
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = String.Empty;

        //Navigation property
        public virtual ICollection<Booking> Bookings { get; set; } // The bookings associated with this customer.


    }
}
