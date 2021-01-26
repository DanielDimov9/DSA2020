using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8.Factoriel
{
    public static class Factoriel
    {
        public static long RecursiveFactoriel(long N)
        {
            if (N == 0)
            {
                return 1;
            }
            else
            {
                return N * RecursiveFactoriel(N - 1);
            }
        }

        public static long IterativeFactoriel(int N)
        {
            long result = 1;
            for (int i = 1; i <= N; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
