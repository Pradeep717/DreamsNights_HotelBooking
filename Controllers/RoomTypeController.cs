using DreamsNights_HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DreamsNights_HotelBooking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomTypeController : ControllerBase
    {
        private readonly List<RoomType> _roomTypes = new List<RoomType>
        {
            new RoomType
            {
                RoomTypeId = 1,
                HotelId = 1,
                TypeName = "Standard",
                Description = "A standard room with one queen-size bed",
                MaxOccupancy = 2,
                BasePrice = 100.00m
            },
            new RoomType
            {
                RoomTypeId = 2,
                HotelId = 1,
                TypeName = "Suite",
                Description = "A luxurious suite with a king-size bed and a separate living area",
                MaxOccupancy = 4,
                BasePrice = 250.00m
            }
        };

        [HttpGet]
        public IEnumerable<RoomType> Get()
        {
            return _roomTypes;
        }

        [HttpGet("{id}")]
        public ActionResult<RoomType> Get(int id)
        {
            var roomType = _roomTypes.Find(rt => rt.RoomTypeId == id);

            if (roomType == null)
            {
                return NotFound();
            }

            return roomType;
        }

        [HttpPost]
        public IActionResult Post(RoomType roomType)
        {
            // Add new room type to the list
            _roomTypes.Add(roomType);

            // Return success status code
            return CreatedAtAction(nameof(Get), new { id = roomType.RoomTypeId }, roomType);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, RoomType roomType)
        {
            // Find the room type in the list
            var index = _roomTypes.FindIndex(rt => rt.RoomTypeId == id);

            if (index == -1)
            {
                return NotFound();
            }

            // Update the room type
            _roomTypes[index] = roomType;

            // Return success status code
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Find the room type in the list
            var roomType = _roomTypes.Find(rt => rt.RoomTypeId == id);

            if (roomType == null)
            {
                return NotFound();
            }

            // Remove the room type from the list
            _roomTypes.Remove(roomType);

            // Return success status code
            return NoContent();
        }
    }
}

