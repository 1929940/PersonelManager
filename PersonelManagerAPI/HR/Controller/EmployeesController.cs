using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Core.DBContext;
using API.HR.Models;
using System.Globalization;
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
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, EmployeeDTO dto) {
            if (id != dto.Id) 
                return BadRequest();
            
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();

            Employee employee = new Employee();
            EmployeeManager.UpdateWithDTO(dto, ref employee);
            EmployeeManager.WriteUpdateTags(requestAuthor, ref employee);
            _context.Entry(employee).State = EntityState.Modified;

            EmployeeHistory last = employee.History.Last();
            EmployeeHistory newHistory = EmployeeManager.CreateEmployeeHistoryEntry(dto, last);
            if (newHistory != null) {
                EmployeeManager.WriteCreationTags(requestAuthor, ref newHistory);
                //_context.Employees.
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

        // POST: api/Employees
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee) {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployee", new { id = employee.Id }, employee);
        }

        // DELETE: api/Employees/5
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

        private bool EmployeeExists(int id) {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}
