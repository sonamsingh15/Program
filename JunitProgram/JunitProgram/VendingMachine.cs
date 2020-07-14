using java.lang;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace JunitProgram
{
    class VendingMachine
    {
        public void FewestNotes()
        {
            Console.WriteLine("Enter the amount:");
            int cash = Convert.ToInt32(Console.ReadLine());

            int[] a = { 2000, 500, 100, 50, 20, 10, 5, 2, 1 };

            for (int i = a.Length - 1; i >= 0; i--)
            {
                int note = 0;
                while (cash >= a[i])
                {
                    cash = cash - a[i];
                    note = note + 1;
                }
                if (note > 0)
                {
                    Console.WriteLine(a[i] + "number of notes" + note);


                 }
            }
        }
    }
}  