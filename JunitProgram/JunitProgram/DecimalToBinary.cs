using System;
using System.Collections.Generic;
using System.Text;

namespace JunitProgram
{
    class DecimalToBinary
    {
        public int ToBinary()
        {

            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            int quot;
            string rem = "";

            while (num >= 1)
            {
                quot = num / 2;
                rem += (num % 2).ToString();
                num = quot;
            }

            string binary = "";
            for (int i = rem.Length - 1; i >= 0; i--)
            {
                binary = binary + rem[i];
            }

            Console.WriteLine("Decimal to binary representation of the given number is: " + binary);
            int stringToInt = 0;
            stringToInt = Convert.ToInt32(binary);
            return stringToInt;
        }

    }
}
