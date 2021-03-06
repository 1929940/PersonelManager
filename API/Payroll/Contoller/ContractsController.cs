﻿using System.Collections.Generic;
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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ContractsController : ControllerBase {
        private readonly Context _context;

        public ContractsController(Context context) {
            _context = context;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<ContractDTO>>> GetContracts() {
            List<Contract> contracts = await _context.Contracts.ToListAsync();
            return Ok(contracts.Select(x => ContractManager.CreateDTO(x)));
        }

        [HttpGet("Get/{id}")]
        public async Task<ActionResult<ContractDTO>> GetContract(int id) {
            var contract = await _context.Contracts.FindAsync(id);

            if (contract == null) {
                return NotFound();
            }

            return ContractManager.CreateDTO(contract);
        }

        [HttpGet("GetEmployeeContracts/{id}")]
        public async Task<ActionResult<ContractDTO>> GetEmployeeContracts(int id) {
            var contracts = await _context.Contracts.Where(x => x.EmployeeId == id).ToListAsync();
            return Ok(contracts.Select(x => ContractManager.CreateDTO(x)));
        }


        [HttpPut("Update/{id}")]
        public async Task<IActionResult> PutContract(int id, ContractDTO dto) {
            if (id != dto.Id) {
                return BadRequest();
            }
            var contract = await _context.Contracts.FindAsync(id);

            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value.ToString();
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

        [HttpPost("Create")]
        public async Task<ActionResult<ContractDTO>> PostContract(ContractDTO dto) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value.ToString();

            Contract contract = new Contract();
            ContractManager.UpdateWithDTO(dto, ref contract);
            ContractManager.WriteCreationTags(requestAuthor, ref contract);
            if (string.IsNullOrEmpty(contract.Number))
                contract.Number = ContractManager.GenerateContractNumber(contract, _context);

            _context.Contracts.Add(contract);
            await _context.SaveChangesAsync();
            await _context.Entry(contract).Reference(x => x.Employee).LoadAsync();

            return CreatedAtAction("GetContract", new { id = contract.Id }, ContractManager.CreateDTO(contract));
        }

        [HttpDelete("Delete/{id}")]
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

        [HttpGet("GetContractsDictionary")]
        public async Task<ActionResult<Dictionary<int, string>>> GetContractsDictionary() {
            var contracts = await _context.Contracts.Where(x => !x.IsRealized).ToListAsync();
            return Ok(contracts.ToDictionary(x => x.Id, x => ContractManager.GetHeaderValue(x)));
        }

        [HttpGet("GetContractAdvanceData/{id}")]
        public async Task<ActionResult<ContractAdvanceData>> GetContractAdvanceData(int id) {
            var contract = await _context.Contracts.FindAsync(id);

            if (contract == null)
                return NotFound();

            var configPage = await _context.ConfigurationPage.FindAsync(1);

            return ContractManager.CreateContractAdvanceData(contract, configPage);
        }
    }
}
