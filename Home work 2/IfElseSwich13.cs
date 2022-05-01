using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class IfElseSwich13
    {
        public static void main()
        {
            int n = 0;

            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            if ((((n/4) + 1) * 4) - 4 == n)
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");

        }
    }
}
