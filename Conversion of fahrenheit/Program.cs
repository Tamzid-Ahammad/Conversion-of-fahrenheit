using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_of_fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give the value of Fahrenheit");
            var Fahrenheit = Convert.ToDouble(Console.ReadLine());
            var resultForCelcius = CelciusAfterConversionToFahrenheit(Fahrenheit);
            Console.WriteLine("The result of  Celcius after converted from Fahrenheit is: " + resultForCelcius);
            Console.ReadLine();
        }
        public static double CelciusAfterConversionToFahrenheit(double Fahrenheit)
        {
            double Celcius = (Fahrenheit - 32) * 5 / 9;
            return Celcius;
        }
    }
}
