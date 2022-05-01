using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For23
    {
        public static void main()
        {
            double a, b, c, d;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            for (int i = 1000; i >= 0; i--)
            {
                if ((a * i * i * i + b * i * i + c * i + d) == 0)
                    Console.Write(i + " ");
            }
        }
    }
}
