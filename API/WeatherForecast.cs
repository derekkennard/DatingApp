// Created by Derek Kennard (DerekKennard)
// Solution: DatingApp
// Project Name: API
// File Name: WeatherForecast.cs
// Created on: 09/26/2020 at 9:25 AM
// Edited on: 09/30/2020 at 11:32 PM
// Developed and Copyrighted by ProHealth Pharmacy Solutions, LLC.

#region imports

using System;

#endregion

namespace API
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}