using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LogicalProgram
{
    class SimulateStopWatch
    {
        public void SimulateStopwatch()
        {
            Stopwatch stopWatch = new Stopwatch();
            int choice;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1:  Start Timer\n2:  Stop Timer\n3:  Elapsed Time Between start & end\n4:  Quit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        stopWatch.Start();
                        break;
                    case 2:
                        stopWatch.Stop();
                        break;
                    case 3:
                        Console.WriteLine(stopWatch.Elapsed);
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}