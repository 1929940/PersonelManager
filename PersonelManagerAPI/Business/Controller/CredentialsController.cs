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

        [HttpPost]
        public async Task<ActionResult<Credential>> PostCredential(AuthenticationRequest request) {
            Credential credential = await _context.Credential.FirstOrDefaultAsync(x => x.Email == request.Login);

            if (credential == null)
                return Unauthorized();

            string Token = TokenManager.GenerateJwtToken(credential, _appSettings);

            return Ok(Token);
        }



        // GET: api/Credentials
        [Authorize(Roles = "Manager,Administrator")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CredentialDTO>>> GetCredential() {
            return await _context.Credential.Select(x => new CredentialDTO(x)).ToListAsync();
        }

        // GET: api/Credentials/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Credential>> GetCredential(int id) {
        //    var credential = await _context.Credential.FindAsync(id);

        //    if (credential == null) {
        //        return NotFound();
        //    }

        //    return credential;
        //}

        // PUT: api/Credentials/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCredential(int id, CredentialDTO credential) {
            if (id != credential.Id) {
                return BadRequest();
            }

            //TODO: UPDATE ONLY THOSE FIELDS FROM DTO

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



        // DELETE: api/Credentials/5
        [HttpDelete("{id}")]
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

        //ADD PATCH TO UPDATE PASSWORD

        //ADD PATCH TO RESET PASSWORD
    }
}
