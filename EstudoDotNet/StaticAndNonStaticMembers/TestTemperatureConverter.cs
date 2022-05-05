using System;

namespace EstudoDotNet.StaticAndNonStaticMembers
{
    public static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(string temperatureCelsius)
        {
            double celsius = Double.Parse(temperatureCelsius);

            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;
        }

        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
            double fahrenheit = Double.Parse(temperatureFahrenheit);

            double celsius = (fahrenheit - 32) * 5 / 9;

            return celsius;
        }
    }

    class TestTemperatureConverter
    {
        static void Main(string[] args)
        {
            double F, C = 0;

            Console.WriteLine("Please select the convertor direction");
            Console.WriteLine("1. From Celsius to Fahrenheit");
            Console.WriteLine("2. From Fahrenheit to Celsius");
            Console.Write(":");

            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    Console.WriteLine("Please enter the Celsius temperature");
                    F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                    Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                    break;

                case "2":
                    Console.WriteLine("Please enter the Fahrenheit temperature");
                    C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                    Console.WriteLine("Temperature in Celsius: {0:F3}", C);
                    break;

                default:
                    Console.WriteLine("Please select a convertor");
                    break;
            }

            Console.WriteLine("Press any key to exit");

            Console.ReadLine();
        }
    }
}
