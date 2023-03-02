using DreamsNights_HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DreamsNights_HotelBooking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelOwnerController : ControllerBase
    {
        private readonly List<HotelOwner> _hotelOwners = new List<HotelOwner>
        {
            new HotelOwner
            {
                HotelOwnerId = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "johndoe@example.com",
                Phone = "123-456-7890",
                Password = "password123"
            },
            new HotelOwner
            {
                HotelOwnerId = 2,
                FirstName = "Jane",
                LastName = "Doe",
                Email = "janedoe@example.com",
                Phone = "123-456-7890",
                Password = "password123"
            }
        };

        [HttpGet]
        public IEnumerable<HotelOwner> Get()
        {
            return _hotelOwners;
        }

        [HttpGet("{id}")]
        public ActionResult<HotelOwner> Get(int id)
        {
            var hotelOwner = _hotelOwners.Find(ho => ho.HotelOwnerId == id);

            if (hotelOwner == null)
            {
                return NotFound();
            }

            return hotelOwner;
        }

        [HttpPost]
        public IActionResult Post(HotelOwner hotelOwner)
        {
            // Add new hotel owner to the list
            _hotelOwners.Add(hotelOwner);

            // Return success status code
            return CreatedAtAction(nameof(Get), new { id = hotelOwner.HotelOwnerId }, hotelOwner);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, HotelOwner hotelOwner)
        {
            // Find the hotel owner in the list
            var index = _hotelOwners.FindIndex(ho => ho.HotelOwnerId == id);

            if (index == -1)
            {
                return NotFound();
            }

            // Update the hotel owner
            _hotelOwners[index] = hotelOwner;

            // Return success status code
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Find the hotel owner in the list
            var hotelOwner = _hotelOwners.Find(ho => ho.HotelOwnerId == id);

            if (hotelOwner == null)
            {
                return NotFound();
            }

            // Remove the hotel owner from the list
            _hotelOwners.Remove(hotelOwner);

            // Return success status code
            return NoContent();
        }
    }
}
