using System;
using System.Collections.Generic;
using System.Text;

namespace JunitProgram
{
    class MonthlyPayment
    {
        public void MonthlyPay()
        {
            Console.WriteLine("Enter the Principal amount");
             double principal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the number of years");
            double year = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the rate of intertest");
            double interest = Convert.ToDouble(Console.ReadLine());

            double n = 12 * year;
            double r = interest / (12 * 100);
            double numerator = principal * r;
            double denomerator = 1 - (Math.Pow((1 + r), -n));
            double payment = numerator / denomerator;
            Console.WriteLine("Monthly Payment is:  " + payment);
        }
    }
  }

   