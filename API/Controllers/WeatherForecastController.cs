// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: WeatherForecastController.cs
// Created on: 09/26/2020 at 9:25 AM
// Edited on: 09/30/2020 at 11:32 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

#region imports

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

#endregion

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        // The Web API will only accept tokens 1) for users, and 2) having the "access_as_user" scope for this API
        private static readonly string[] scopeRequiredByApi = {"access_as_user"};

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                })
                .ToArray();
        }
    }
}