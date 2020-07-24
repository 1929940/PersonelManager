using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using API.Core.DBContext;
using API.HR.Models;
using API.HR.Helpers;
using System.Security.Claims;

namespace API.HR.Controller {
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalCheckupsController : ControllerBase {
        private readonly Context _context;
        private readonly DbSet<MedicalCheckup> _set;

        public MedicalCheckupsController(Context context) {
            _context = context;
            _set = context.MedicalCheckups;
        }

        //[Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocumentDTO>>> GetMedicalCheckups() {
            return Ok(await DocumentControllerHelper.GetAllDocuments(_set));
        }


        //[Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<DocumentDTO>> GetMedicalCheckup(int id) {
            var document = await DocumentControllerHelper.GetDocument(_set, id);

            if (document == null) {
                return NotFound();
            }

            return document;
        }

        //[Authorize]
        [Route("GetEmployeeMedicalCheckups")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocumentDTO>>> GetEmployeeMedicalCheckups(int id) {
            return Ok(await DocumentControllerHelper.GetEmployeesDocuments(_set, id));
        }

        //[Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicalCheckup(int id, DocumentDTO dto) {
            if (id != dto.Id) {
                return BadRequest();
            }
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();
            await DocumentControllerHelper.PutDocument(_context, _set, id, dto, requestAuthor);

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!MedicalCheckupExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }

        //[Authorize]
        [HttpPost]
        public async Task<ActionResult<DocumentDTO>> PostMedicalCheckup(DocumentDTO dto) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();
            DocumentDTO result = await DocumentControllerHelper.PostDocument(_context, _set, dto, requestAuthor);

            return CreatedAtAction("GetMedicalCheckup", new { id = result.Id }, result);
        }

        //[Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<MedicalCheckup>> DeleteMedicalCheckup(int id) {
            var medicalCheckup = await _context.MedicalCheckups.FindAsync(id);
            if (medicalCheckup == null) {
                return NotFound();
            }

            _context.MedicalCheckups.Remove(medicalCheckup);
            await _context.SaveChangesAsync();

            return medicalCheckup;
        }

        private bool MedicalCheckupExists(int id) {
            return _context.MedicalCheckups.Any(e => e.Id == id);
        }
    }
}
