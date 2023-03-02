using DreamsNights_HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DreamsNights_HotelBooking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly List<Booking> _bookings = new List<Booking>
        {
            new Booking
            {
                BookingId = 1,
                CustomerId = 1,
                RoomId = 1,
                CheckInDate = new DateTime(2022, 1, 1),
                CheckOutDate = new DateTime(2022, 1, 5),
                TotalPrice = 500,
                Status = "Confirmed",
                AdminId = 1
            },
            new Booking
            {
                BookingId = 2,
                CustomerId = 2,
                RoomId = 2,
                CheckInDate = new DateTime(2022, 2, 1),
                CheckOutDate = new DateTime(2022, 2, 5),
                TotalPrice = 600,
                Status = "Pending",
                AdminId = 2
            }
        };

        [HttpGet]
        public IEnumerable<Booking> Get()
        {
            return _bookings;
        }

        [HttpGet("{id}")]
        public ActionResult<Booking> Get(int id)
        {
            var booking = _bookings.Find(b => b.BookingId == id);

            if (booking == null)
            {
                return NotFound();
            }

            return booking;
        }

        [HttpPost]
        public IActionResult Post(Booking booking)
        {
            // Add new booking to the list
            _bookings.Add(booking);

            // Return success status code
            return CreatedAtAction(nameof(Get), new { id = booking.BookingId }, booking);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Booking booking)
        {
            // Find the booking in the list
            var index = _bookings.FindIndex(b => b.BookingId == id);

            if (index == -1)
            {
                return NotFound();
            }

            // Update the booking
            _bookings[index] = booking;

            // Return success status code
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Find the booking in the list
            var booking = _bookings.Find(b => b.BookingId == id);

            if (booking == null)
            {
                return NotFound();
            }

            // Remove the booking from the list
            _bookings.Remove(booking);

            // Return success status code
            return NoContent();
        }
    }
}
