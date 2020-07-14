using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFunctionalProgram
{
    class WindChill
{
		public void wind()
		{
			Console.WriteLine("Enter the temperature in Fahrenheit: ");
			double temp = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the wind speed miles per hour: ");
			double speed = Convert.ToInt32(Console.ReadLine());

			double Index = calculateIndex(temp, speed);
			Console.WriteLine("The wind chill index is " + Index);
		}

		public static double calculateIndex(double t, double v)
		{
			double Index = (35.74 + 0.6215 * t - 35.75 * Math.Pow(v, 0.16) + 0.4275 * t * Math.Pow(v, 0.16));
			return Index;
		}
	}

}
