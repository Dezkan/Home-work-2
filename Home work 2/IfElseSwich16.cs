using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class IfElseSwich16
    {
        public static void main()
        {
            int a = 0, b = 0, c = 0, d = 0, A = 0, B = 0;

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

            A = a * 100 + b;
            B = c * 100 + d;

            if(A <= B)
            {
                Console.WriteLine((B-A)/100 + " " + (B-A)%100);
            }
            else 
            {
                Console.WriteLine("NO");
            }

        }
    }
}
