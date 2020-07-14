using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFunctionalProgram
{
	class PowerOfTwo
	{

		public void powerOf2()
		{
			int power = 1;

			for (int i = 1; i <= 31; i++)
			{
				power = power * 2;
				Console.WriteLine("2^" + i + "=" + power);


			}


		}
	}
}
