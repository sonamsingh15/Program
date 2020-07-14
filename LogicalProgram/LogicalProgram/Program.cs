using System;
using System.Reflection.Emit;

namespace LogicalProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
        Label: try
            {

                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1: Gambler Program");
                    Console.WriteLine("2: Coupon Numbers");
                    Console.WriteLine("3: simulate StopWatch");
                    Console.WriteLine("4: Exit");
                    Console.WriteLine("Enter your choice");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Gambler gambler = new Gambler();
                            gambler.GamblerProgram();
                            break;
                        case 2:
                            CouponNumber couponNumbers = new CouponNumber();
                            couponNumbers.coupan();
                            break;
                        case 3:
                            SimulateStopWatch stopWatch = new SimulateStopWatch();
                            stopWatch.SimulateStopwatch();
                            break;

                        case 4:
                            flag = false;
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter valid Input" + e);
            }
        }
    }
}