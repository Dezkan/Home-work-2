using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class IfElseSwich12
    {
        public static void main()
        {
            int n = 0, m = 0, k = 0;

            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                m = Convert.ToInt32(Console.ReadLine());
                k = Convert.ToInt32(Console.ReadLine());               
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            if (k < n * m && ((k % n == 0) || (k % m == 0)))
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");

        }
    }
}
