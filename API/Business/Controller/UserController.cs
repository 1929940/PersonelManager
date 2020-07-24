﻿using System.Collections.Generic;
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
    //[Authorize(Roles = "Manager,Administrator")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase {
        private readonly Context _context;
        private readonly AppSettings _appSettings;

        public UserController(Context context, IOptions<AppSettings> appSettings) {
            _context = context;
            _appSettings = appSettings.Value;
        }

        //[Authorize(Roles = "Manager,Administrator")]
        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers() {
            List<User> list = await _context.Users.ToListAsync();
            return Ok(list.Select(x => UserManager.CreateDTO(x)));
        }

        //[Authorize(Roles = "Manager,Administrator")]
        [HttpPost("Create")]
        public async Task<ActionResult<UserDTO>> CreateUser(UserDTO dto) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();

            User user = UserManager.CreateUser(dto);
            UserManager.WriteCreationTags(requestAuthor, ref user);

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Created(string.Empty, UserManager.CreateDTO(user));
        }

        //[Authorize(Roles = "Manager,Administrator")]
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateUser(int id, UserDTO dto) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();

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

        [AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<AuthenticationReponse>> AuthenticateUser(AuthenticationRequest request) {
            User user = await _context.Users.FirstOrDefaultAsync(x => x.Email == request.Login);

            if (user == null)
                return Unauthorized();

            string token = TokenManager.GenerateJwtToken(user, _appSettings);

            return Ok(new AuthenticationReponse() { Token = token });
        }


        //[Authorize(Roles = "Manager,Administrator")]
        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<User>> DeleteUser(int id) {
            var user = await _context.Users.FindAsync(id);
            if (user == null) {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private bool UserExists(int id) {
            return _context.Users.Any(e => e.Id == id);
        }

        [HttpPatch]
        [Route("RequestPasswordReset")]
        public async Task<IActionResult> RequestPasswordReset(int id) {
            User user = await _context.Users.FindAsync(id);
            if (user == null)
                return NotFound();

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

        //[Authorize(Roles = "Manager,Administrator")]
        [HttpPatch]
        [Route("UpdatePassword")]
        public async Task<IActionResult> UpdatePassword(int id, string hash) {
            User user = await _context.Users.FindAsync(id);
            if (user == null)
                return NotFound();

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