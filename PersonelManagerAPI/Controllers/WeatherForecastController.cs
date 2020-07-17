using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using API.Business.Logic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;

namespace PersonelManagerAPI.Controllers {
    [Authorize(Roles = "Administrator")]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger) {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get() {
            //TODO: This is how to read claims
            var ww = HttpContext.User.Claims.Where(x => x.Type == ClaimTypes.Role);

            //TODO: Clean up
            //TODO: Change role to written
            //TEST AUTHORIZATION BY ROLE

            var wwz = HttpContext.Request.Body;
            //HttpContext.User.
            Request.Headers.TryGetValue("Authorization", out StringValues wzw);
            var token = wzw.FirstOrDefault().Substring(7);




            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
