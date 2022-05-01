using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For17
    {
        public static void main()
        {
            int N, x, sum = 0;

            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                sum += x;
            }

            Console.Write(sum);
        }
    }
}
