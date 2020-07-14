using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFunctionalProgram
{
    class PrimeFactor
    {
        public void primeFactor()
        {
            int number;
            Console.WriteLine("Please enter your integer: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 2; i < number; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i + " is a factor of " + number);
                    number = number / i;
                }
            }
            if (number > 2)
            {
                Console.WriteLine(number);
            }


        }
    }

}

