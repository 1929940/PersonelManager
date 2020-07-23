using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Core.DBContext;
using API.HR.Models;
using Microsoft.AspNetCore.Authorization;
using API.HR.Logic;
using API.HR.Helpers;
using System.Security.Claims;

namespace API.HR.Controller {
    [Route("api/[controller]")]
    [ApiController]
    public class CertificatesController : ControllerBase {
        private readonly Context _context;
        private readonly DbSet<Certificate> _set;

        public CertificatesController(Context context) {
            _context = context;
            _set = context.Certificates;
        }

        //[Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocumentDTO>>> GetCertificates() {
            return Ok(await DocumentControllerHelper.GetAllDocuments(_set));
        }


        //[Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<DocumentDTO>> GetCertificate(int id) {
            var document = await DocumentControllerHelper.GetDocument(_set, id);

            if (document == null) {
                return NotFound();
            }

            return document;
        }

        //[Authorize]
        [Route("GetEmployeeCertificates")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocumentDTO>>> GetEmployeeCertificates(int id) {
            return Ok(await DocumentControllerHelper.GetEmployeesDocuments(_set, id));
        }

        //[Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCertificate(int id, DocumentDTO dto) {
            if (id != dto.Id) {
                return BadRequest();
            }
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();
            await DocumentControllerHelper.PutDocument(_context, _set, id, dto, requestAuthor);

            //DOES THIS SAVE?
            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!CertificateExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }

        //[Authorize]
        [HttpPost]
        public async Task<ActionResult<DocumentDTO>> PostCertificate(DocumentDTO dto) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();
            DocumentDTO result = await DocumentControllerHelper.PostDocument(_context, _set, dto, requestAuthor);

            //_context.Certificates.Add(certificate);
            //await _context.SaveChangesAsync();

            return CreatedAtAction("GetCertificate", new { id = result.Id }, result);
        }

        //[Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Certificate>> DeleteCertificate(int id) {
            var certificate = await _context.Certificates.FindAsync(id);
            if (certificate == null) {
                return NotFound();
            }

            _context.Certificates.Remove(certificate);
            await _context.SaveChangesAsync();

            return certificate;
        }

        private bool CertificateExists(int id) {
            return _context.Certificates.Any(e => e.Id == id);
        }
    }
}
