using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While23
    {
        public static void main()
        {
            int temp = -1, tempLength = 0, maxLength = 0, number;

            number = Convert.ToInt32(Console.ReadLine());

            while(number != 0)
            {
                if(temp == number)
                {
                    tempLength++;
                }
                else
                {
                    temp = number;
                    maxLength = Max(maxLength, tempLength);
                    tempLength = 1;
                }

                number = Convert.ToInt32(Console.ReadLine());
            }
            maxLength = Max(maxLength, tempLength);

            Console.WriteLine(maxLength); 
        }

        public static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else return b;
        }
    }
}
