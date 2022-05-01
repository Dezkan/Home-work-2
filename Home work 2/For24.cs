using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For24
    {
        public static void main()
        {
            int N, k = 1;

            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; k <= N; i++)
            {
                for (int j = 1; j <= i && k <= N; j++)
                {
                    Console.Write(i + " ");
                    k++;
                }
            }
               


        }
    }
}
