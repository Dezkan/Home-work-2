using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class IfElseSwich3
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

            int a1, a2, a3, a4;
            a1 = (a / 1000);
            a2 = (a / 100) % 10;
            a3 = (a / 10) % 10;
            a4 = (a % 10);

            if (((a1 - a4) + (a2 - a3) == 0) && b == 1) Console.WriteLine("YES");
            else if (((a1 - a4) + (a2 - a3) != 0) && b != 1) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
