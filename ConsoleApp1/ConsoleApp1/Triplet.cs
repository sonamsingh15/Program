using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFunctionalProgram
{
    class Triplet
    {
        public void SumOfZero()
        {
            int[] array = { 0, -1, 2, -3, 1, -5, 6 };
            int i, j, k;

            for (i = 0; i < array.Length; i++)
            {
                for (j = i + 1; j < array.Length; j++)
                {
                    for (k = j + 1; k < array.Length; k++)
                    {
                        if (array[i] + array[j] + array[k] == 0)
                        {
                            Console.WriteLine("{0},{1},{2}", array[i], array[j], array[k]);
                        }
                    }
                }
            }
        }
    }
}

