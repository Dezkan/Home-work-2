using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For20
    {
        public static void main()
        {
            int N, x, counter0 = 0, counterPoz = 0, counterNeg = 0;

            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 0) counter0++;
                if (x > 0) counterPoz++;
                if (x < 0) counterNeg++;
            }

            Console.Write(counter0 + " " + counterPoz + " " + counterNeg);
        }
    }
}
