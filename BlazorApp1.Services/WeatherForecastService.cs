﻿using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public class WeatherForecastService
    {
        public static async Task<WeatherForecast[]> GetForecastsAsync() 
        {
            // Simulate asynchronous loading to demonstrate a loading indicator
            await Task.Delay(500);

            var startDate = DateOnly.FromDateTime(DateTime.Now);
            var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            }).ToArray();
        }
    }
}
