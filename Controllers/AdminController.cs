using DreamsNights_HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DreamsNights_HotelBooking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly List<Admin> _admins = new List<Admin>
        {
            new Admin { AdminId = 1, UserName = "admin1", Password = "password1" },
            new Admin { AdminId = 2, UserName = "admin2", Password = "password2" }
        };

        [HttpGet]
        public IEnumerable<Admin> Get()
        {
            return _admins;
        }

        [HttpGet("{id}")]
        public ActionResult<Admin> Get(int id)
        {
            var admin = _admins.Find(a => a.AdminId == id);

            if (admin == null)
            {
                return NotFound();
            }

            return admin;
        }

        [HttpPost]
        public IActionResult Post(Admin admin)
        {
            // Add new admin to the list
            _admins.Add(admin);

            // Return success status code
            return CreatedAtAction(nameof(Get), new { id = admin.AdminId }, admin);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Admin admin)
        {
            // Find the admin in the list
            var index = _admins.FindIndex(a => a.AdminId == id);

            if (index == -1)
            {
                return NotFound();
            }

            // Update the admin
            _admins[index] = admin;

            // Return success status code
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Find the admin in the list
            var admin = _admins.Find(a => a.AdminId == id);

            if (admin == null)
            {
                return NotFound();
            }

            // Remove the admin from the list
            _admins.Remove(admin);

            // Return success status code
            return NoContent();
        }
    }
}
