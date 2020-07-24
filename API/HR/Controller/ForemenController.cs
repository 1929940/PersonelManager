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
using API.Core.Logic;
using System.Security.Claims;
using API.HR.Logic;

namespace API.HR.Controller {
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ForemenController : ControllerBase {
        private readonly Context _context;

        public ForemenController(Context context) {
            _context = context;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<Foreman>>> GetForemen() {
            return await _context.Foremen.ToListAsync();
        }

        [HttpGet("Get/{id}")]
        public async Task<ActionResult<Foreman>> GetForeman(int id) {
            var foreman = await _context.Foremen.FindAsync(id);

            if (foreman == null) {
                return NotFound();
            }

            return foreman;
        }

        [HttpGet("GetEmployeeForemen/{id}")]
        public async Task<ActionResult<IEnumerable<Foreman>>> GetEmployeeForemen(int id) {
            var employee = await _context.Employees.FindAsync(id);

            if (employee == null) {
                return NotFound();
            }

            return Ok(employee.History.Select(x => x.Foreman).Distinct());
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> PutForeman(int id, Foreman foreman) {
            if (id != foreman.Id) {
                return BadRequest();
            }
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value.ToString();
            BaseEntityManager.WriteUpdateTags(requestAuthor, ref foreman);
            _context.Entry(foreman).State = EntityState.Modified;

            _context.Entry(foreman).Property(x => x.CreatedOn).IsModified = false;
            _context.Entry(foreman).Property(x => x.CreatedBy).IsModified = false;


            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!ForemanExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost("Create")]
        public async Task<ActionResult<Foreman>> PostForeman(Foreman foreman) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value.ToString();
            EmployeeManager.WriteCreationTags(requestAuthor, ref foreman);

            _context.Foremen.Add(foreman);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetForeman", new { id = foreman.Id }, foreman);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult<Foreman>> DeleteForeman(int id) {
            var foreman = await _context.Foremen.FindAsync(id);
            if (foreman == null) {
                return NotFound();
            }

            _context.Foremen.Remove(foreman);
            await _context.SaveChangesAsync();

            return foreman;
        }

        private bool ForemanExists(int id) {
            return _context.Foremen.Any(e => e.Id == id);
        }
    }
}
