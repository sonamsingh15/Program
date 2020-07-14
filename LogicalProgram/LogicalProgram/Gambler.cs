using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgram
{
    class Gambler
    {
        public void GamblerProgram()
        {
            int stake,goals,trials;
            int bets = 0;
            int wins = 0;
            Console.WriteLine("Enter your stake:");
            stake = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your trails:");
            trials = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your goal:");
            goals = Convert.ToInt32(Console.ReadLine());

            for (int t = 0; t < trials; t++)
            {
                int cash = stake;
                while (cash > 0 && cash < goals)
                {
                    bets++;

                    Random rand = new Random();
                    double random = rand.Next(0, 1);

                    if (random < 0.5)
                    {
                        cash++;
                    }
                    else
                    {
                        cash--;
                    }
                }

                if (cash == goals)
                    wins++;
            }

            Console.WriteLine(wins + " wins of " + trials);
            Console.WriteLine("Percent of games won = " + 100.0 * wins / trials);
            Console.WriteLine("Avg # bets           = " + 1.0 * bets / trials);
        }
    }

}
