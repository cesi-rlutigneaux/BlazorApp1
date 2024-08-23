using BlazorApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastsAsync();
    }
}
