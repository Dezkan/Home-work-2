using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class IfElseSwich20
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

            if (n % 10 == 1)
            {
                Console.WriteLine(n + " корова");
            }
            else if (n % 10 == 2 || n % 10 == 3 || n % 10 == 4)
            {
                Console.WriteLine(n + " коровы");
            }
            else Console.WriteLine(n + " коров");

        }
    }
}
