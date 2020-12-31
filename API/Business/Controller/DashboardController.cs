using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Business.Logic;
using API.Business.Models;
using API.Core.DBContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Business.Controller {

    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase {
        private readonly Context _context;

        public DashboardController(Context context) {
            _context = context;
        }

        [HttpGet("GetDashboard")]
        public async Task<ActionResult<IEnumerable<DashboardDTO>>> GetDashboard(string from, string to) {
            if (!DateTime.TryParse(from, out DateTime dateFrom) || !DateTime.TryParse(to, out DateTime dateTo)) 
                return BadRequest("Parameters are not valid dates.");

            //Should get all active employees and those that have an active contract

            var contract = _context.Contracts.Where(x => x.ValidFrom >= dateFrom && x.ValidTo <= dateTo).ToList();
            var configuration = await _context.ConfigurationPage.FindAsync(1);

            return Ok(contract.Select(x => DashboardManager.CreateDashboardDTO(x, configuration)));
        }

    }
}
