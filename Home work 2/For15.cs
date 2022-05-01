using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For15
    {
        public static void main()
        {
            int x, counter = 0;

            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    counter++;
                }
            }

            Console.Write(counter);
        }
    }
}
