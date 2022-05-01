using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While8
    {
        public static void main()
        {
            double n = 0, f1 = 1, f2 = 1, fsum;

            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            int i = 0;
            while (i < n - 2)
            {
                fsum = f1 + f2;
                f1 = f2;
                f2 = fsum;
                i++;
            }

            Console.WriteLine(f2);

        }
    }
}
