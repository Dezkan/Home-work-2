using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class IfElseSwich1
    {
        public static void main()
        {
            double a = 0, b = 0;

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

            if (a > b) Console.WriteLine(a);
            else Console.WriteLine(b);
        }
    }
}
