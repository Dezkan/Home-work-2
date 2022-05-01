using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For19
    {
        public static void main()
        {
            int N, x, counter = 0;

            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 0) counter++;
            }

            Console.Write(counter);
        }
    }
}
