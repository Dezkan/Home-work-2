using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For16
    {
        public static void main()
        {
            int x, sum = 0;

            for (int i = 0; i < 100; i++)

            {
                x = Convert.ToInt32(Console.ReadLine());
                sum += x;
            }

            Console.Write(sum);
        }
    }
}
