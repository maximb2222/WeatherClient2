using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;
using WeatherClient.Models;

namespace WeatherClient;

public class WeatherImageConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is WeatherType weather)
        {
            return weather == WeatherType.Sunny ? "sunny.png" : "cloudy.png";
        }
        return "question.png";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}