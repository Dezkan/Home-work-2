using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While16
    {
        public static void main()
        {
            double number, MaxNumber;

            number = Convert.ToInt32(Console.ReadLine());
            MaxNumber = number;

            while (number != 0)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if(MaxNumber < number)
                {
                    MaxNumber = number;
                }
            }

            Console.WriteLine(MaxNumber);

        }
    }
}
