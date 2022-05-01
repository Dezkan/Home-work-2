using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For10
    {
        public static void main()
        {
            int x, d, counter = 0;

            x = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i > 0; i/=10)
            {
                if (i%10 == d)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);

        }
    }
}
