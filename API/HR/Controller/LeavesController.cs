using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Core.DBContext;
using API.HR.Models;
using API.HR.Logic;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace API.HR.Controller {
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LeavesController : ControllerBase {
        private readonly Context _context;

        public LeavesController(Context context) {
            _context = context;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<LeaveDTO>>> GetLeaves() {
            var leaves = await _context.Leaves.ToListAsync();
            return Ok(leaves.Select(x => LeaveManager.CreateDTO(x)));
        }

        [HttpGet("Get/{id}")]
        public async Task<ActionResult<LeaveDTO>> GetLeave(int id) {
            var leave = await _context.Leaves.FindAsync(id);

            if (leave == null) {
                return NotFound();
            }

            return LeaveManager.CreateDTO(leave);
        }

        [HttpGet("GetEmployeeLeaves/{id}")]
        public async Task<ActionResult<LeaveDTO>> GetEmployeeLeaves(int id) {
            var employee = await _context.Employees.FindAsync(id);

            if (employee == null) {
                return NotFound();
            }

            return Ok(employee.Leaves.Select(x => LeaveManager.CreateDTO(x)));
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> PutLeave(int id, LeaveDTO dto) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();
            if (id != dto.Id) {
                return BadRequest();
            }
            var leave = await _context.Leaves.FindAsync(id);

            LeaveManager.UpdateWithDTO(dto, ref leave);
            LeaveManager.WriteUpdateTags(requestAuthor, ref leave);
            _context.Entry(leave).State = EntityState.Modified;
            _context.Entry(leave).Property(x => x.CreatedOn).IsModified = false;
            _context.Entry(leave).Property(x => x.CreatedBy).IsModified = false;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!LeaveExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost("Create/{id}")]
        public async Task<ActionResult<LeaveDTO>> PostLeave(LeaveDTO dto) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();

            Leave leave = new Leave();
            LeaveManager.UpdateWithDTO(dto, ref leave);
            LeaveManager.WriteCreationTags(requestAuthor, ref leave);

            _context.Leaves.Add(leave);
            await _context.SaveChangesAsync();
            await _context.Employees.FindAsync(leave.EmployeeId);

            return CreatedAtAction("GetLeave", new { id = leave.Id }, LeaveManager.CreateDTO(leave));
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult<Leave>> DeleteLeave(int id) {
            var leave = await _context.Leaves.FindAsync(id);
            if (leave == null) {
                return NotFound();
            }

            _context.Leaves.Remove(leave);
            await _context.SaveChangesAsync();

            return leave;
        }

        private bool LeaveExists(int id) {
            return _context.Leaves.Any(e => e.Id == id);
        }
    }
}
