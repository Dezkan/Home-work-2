using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While14
    {
        public static void main()
        {
            double number, counter1 = -1, counter2 = 0;

            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                counter1++;
                counter2 += number;
            }
            while (number != 0);

            Console.WriteLine(counter2/counter1);

        }
    }
}
