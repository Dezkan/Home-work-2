using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While2
    {
        public static void main()
        {
            int N = 0, i = 2;

            try
            {
                N = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            while (N%i != 0)
            {
                i++;
            }
            Console.WriteLine(i);

        }
    }
}
