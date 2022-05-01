using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While22
    {
        public static void main()
        {
            double number1 = -1, number2 = -1, counter = 0;

            number1 = Convert.ToInt32(Console.ReadLine());

            while (!(number1 == 0 && number2 == 0))
            {
                counter += number1;
                number2 = number1;
                number1 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(counter);
        }
    }
}
