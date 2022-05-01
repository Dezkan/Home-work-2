using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class IfElseSwich18
    {
        public static void main()
        {
            int k = 0, m = 0, n = 0, time = 0;

            try
            {
                k = Convert.ToInt32(Console.ReadLine());
                m = Convert.ToInt32(Console.ReadLine());
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }


            if (n <= k)
            {
                time = 2 * m;
            }
            else if (n * 2 % k == 0)
            {
                time = m * (n * 2 / k);
            }
            else time = m * (1 + (n * 2 / k));


            Console.WriteLine(time);
        }
    }
}
