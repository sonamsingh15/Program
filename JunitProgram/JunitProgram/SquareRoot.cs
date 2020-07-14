﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JunitProgram
{
    class SquareRoot
    {
        public void SquareRoots()
        {
            Console.WriteLine("Enter the number");
            double c = Convert.ToDouble(Console.ReadLine());
           
             double epsilon = 1e-15;
            double t = c;
             while (Math.Abs((t - c) / t) > (epsilon * t))
            {
                t = (c / (t + t)) / 2.0;
            }

            Console.WriteLine(t);
        }

    }
}
