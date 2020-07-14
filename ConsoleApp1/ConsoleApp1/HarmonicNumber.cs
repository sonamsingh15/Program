using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFunctionalProgram
{
    class HarmonicNumber
    {
        static double nthHarmonic(int N)
        {
            float harmonic = 1;
            for (int i = 2; i <= N; i++)
            {
                harmonic += (float)1 / i;
            }
            return harmonic;
        }

         public void HarmonicSeries()
        {
            int N = 8;

            Console.Write(nthHarmonic(N));
        }
    }
}