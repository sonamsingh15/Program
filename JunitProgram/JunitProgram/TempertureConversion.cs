using System;
using System.Collections.Generic;
using System.Text;

namespace JunitProgram
{
    class TemperatureConversion
    { 
        public void TemperatureConversions()
        {
           Console.WriteLine("Enter the celsius");
           double celsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Celsius to fahrenheit: " + fahrenheit);

             celsius = (fahrenheit - 32) * (5 / 9);
            Console.WriteLine("Farenheit to celsius: " + celsius);
        }
    
    }
}
