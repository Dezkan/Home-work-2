using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While12
    {
        public static void main()
        {
            double number, counter = -1;

            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                counter++;
            }
            while (number != 0);

            Console.WriteLine(counter);

        }
    }
}
