using com.sun.org.apache.xml.@internal.resolver.helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace JunitProgram
{
    class DayOfWeek
    {
        public void WeekDay()
        {
            Console.WriteLine("Enter the month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the date");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year");
            int year = Convert.ToInt32(Console.ReadLine());


            int y = 0, x = 0, m = 0, d = 0;
            y = year - ((14 - month) / 12);
            x = (y + (y / 4) - (y / 100) + (y / 400));
            m = month + 12 * ((14 - month) / 12) - 2;
            d = (day + x + 31 * month / 12) % 7;
            Console.WriteLine("Day of Week" + d);
            switch (d)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednasday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
    }
}