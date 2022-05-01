using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While15
    {
        public static void main()
        {
            double number, counter = -1;

            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 == 0)
                {
                    counter++;
                }
            }
            while (number != 0);

            Console.WriteLine(counter);

        }
    }
}
