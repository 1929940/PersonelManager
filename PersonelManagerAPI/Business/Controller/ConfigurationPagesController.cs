﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Business.Models;
using API.Core.DBContext;

namespace API.Business.Controller {
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationPagesController : ControllerBase {
        private readonly Context _context;

        public ConfigurationPagesController(Context context) {
            _context = context;
        }

        //[Authorize(Roles = "Manager,Administrator")]
        [HttpGet]
        public async Task<ActionResult<ConfigurationPage>> GetConfigurationPage() {
            var configurationPage = await _context.ConfigurationPage.FindAsync(1);

            if (configurationPage == null) {
                return NotFound();
            }

            return configurationPage;
        }

        //[Authorize(Roles = "Manager,Administrator")]
        [HttpPut]
        public async Task<IActionResult> PutConfigurationPage(ConfigurationPage configurationPage) {

            _context.Entry(configurationPage).State = EntityState.Modified;

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
