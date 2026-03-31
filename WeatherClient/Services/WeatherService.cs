using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherClient.Models;

namespace WeatherClient.Services;

public static class WeatherService
{
    public static async Task<WeatherData> GetWeather(string postalCode)
    {
        await Task.Delay(1000); 

        var random = new Random(postalCode.GetHashCode());

        return new WeatherData(
    Temperature: random.Next(-10, 35),
    Humidity: random.Next(30, 90),
    Precipitation: random.Next(0, 20),
    Wind: random.Next(0, 30),
    Condition: random.Next(0, 2) == 0 ? WeatherType.Sunny : WeatherType.Cloudy);
    }
}
