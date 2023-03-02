using DreamsNights_HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DreamsNights_HotelBooking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelFacilityController : ControllerBase
    {
        private readonly List<HotelFacility> _hotelFacilities = new List<HotelFacility>
        {
            new HotelFacility
            {
                FacilityId = 1,
                FacilityName = "Swimming pool",
                Description = "A large outdoor swimming pool with lounge chairs and umbrellas.",
                HotelId = 1
            },
            new HotelFacility
            {
                FacilityId = 2,
                FacilityName = "Gym",
                Description = "A fully equipped gym with cardio machines, weights, and personal trainers.",
                HotelId = 1
            }
        };

        [HttpGet]
        public IEnumerable<HotelFacility> Get()
        {
            return _hotelFacilities;
        }

        [HttpGet("{id}")]
        public ActionResult<HotelFacility> Get(int id)
        {
            var hotelFacility = _hotelFacilities.Find(hf => hf.FacilityId == id);

            if (hotelFacility == null)
            {
                return NotFound();
            }

            return hotelFacility;
        }

        [HttpPost]
        public IActionResult Post(HotelFacility hotelFacility)
        {
            // Add new hotel facility to the list
            _hotelFacilities.Add(hotelFacility);

            // Return success status code
            return CreatedAtAction(nameof(Get), new { id = hotelFacility.FacilityId }, hotelFacility);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, HotelFacility hotelFacility)
        {
            // Find the hotel facility in the list
            var index = _hotelFacilities.FindIndex(hf => hf.FacilityId == id);

            if (index == -1)
            {
                return NotFound();
            }

            // Update the hotel facility
            _hotelFacilities[index] = hotelFacility;

            // Return success status code
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Find the hotel facility in the list
            var hotelFacility = _hotelFacilities.Find(hf => hf.FacilityId == id);

            if (hotelFacility == null)
            {
                return NotFound();
            }

            // Remove the hotel facility from the list
            _hotelFacilities.Remove(hotelFacility);

            // Return success status code
            return NoContent();
        }
    }
}
