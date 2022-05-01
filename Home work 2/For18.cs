using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For18
    {
        public static void main()
        {
            long N;
            double answer = 0, n = 0;

            N = Convert.ToInt32(Console.ReadLine());

            for (long i = N; i > 0; i/=10)
            {
                if (i % 10 == 1)
                {
                    answer = answer + Math.Pow(2, n);
                }
                n++;
            }

            Console.Write(answer);
        }
    }
}
