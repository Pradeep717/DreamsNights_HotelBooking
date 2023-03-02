using DreamsNights_HotelBooking.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamsNights_HotelBooking.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }   // The unique identifier for this booking.

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [ForeignKey("Room")]
        public int RoomId { get; set; }

        [Required]
        public DateTime CheckInDate { get; set; } // The check-in date for this booking.
        [Required]
        public DateTime CheckOutDate { get; set; } // The check-out date for this booking.
        public decimal TotalPrice { get; set; } // The total price of the booking.
        [Required]
        public string Status { get; set; } = String.Empty;     // The status of the booking (e.g. confirmed, cancelled, etc.).
        public int AdminId { get; set; }       // The ID of the administrator who managed the booking.

        // Navigation properties to the related entities.
        public virtual Customer Customer { get; set; } = default; // The customer who made the booking.
        public virtual Room Room { get; set; } = default;       // The room that was booked.
        public virtual Admin Admin { get; set; } = default;      // The administrator who managed the booking.

    }
}


