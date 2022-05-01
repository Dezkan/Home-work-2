using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For8
    {
        public static void main()
        {
            int a, b, c, d;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());


            for (int i = a; i <= b; i++)
            {
                if(i % d == c)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
