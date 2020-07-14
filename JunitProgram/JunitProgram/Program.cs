using System;

namespace JunitProgram
{
    class Program
    {
        public static void Main(string[] args)
        { 
        Label: 
            try
             {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1: Vending Machine");
                    Console.WriteLine("2: Day Of Week");
                    Console.WriteLine("3: Temperature Conversion");
                    Console.WriteLine("4: Calculate Monthly Payment");
                    Console.WriteLine("5: Compute square Root");
                    Console.WriteLine("6: Binary to Decimal");
                    Console.WriteLine("7: Exit");
                    Console.WriteLine("Enter your choice");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            VendingMachine notes = new VendingMachine();
                            notes.FewestNotes();
                            break;

                        case 2:
                            DayOfWeek dayOfWeek = new DayOfWeek();
                             dayOfWeek.WeekDay();
                            break;

                        case 3:
                            TemperatureConversion temperatureConversion = new TemperatureConversion();
                             temperatureConversion.TemperatureConversions();
                            break;

                        case 4:
                            MonthlyPayment monthlyPayment = new MonthlyPayment();
                              monthlyPayment.MonthlyPay();
                            break;

                        case 5:
                            SquareRoot squareRoot = new SquareRoot();
                             squareRoot.SquareRoots();
                            break;

                        case 6:
                            DecimalToBinary decimalToBinary = new DecimalToBinary();
                             decimalToBinary.ToBinary();
                            break;
                     
                        case 7:
                            flag = false;
                            break;
                    }
}
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input" + e);
                goto Label;
            }
        }
    }
}