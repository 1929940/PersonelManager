using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Core.DBContext;
using API.Payroll.Models;
using API.Payroll.Logic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace API.Payroll.Contoller {
    [Route("api/[controller]")]
    [ApiController]
    public class AdvanceController : ControllerBase {
        private readonly Context _context;

        public AdvanceController(Context context) {
            _context = context;
        }

        //[Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Advance>>> GetAdvances() {
            return await _context.Advances.ToListAsync();
        }

        // GET: api/Advances/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Advance>> GetAdvance(int id) {
            var advances = await _context.Advances.FindAsync(id);

            if (advances == null) {
                return NotFound();
            }

            return advances;
        }

        //TODO: Allows changing ContractId
        //[Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdvance(int id, Advance advance) {
            if (id != advance.Id) {
                return BadRequest();
            }
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();
            AdvanceManager.WriteUpdateTags(requestAuthor, ref advance);

            _context.Entry(advance).State = EntityState.Modified;
            _context.Entry(advance).Property(x => x.CreatedOn).IsModified = false;
            _context.Entry(advance).Property(x => x.CreatedBy).IsModified = false;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!AdvancesExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }

        //[Authorize]
        [HttpPost]
        public async Task<ActionResult<Advance>> PostAdvances(Advance advance) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();
            AdvanceManager.WriteCreationTags(requestAuthor, ref advance);

            _context.Advances.Add(advance);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdvances", new { id = advance.Id }, advance);
        }

        //[Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Advance>> DeleteAdvances(int id) {
            var advances = await _context.Advances.FindAsync(id);
            if (advances == null) {
                return NotFound();
            }

            _context.Advances.Remove(advances);
            await _context.SaveChangesAsync();

            return advances;
        }

        private bool AdvancesExists(int id) {
            return _context.Advances.Any(e => e.Id == id);
        }
    }
}
