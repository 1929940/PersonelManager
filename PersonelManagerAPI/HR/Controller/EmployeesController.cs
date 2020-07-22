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
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase {
        private readonly Context _context;

        public EmployeesController(Context context) {
            _context = context;
        }

        //[Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDTO>>> GetEmployee() {
            var collection = await _context.Employees.ToListAsync();
            return Ok(collection.Select(x => EmployeeManager.CreateDTO(x)));
        }

        //[Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDTO>> GetEmployee(int id) {
            var employee = await _context.Employees.FindAsync(id);

            if (employee == null) {
                return NotFound();
            }

            return EmployeeManager.CreateDTO(employee);
        }

        //[Authorize]
        [Route("GetEmployeesHistory")]
        [HttpGet]
        public async Task<ActionResult<EmployeeHistory>> GetEmployeesHistory(int id) {
            var histories = await _context.EmployeesHistory.Where(x => x.EmployeeId == id).ToListAsync();

            return Ok(histories);
        }


        //[Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, EmployeeDTO dto) {
            if (id != dto.Id)
                return BadRequest();

            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();
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

        //[Authorize]
        [HttpPost]
        public async Task<ActionResult<EmployeeDTO>> PostEmployee(EmployeeDTO dto) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();

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
            await _context.EmployeeAddresses.FindAsync(newHistory.EmployeeAddressId);

            return CreatedAtAction("GetEmployee", new { id = employee.Id }, EmployeeManager.CreateDTO(employee));
        }

        //[Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(int id) {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null) {
                return NotFound();
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return employee;
        }

        //[Authorize]
        [Route("ArchiveEmployee")]
        [HttpPatch]
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

        ////[Authorize]
        //[Route("GetAddresses")]
        //[HttpGet]
        //public async Task<ActionResult<EmployeeAddress>> GetAddresses(int id) {
        //    var employee = await _context.Employees.FindAsync(id);
        //    if (employee == null) {
        //        return NotFound();
        //    }

        //THIS NEEDS ITS OWN CONTROLLER CRUD OPERATION ARE NESSESARY

        //}

        private bool EmployeeExists(int id) {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}
