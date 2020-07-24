using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Business.Models;
using API.Core.DBContext;
using API.Business.Logic;
using System.Security.Claims;
using API.Core.Logic;

namespace API.Business.Controller {
    //[Authorize(Roles = "Manager,Administrator")]
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationPagesController : ControllerBase {
        private readonly Context _context;

        public ConfigurationPagesController(Context context) {
            _context = context;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<ConfigurationPage>> GetConfigurationPage() {
            var configurationPage = await _context.ConfigurationPage.FindAsync(1);

            if (configurationPage == null) {
                string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();

                configurationPage = new ConfigurationPage();
                BaseEntityManager.WriteCreationTags(requestAuthor, ref configurationPage);
                _context.ConfigurationPage.Add(configurationPage);
                await _context.SaveChangesAsync();
            }

            return configurationPage;
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> PutConfigurationPage(ConfigurationPage configurationPage) {
            string requestAuthor = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.ToString();

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
