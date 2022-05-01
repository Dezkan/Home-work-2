using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While7
    {
        public static void main()
        {
            double x = 0, p = 0, y = 0, answer = 0;

            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                p = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            while (x < y)
            {
                x = x * (1+ p/100);
                answer = answer + 1;
            }

            Console.WriteLine(answer);

        }
    }
}
