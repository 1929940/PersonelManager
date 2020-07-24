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
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AdvanceController : ControllerBase {
        private readonly Context _context;

        public AdvanceController(Context context) {
            _context = context;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<AdvanceDTO>>> GetAdvances() {
            var advances = await _context.Advances.ToListAsync();
            return Ok(advances.Select(x => AdvanceManager.CreateDTO(x)));
        }

        [HttpGet("Get/{id}")]
        public async Task<ActionResult<AdvanceDTO>> GetAdvance(int id) {
            var advance = await _context.Advances.FindAsync(id);

            if (advance == null) {
                return NotFound();
            }

            return AdvanceManager.CreateDTO(advance);
        }

        [HttpGet("GetEmployeeAdvances/{id}")]
        public async Task<ActionResult<AdvanceDTO>> GetEmployeeAdvances(int id) {
            var contracts = await _context.Contracts.Where(x => x.EmployeeId == id && x.Advances.Any()).ToListAsync();
            var advances = contracts.SelectMany(x => x.Advances).Select(x => AdvanceManager.CreateDTO(x));

            return Ok(advances);
        }

        [HttpGet("GetContractAdvances/{id}")]
        public async Task<ActionResult<AdvanceDTO>> GetContractAdvances(int id) {
            var contract = await _context.Contracts.FindAsync(id);
            var advances = contract.Advances.Select(x => AdvanceManager.CreateDTO(x));

            return Ok(advances);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> PutAdvance(int id, AdvanceDTO dto) {
            if (id != dto.Id) {
                return BadRequest();
            }
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value.ToString();
            var advance = await _context.Advances.FindAsync(id);

            AdvanceManager.UpdateWithDTO(dto, ref advance);
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

        [HttpPost("Create")]
        public async Task<ActionResult<AdvanceDTO>> PostAdvances(AdvanceDTO dto) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value.ToString();

            Advance advance = new Advance();
            AdvanceManager.UpdateWithDTO(dto, ref advance);
            AdvanceManager.WriteCreationTags(requestAuthor, ref advance);

            _context.Advances.Add(advance);
            await _context.SaveChangesAsync();

            await _context.Entry(advance).Reference(x => x.Contract).LoadAsync();

            return CreatedAtAction("GetAdvances", new { id = advance.Id }, AdvanceManager.CreateDTO(advance));
        }

        [HttpDelete("Delete/{id}")]
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
