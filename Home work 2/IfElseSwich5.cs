using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class IfElseSwich5
    {
        public static void main()
        {
            int a = 0, b = 0;

            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            if (a > b)
            {
                Console.WriteLine(1);
            }
            else if (a < b)
            {
                Console.WriteLine(2);
            }
            else Console.WriteLine(0);
        }
    }
}
