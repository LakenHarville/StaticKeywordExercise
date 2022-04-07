using System;
using System.Collections.Generic;
using System.Text;

namespace StaticKeywordExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double f)
        {
            return (f - 32) / 1.8; 
        }

        public static double CelsiusToFahrenheit(double c)
        {
            return (c * 9) / 5 + 32; 
        }
        
    }
}
