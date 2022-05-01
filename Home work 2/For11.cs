using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For11
    {
        public static void main()
        {
            int x, sum = 0;

            x = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i > 0; i /= 10)
            {
                sum += i % 10;
            }

            Console.WriteLine(sum);

        }
    }
}
