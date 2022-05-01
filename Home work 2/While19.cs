using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While19
    {
        public static void main()
        {
            double max1, max2, number, temp;

            max1 = Convert.ToInt32(Console.ReadLine());
            max2 = Convert.ToInt32(Console.ReadLine());

            if (max1 < max2)
            {
                temp = max1;
                max1 = max2;
                max2 = temp;
            }

            number = Convert.ToInt32(Console.ReadLine());

            while (number != 0)
            {
                if (number > max1)
                {
                    max2 = max1;
                    max1 = number;
                }
                else if (number > max2)
                {
                    max2 = number;
                }

                number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(max2);

        }
    }
}
