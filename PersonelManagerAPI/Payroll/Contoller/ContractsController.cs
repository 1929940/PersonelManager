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

namespace API.Payroll.Contoller {
    [Route("api/[controller]")]
    [ApiController]
    public class ContractsController : ControllerBase {
        private readonly Context _context;

        public ContractsController(Context context) {
            _context = context;
        }

        //[Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContractDTO>>> GetContracts() {
            List<Contract> list = await _context.Contracts.ToListAsync();
            return Ok(list.Select(x => ContractManager.CreateDTO(x)));
        }

        //[Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<ContractDTO>> GetContract(int id) {
            var contract = await _context.Contracts.FindAsync(id);

            if (contract == null) {
                return NotFound();
            }

            return ContractManager.CreateDTO(contract);
        }

        //[Authorize]
        [Route("EmployeeContracts")]
        [HttpGet]
        public async Task<ActionResult<Advance>> GetEmployeeContracts(int id) {
            var contracts = await _context.Contracts.Where(x => x.EmployeeId == id).ToListAsync();
            return Ok(contracts.Select(x =>ContractManager.CreateDTO(x)));
        }


        //[Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContract(int id, ContractDTO dto) {
            if (id != dto.Id) {
                return BadRequest();
            }
            var contract = await _context.Contracts.FindAsync(id);

            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();
            ContractManager.UpdateWithDTO(dto, ref contract);
            ContractManager.WriteUpdateTags(requestAuthor, ref contract);

            _context.Entry(contract).State = EntityState.Modified;
            _context.Entry(contract).Property(x => x.CreatedOn).IsModified = false;
            _context.Entry(contract).Property(x => x.CreatedBy).IsModified = false;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!ContractExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }

        //[Authorize]
        [HttpPost]
        public async Task<ActionResult<ContractDTO>> PostContract(ContractDTO dto) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();

            Contract contract = new Contract();
            ContractManager.UpdateWithDTO(dto, ref contract);
            ContractManager.WriteCreationTags(requestAuthor, ref contract);

            _context.Contracts.Add(contract);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContract", new { id = contract.Id }, ContractManager.CreateDTO(contract));
        }

        //[Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Contract>> DeleteContract(int id) {
            var contract = await _context.Contracts.FindAsync(id);
            if (contract == null) {
                return NotFound();
            }

            _context.Contracts.Remove(contract);
            await _context.SaveChangesAsync();

            return contract;
        }

        private bool ContractExists(int id) {
            return _context.Contracts.Any(e => e.Id == id);
        }
    }
}
