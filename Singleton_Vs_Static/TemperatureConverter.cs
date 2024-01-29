using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Vs_Static
{
    internal class TemperatureConverter
    {
        public static double ConvertCelsiusToFarhenheit(string temperatureInCelsius)
        {
            return (Double.Parse(temperatureInCelsius) * 9 / 5) + 32;
        }

        public static double ConvertFarhenheitToCelsius(string temperatureInFarhenheit)
        {
            return (Double.Parse(temperatureInFarhenheit) * 5 / 9) - 32;
        }
    }
}
