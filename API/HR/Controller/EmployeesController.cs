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
    public class EmployeesController<T> : ControllerBase {
        private readonly Context _context;

        public EmployeesController(Context context) {
            _context = context;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<EmployeeDTO>>> GetEmployee() {
            var collection = await _context.Employees.ToListAsync();
            return Ok(collection.Select(x => EmployeeManager.CreateDTO(x)));
        }

        [HttpGet("Get/{id}")]
        public async Task<ActionResult<EmployeeDTO>> GetEmployee(int id) {
            var employee = await _context.Employees.FindAsync(id);

            if (employee == null) {
                return NotFound();
            }

            return EmployeeManager.CreateDTO(employee);
        }

        [Route("GetEmployeeHistory")]
        [HttpGet("Get")]
        public async Task<ActionResult<EmployeeHistory>> GetEmployeeHistory(int id) {
            var histories = await _context.EmployeesHistory.Where(x => x.EmployeeId == id).ToListAsync();

            return Ok(histories);
        }


        [HttpPut("Update/{id}")]
        public async Task<IActionResult> PutEmployee(int id, EmployeeDTO dto) {
            if (id != dto.Id)
                return BadRequest();

            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value.ToString();
            var employee = await _context.Employees.FindAsync(id);

            EmployeeManager.UpdateWithDTO(dto, ref employee);
            EmployeeManager.WriteUpdateTags(requestAuthor, ref employee);
            _context.Entry(employee).State = EntityState.Modified;
            _context.Entry(employee).Property(x => x.CreatedOn).IsModified = false;
            _context.Entry(employee).Property(x => x.CreatedBy).IsModified = false;

            EmployeeHistory last = employee.History.Last();
            EmployeeHistory newHistory = EmployeeManager.CreateEmployeeHistoryEntry(dto, last);
            if (newHistory != null) {
                EmployeeManager.WriteCreationTags(requestAuthor, ref newHistory);
                _context.EmployeesHistory.Add(newHistory);
            }

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!EmployeeExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost("Create")]
        public async Task<ActionResult<EmployeeDTO>> PostEmployee(EmployeeDTO dto) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value.ToString();

            Employee employee = new Employee();
            EmployeeManager.UpdateWithDTO(dto, ref employee);
            EmployeeManager.WriteCreationTags(requestAuthor, ref employee);

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            EmployeeHistory newHistory = EmployeeManager.CreateEmployeeHistoryEntry(dto);
            newHistory.EmployeeId = employee.Id;
            EmployeeManager.WriteCreationTags(requestAuthor, ref newHistory);
            _context.EmployeesHistory.Add(newHistory);
            await _context.SaveChangesAsync();
            employee = await _context.Employees.FindAsync(employee.Id);
            newHistory = await _context.EmployeesHistory.FindAsync(newHistory.Id);
            await _context.Foremen.FindAsync(newHistory.ForemanId);
            await _context.Locations.FindAsync(newHistory.LocationId);

            return CreatedAtAction("GetEmployee", new { id = employee.Id }, EmployeeManager.CreateDTO(employee));
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(int id) {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null) {
                return NotFound();
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return employee;
        }

        [HttpPut("ArchiveEmployee/{id}")]
        public async Task<ActionResult> PatchIsArchived(int id, bool isArchived) {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null) {
                return NotFound();
            }
            employee.IsArchived = isArchived;

            _context.Employees.Attach(employee);
            _context.Entry(employee).Property(x => x.IsArchived).IsModified = true;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeExists(int id) {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}
