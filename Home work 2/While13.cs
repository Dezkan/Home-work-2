using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While13
    {
        public static void main()
        {
            double number, counter = 0;

            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                counter+=number;
            }
            while (number != 0);

            Console.WriteLine(counter);

        }
    }
}
