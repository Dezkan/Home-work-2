using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class IfElseSwich6
    {
        public static void main()
        {
            int a = 0, b = 0, c = 0;

            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a);
                }
                else Console.WriteLine(c);
            }
            else if (a < b)
            {
                if (b > c)
                {
                    Console.WriteLine(b);
                }
                else Console.WriteLine(c);
            }
            
        }
    }
}
