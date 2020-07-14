using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFunctionalProgram
{
    class DistanceOfTwoPoint
{
        public void distance()
        {
            int pointx1 = 0, pointx2 = 0, pointy1 = 0, pointy2 = 0;

            Console.WriteLine(" enter the x1 value");
            pointx1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" enter the x2 value");
            pointx2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" enter the y1 value");
            pointy1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" enter the y2 value");
            pointy2 = Convert.ToInt32(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(pointx2 - pointx1, 2) + Math.Pow(pointy2 - pointy1, 2));
            Console.WriteLine("Eculidian distance of point is " + distance);
        }
    }



}

        
    
