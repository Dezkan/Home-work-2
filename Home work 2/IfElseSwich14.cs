using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class IfElseSwich14
    {
        public static void main()
        {
            int a = 0, b = 0, x = 0;

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

            if(b == 0)
            {
                Console.WriteLine("INF");
            }
            else
            {
                x = -b / a;
                if (a * x + b == 0)
                {
                    Console.WriteLine(x);
                }
                else Console.WriteLine("NO");
            } 
        }
    }
}
