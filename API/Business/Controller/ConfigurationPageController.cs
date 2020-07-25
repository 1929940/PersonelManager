using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Business.Models;
using API.Core.DBContext;
using API.Business.Logic;
using System.Security.Claims;
using API.Core.Logic;
using Microsoft.AspNetCore.Authorization;

namespace API.Business.Controller {
    [Authorize(Roles = "Kierownik,Administrator")]
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationPageController : ControllerBase {
        private readonly Context _context;

        public ConfigurationPageController(Context context) {
            _context = context;
        }

        [HttpGet("Get/{id}")]
        public async Task<ActionResult<ConfigurationPage>> GetConfigurationPage(int id) {
            var configurationPage = await _context.ConfigurationPage.FindAsync(id);

            if (configurationPage == null) {
                string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value.ToString();

                configurationPage = new ConfigurationPage();
                BaseEntityManager.WriteCreationTags(requestAuthor, ref configurationPage);
                _context.ConfigurationPage.Add(configurationPage);
                await _context.SaveChangesAsync();
            }

            return configurationPage;
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> PutConfigurationPage(ConfigurationPage configurationPage) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value.ToString();

            ConfigurationPageManager.WriteUpdateTags(requestAuthor, ref configurationPage);
            configurationPage.Id = 1;
            _context.Entry(configurationPage).State = EntityState.Modified;
            _context.Entry(configurationPage).Property(x => x.CreatedOn).IsModified = false;
            _context.Entry(configurationPage).Property(x => x.CreatedBy).IsModified = false;

            try {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
                if (!ConfigurationPageExists(1)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }

        private bool ConfigurationPageExists(int id) {
            return _context.ConfigurationPage.Any(e => e.Id == id);
        }
    }
}
