using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class IfElseSwich4
    {
        public static void main()
        {
            double x = 0;

            try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            if (x > 0)
            {
                Console.WriteLine(1);
            }
            else if(x < 0)
            {
                Console.WriteLine(-1);
            }
            else Console.WriteLine(0);
        }
    }
}
