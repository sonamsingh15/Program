using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFunctionalProgram
{
    class SquareRoot
    {

        public void quadrtic()
        {

            Console.WriteLine(" Enter the second value");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Enter the third value");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = (b * b) - (4.0 * c);
            double sqroot = Math.Sqrt(discriminant);

            double root1 = (-b + sqroot) / 2.0;
            double root2 = (-b - sqroot) / 2.0;

            Console.WriteLine(root1);
            Console.WriteLine(root2);
        }
    }
}

