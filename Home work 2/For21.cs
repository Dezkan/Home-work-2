using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For21
    {
        public static void main()
        {
            int N, x;
            bool isZero = false;

            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 0) isZero = true;
                
            }

            Console.Write((isZero)? "YES" : "NO");
        }
    }
}
