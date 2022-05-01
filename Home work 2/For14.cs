using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For14
    {
        public static void main()
        {
            int x;

            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
