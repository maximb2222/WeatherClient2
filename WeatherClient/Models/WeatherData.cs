using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherClient.Models;

public record WeatherData(
    double Temperature,
    double Humidity,
    double Precipitation,
    double Wind,
    WeatherType Condition
);
