using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Core.DBContext;
using API.HR.Models;
using API.HR.Helpers;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace API.HR.Controller {
        //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SafetyTrainingsController : ControllerBase {
        private readonly Context _context;
        private readonly DbSet<SafetyTraining> _set;

        public SafetyTrainingsController(Context context) {
            _context = context;
            _set = context.SafetyTrainings;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<DocumentDTO>>> GetSafetyTrainings() {
            return Ok(await DocumentControllerHelper.GetAllDocuments(_set));
        }

        [HttpGet("Get/{id}")]
        public async Task<ActionResult<DocumentDTO>> GetSafetyTraining(int id) {
            var document = await DocumentControllerHelper.GetDocument(_set, id);

            if (document == null) {
                return NotFound();
            }

            return document;
        }

        [HttpGet("GetEmployeeSafetyTrainings/{id}")]
        public async Task<ActionResult<IEnumerable<DocumentDTO>>> GetEmployeeSafetyTrainings(int id) {
            return Ok(await DocumentControllerHelper.GetEmployeesDocuments(_set, id));
        }

        //[Authorize]
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> PutSafetyTraining(int id, DocumentDTO dto) {
            if (id != dto.Id) {
                return BadRequest();
            }
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();
            await DocumentControllerHelper.PutDocument(_context, _set, id, dto, requestAuthor);

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!SafetyTrainingExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost("Create/{id}")]
        public async Task<ActionResult<DocumentDTO>> PostSafetyTraining(DocumentDTO dto) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();
            DocumentDTO result = await DocumentControllerHelper.PostDocument(_context, _set, dto, requestAuthor);

            return CreatedAtAction("GetSafetyTraining", new { id = result.Id }, result);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult<SafetyTraining>> DeleteSafetyTraining(int id) {
            var safetyTraining = await _context.SafetyTrainings.FindAsync(id);
            if (safetyTraining == null) {
                return NotFound();
            }

            _context.SafetyTrainings.Remove(safetyTraining);
            await _context.SaveChangesAsync();

            return safetyTraining;
        }

        private bool SafetyTrainingExists(int id) {
            return _context.SafetyTrainings.Any(e => e.Id == id);
        }
    }
}
