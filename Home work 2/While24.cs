using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While24
    {
        public static void main()   
        {
            int  tempLength = 1, maxLength = 0, number1, number2;

            number1 = Convert.ToInt32(Console.ReadLine());

            while(number1 != 0)
            {
                number2 = Convert.ToInt32(Console.ReadLine());
                if (number1 == number2)
                {
                    tempLength++;
                }
                else if(tempLength > maxLength)
                {
                    maxLength = tempLength;
                    tempLength = 1;
                }

                number1 = number2;
            }

            Console.WriteLine(maxLength);
        }
    }
}
