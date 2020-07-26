using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Core.DBContext;
using API.HR.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using API.Core.Logic;
using API.HR.Logic;

namespace API.HR.Controller {
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase {
        private readonly Context _context;

        public LocationsController(Context context) {
            _context = context;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<Location>>> GetLocations() {
            return await _context.Locations.ToListAsync();
        }

        [HttpGet("Get/{id}")]
        public async Task<ActionResult<Location>> GetLocation(int id) {
            var location = await _context.Locations.FindAsync(id);

            if (location == null) {
                return NotFound();
            }

            return location;
        }

        //TODO: DO I NEED THIS?
        [HttpGet("GetEmployeeLocations/{id}")]
        public async Task<ActionResult<IEnumerable<Foreman>>> GetEmployeeLocations(int id) {
            var employee = await _context.Employees.FindAsync(id);

            if (employee == null) {
                return NotFound();
            }

            return Ok(employee.History.Select(x => x.Location).Distinct());
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> PutLocation(int id, Location location) {
            if (id != location.Id) {
                return BadRequest();
            }

            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value.ToString();
            BaseEntityManager.WriteUpdateTags(requestAuthor, ref location);
            _context.Entry(location).State = EntityState.Modified;

            _context.Entry(location).Property(x => x.CreatedOn).IsModified = false;
            _context.Entry(location).Property(x => x.CreatedBy).IsModified = false;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!LocationExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost("Create")]
        public async Task<ActionResult<Location>> PostLocation(Location location) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value.ToString();
            EmployeeManager.WriteCreationTags(requestAuthor, ref location);

            _context.Locations.Add(location);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocation", new { id = location.Id }, location);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult<Location>> DeleteLocation(int id) {
            var location = await _context.Locations.FindAsync(id);
            if (location == null) {
                return NotFound();
            }

            _context.Locations.Remove(location);
            await _context.SaveChangesAsync();

            return location;
        }

        private bool LocationExists(int id) {
            return _context.Locations.Any(e => e.Id == id);
        }
    }
}
