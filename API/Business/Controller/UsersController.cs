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

    [Authorize(Roles = "Kierownik,Administrator")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase {
        private readonly Context _context;
        private readonly AppSettings _appSettings;

        public UsersController(Context context, IOptions<AppSettings> appSettings) {
            _context = context;
            _appSettings = appSettings.Value;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers() {
            List<User> list = await _context.Users.ToListAsync();
            return Ok(list.Select(x => UserManager.CreateDTO(x)));
        }

        [HttpGet("Get/{id}")]
        public async Task<ActionResult<UserDTO>> GetUser(int id) {
            var user = await _context.Users.FindAsync(id);

            if (user == null) {
                return NotFound();
            }

            return UserManager.CreateDTO(user);
        }

        [HttpPost("Create")]
        public async Task<ActionResult<UserDTO>> CreateUser(UserDTO dto) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value.ToString();

            User user = UserManager.CreateUser(dto);
            UserManager.WriteCreationTags(requestAuthor, ref user);

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            string password = PasswordResetHandler.GeneratePassword(4);
            user.Hash = password;
            _context.Entry(user).Property(x => x.Hash).IsModified = true;
            await _context.SaveChangesAsync();
            await PasswordResetHandler.Sent(_appSettings, user.Email, password);

            return Created(string.Empty, UserManager.CreateDTO(user));
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateUser(int id, UserDTO dto) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value.ToString();

            if (id != dto.Id)
                return BadRequest();

            User user = await _context.Users.FindAsync(id);
            UserManager.WriteUpdateTags(requestAuthor, ref user);

            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            user.Email = dto.Email;
            user.Role = dto.Role;
            user.IsActive = dto.IsActive;

            _context.Entry(user).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!UserExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id) {
            var user = await _context.Users.FindAsync(id);
            if (user == null) {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<ActionResult<AuthenticationReponse>> LoginUser(AuthenticationRequest request) {
            User user = await _context.Users.FirstOrDefaultAsync(x => x.Email == request.Login && x.Hash == request.Password && x.IsActive);

            if (user == null || user.IsActive == false)
                return Unauthorized();

            string token = TokenManager.GenerateJwtToken(user, _appSettings);

            return Ok(new AuthenticationReponse() {
                Token = token,
                RequestedPasswordReset = user.RequestedPasswordReset,
                Role = user.Role
            });
        }


        private bool UserExists(int id) {
            return _context.Users.Any(e => e.Id == id);
        }

        [AllowAnonymous]
        [HttpPut("RequestPasswordReset/{login}")]
        public async Task<IActionResult> RequestPasswordReset(string login) {
            User user = await _context.Users.FirstOrDefaultAsync(x => x.Email == login && x.IsActive);
            //TODO:
            //if (user == null)
            //    return NotFound();
            if (user == null)
                return NoContent();

            string password = PasswordResetHandler.GeneratePassword(4);
            await PasswordResetHandler.Sent(_appSettings, user.Email, password);

            user.RequestedPasswordReset = true;
            user.Hash = password;
            _context.Users.Attach(user);
            _context.Entry(user).Property(x => x.RequestedPasswordReset).IsModified = true;
            _context.Entry(user).Property(x => x.Hash).IsModified = true;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [Authorize]
        [HttpPut("UpdatePassword/{login}&{hash}")]
        public async Task<IActionResult> UpdatePassword(string login, string hash) {
            User user = await _context.Users.FirstOrDefaultAsync(x => x.Email == login && x.IsActive);
            if (user == null)
                return NotFound();

            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value.ToString();
            string userFullName = string.Format($"{user.FirstName} {user.LastName}");
            if (requestAuthor != userFullName) {
                return Forbid();
            }

            user.Hash = hash;
            user.RequestedPasswordReset = false;

            _context.Users.Attach(user);
            _context.Entry(user).Property(x => x.RequestedPasswordReset).IsModified = true;
            _context.Entry(user).Property(x => x.Hash).IsModified = true;

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
