using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While25
    {
        public static void main()
        {
            int number1, number2, number3, maxCounter = 0;

            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());

            if(number2 == 0)
            {
                number3 = 0;
            }
            else
            {
                number3 = Convert.ToInt32(Console.ReadLine());
            }

            

            while (number3 != 0)
            {
                if(number1 < number2 && number3 < number2)
                {
                    maxCounter++;
                }

                number1 = number2;
                number2 = number3;
                number3 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(maxCounter);
        }
    }
}
