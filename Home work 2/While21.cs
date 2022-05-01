using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While21
    {
        public static void main()
        {
            double max = 0, maxcounter = 0, number = -1;


            number = Convert.ToInt32(Console.ReadLine());

            while (number != 0)
            {
                number = Convert.ToInt32(Console.ReadLine());

                if (number > max)
                {
                    max = number;
                    maxcounter = 1;

                }
                else if (number == max)
                {
                    maxcounter++;
                }
            }

            Console.WriteLine(maxcounter);

        }
    }
}
