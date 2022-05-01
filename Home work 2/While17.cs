using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While17
    {
        public static void main()
        {
            double number, temp, counter = 0;

            number = Convert.ToInt32(Console.ReadLine());
            temp = number;

            while (number != 0)
            {
                number = Convert.ToInt32(Console.ReadLine());

                if (number > temp)
                {
                    counter++;
                }

                temp = number;
            }

            Console.WriteLine(counter);

        }
    }
}
