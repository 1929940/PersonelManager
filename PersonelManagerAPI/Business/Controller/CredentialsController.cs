using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Business.Models;
using API.Core.DBContext;
using API.Business.Logic;
using Microsoft.Extensions.Options;
using API.Business.Helpers;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace API.Business.Controller {
    [Route("api/[controller]")]
    [ApiController]
    public class CredentialsController : ControllerBase {
        private readonly Context _context;
        private readonly AppSettings _appSettings;

        public CredentialsController(Context context, IOptions<AppSettings> appSettings) {
            _context = context;
            _appSettings = appSettings.Value;
        }


        //[Authorize(Roles = "Manager,Administrator")]
        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<CredentialDTO>>> GetCredential() {
            return await _context.Credential.Select(x => new CredentialDTO(x)).ToListAsync();
        }


        [HttpPost("Create")]
        public async Task<ActionResult<CredentialDTO>> CreateCredential(CredentialDTO dto) {
            string user = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();

            Credential credential = new Credential() {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.LastName,
                Role = dto.Role,
                CreatedOn = DateTime.Now,
                CreatedBy = user,
                IsActive = true,
                RequestedPasswordReset = true,
            };

            _context.Credential.Add(credential);
            await _context.SaveChangesAsync();

            return Created(string.Empty, new CredentialDTO(credential));
        }



        //[Authorize(Roles = "Manager,Administrator")]
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> PutCredential(int id, CredentialDTO dto) {
            if (id != dto.Id) {
                return BadRequest();
            }
            Credential credential = await _context.Credential.FindAsync(id);

            credential.FirstName = dto.FirstName;
            credential.LastName = dto.LastName;
            credential.Email = dto.Email;
            credential.Role = dto.Role;
            credential.IsActive = dto.IsActive;

            _context.Entry(credential).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!CredentialExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }

        //[Authorize(Roles = "Manager,Administrator")]
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<AuthenticationReponse>> PostCredential(AuthenticationRequest request) {
            Credential credential = await _context.Credential.FirstOrDefaultAsync(x => x.Email == request.Login);

            if (credential == null)
                return Unauthorized();

            string token = TokenManager.GenerateJwtToken(credential, _appSettings);

            return Ok(new AuthenticationReponse() { Token = token});
        }


        //[Authorize(Roles = "Manager,Administrator")]
        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<Credential>> DeleteCredential(int id) {
            var credential = await _context.Credential.FindAsync(id);
            if (credential == null) {
                return NotFound();
            }

            _context.Credential.Remove(credential);
            await _context.SaveChangesAsync();

            return credential;
        }

        private bool CredentialExists(int id) {
            return _context.Credential.Any(e => e.Id == id);
        }

        //[Authorize(Roles = "Manager,Administrator")]
        [HttpPatch]
        [Route("RequestPasswordReset")]
        public async Task<IActionResult> RequestPasswordReset(int id) {
            Credential credential = await _context.Credential.FindAsync(id);
            if (credential == null)
                return NotFound();

            credential.RequestedPasswordReset = true;
            _context.Credential.Attach(credential);
            _context.Entry(credential).Property(x => x.RequestedPasswordReset).IsModified = true;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        //[Authorize(Roles = "Manager,Administrator")]
        [HttpPatch]
        [Route("UpdatePassword")]
        public async Task<IActionResult> UpdatePassword(int id, string hash) {
            Credential credential = await _context.Credential.FindAsync(id);
            if (credential == null)
                return NotFound();

            credential.Hash = hash;
            credential.RequestedPasswordReset = false;

            _context.Credential.Attach(credential);
            _context.Entry(credential).Property(x => x.RequestedPasswordReset).IsModified = true;
            _context.Entry(credential).Property(x => x.Hash).IsModified = true;

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
