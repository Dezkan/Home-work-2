using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While10
    {
        public static void main()
        {
            double number1 = 0, number2 = 0;

            try
            {
                number1 = Convert.ToInt32(Console.ReadLine());
                number2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            while (number1 > number2)
            {
                if(number1 % 2 == 0 && number1/2 >= number2)
                {
                    number1 /= 2;
                    Console.WriteLine(":2");
                    //Console.WriteLine(number1);
                }
                else
                {
                    number1 -= 1;
                    Console.WriteLine("-1");
                    //Console.WriteLine(number1);
                }
            }

        }
        
    }
}
