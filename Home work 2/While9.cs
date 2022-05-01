using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While9
    {
        public static void main()
        {
            double A = 0, x = 1, x1 = 1, s = 2, b;

            try
            {
                A = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            while (true)
            {
                b = x;
                x = x1;
                x1 += b;
                s++;
                if(x1 == A)
                {
                    Console.WriteLine(s);
                    break;
                }
                else if (x1 > A)
                {
                    Console.WriteLine(-1);
                    break;
                }
            }

        }
    }
}
