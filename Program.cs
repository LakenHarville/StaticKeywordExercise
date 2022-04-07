using System;

namespace StaticKeywordExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(43);
            Console.WriteLine($"Celsius = {celsius}");
            Console.WriteLine();

            var fahrenheit = TempConverter.CelsiusToFahrenheit(6.111);
            Console.WriteLine($"Fahrenheit = {fahrenheit}");
        }
    }
}
