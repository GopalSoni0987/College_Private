using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk_4_4
{
    public class TemperatureConverter
    {
        private double celsius;

        public double Celsius
        {
            get { return celsius; }
            set { celsius = value; }
        }

        public double Fahrenheit
        {
            get
            {
                return (celsius * 9 / 5) + 32;
            }
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            TemperatureConverter converter = new TemperatureConverter();

            converter.Celsius = 25;

            double fahrenheit = converter.Fahrenheit;

            Console.WriteLine($"Celsius: {converter.Celsius}°C");
            Console.WriteLine($"Fahrenheit: {fahrenheit}°F");
        }
    }

}
