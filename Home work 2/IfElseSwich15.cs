using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class IfElseSwich15
    {
        public static void main()
        {
            int a = 0, b = 0, c = 0, d = 0, x = 0;

            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                d = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            if (a == 0 && b == 0)
            {
                Console.WriteLine("INF");
            }
            else if(a == 0 || b *c == a * d)
            {
                Console.WriteLine("NO");
            }
            else if(b % a == 0)
            {
                x = -b / a;
                Console.WriteLine(x);
            }
            else Console.WriteLine("NO");
        }
    }
}
