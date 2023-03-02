using DreamsNights_HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DreamsNights_HotelBooking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly List<Hotel> _hotels = new List<Hotel>
        {
            new Hotel
            {
                HotelId = 1,
                Name = "Dreams Resort",
                Address = "123 Main St, Anytown, USA",
                Rating = 4.5M,
                AdminId = 1,
                HotelOwnerId = 1,
                HotelFacilityId = 1
            },
            new Hotel
            {
                HotelId = 2,
                Name = "Nights Inn",
                Address = "456 Elm St, Anytown, USA",
                Rating = 3.8M,
                AdminId = 2,
                HotelOwnerId = 2,
                HotelFacilityId = 2
            }
        };

        [HttpGet]
        public IEnumerable<Hotel> Get()
        {
            return _hotels;
        }

        [HttpGet("{id}")]
        public ActionResult<Hotel> Get(int id)
        {
            var hotel = _hotels.Find(h => h.HotelId == id);

            if (hotel == null)
            {
                return NotFound();
            }

            return hotel;
        }

        [HttpPost]
        public IActionResult Post(Hotel hotel)
        {
            // Add new hotel to the list
            _hotels.Add(hotel);

            // Return success status code
            return CreatedAtAction(nameof(Get), new { id = hotel.HotelId }, hotel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Hotel hotel)
        {
            // Find the hotel in the list
            var index = _hotels.FindIndex(h => h.HotelId == id);

            if (index == -1)
            {
                return NotFound();
            }

            // Update the hotel
            _hotels[index] = hotel;

            // Return success status code
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Find the hotel in the list
            var hotel = _hotels.Find(h => h.HotelId == id);

            if (hotel == null)
            {
                return NotFound();
            }

            // Remove the hotel from the list
            _hotels.Remove(hotel);

            // Return success status code
            return NoContent();
        }
    }
}
