using System;

namespace BasicFunctionalProgram
{
    class Program
    {
             static void Main(string[] args)
            {
                bool flag = true;
                while (flag)
                {

                    Console.WriteLine("Enter Your choice");
                    Console.WriteLine("1: Power of 2");
                    Console.WriteLine("2: Harmonic Series");
                    Console.WriteLine("3: Prime Factors");
                    Console.WriteLine("4: Triplet");
                    Console.WriteLine("5: Distance between Two pole");
                    Console.WriteLine("6: Square Root");
                    Console.WriteLine("7: Wind Chill");

                     Console.WriteLine("8: Exit");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                       
                        case 1:
                            PowerOfTwo power = new PowerOfTwo();
                        power.powerOf2();
                            break;
                        case 2:
                        HarmonicNumber series = new HarmonicNumber();
                            series.HarmonicSeries();
                            break;
                        case 3:
                        PrimeFactor factors = new PrimeFactor();
                            factors.primeFactor();
                            break;

                        case 4:
                        Triplet triplet = new Triplet();
                        triplet.SumOfZero();
                        break;

                        case 5:
                        DistanceOfTwoPoint distanceOf = new DistanceOfTwoPoint();
                        distanceOf.distance();
                        break;

                    case 6:
                        SquareRoot square = new SquareRoot();
                        square.quadrtic();
                        break;

                    case 7:
                        WindChill wind = new WindChill();
                        wind.wind();
                        break;

                     case 8:
                            flag = false;
                            break;
                    }
                }
            }
        }

    
    }


