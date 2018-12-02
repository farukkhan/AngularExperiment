using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularAspNetCore.Entities;
using AngularAspNetCore.Filters;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AngularAspNetCore.Controllers
{
    [Route("api/sampledata")]
    public class SampleDataController : Controller
    {
        IMapper _mapper;
        public SampleDataController(IMapper mapper)
        {
            _mapper = mapper;
        }
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [WeatherForeCastsResultFilter]
        [HttpGet("forecast")]
        public async Task<IActionResult> WeatherForecasts()
        {
            var rng = new Random();
            return Ok(Enumerable.Range(1, 5).Select(index => new WeatherForeCast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }));
        }

        [WeatherForeCastResultFilter]
        [HttpGet("forecast/{type}")]
        public async Task<IActionResult> WeatherForecast(string type)
        {
            var rng = new Random();
            var foreCast = Enumerable.Range(1, 5).Select(index => new WeatherForeCast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).FirstOrDefault(forecast=> forecast.Summary.Contains(type));
            

            return Ok(foreCast);
        }



    }
}
