using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While3
    {
        public static void main()
        {
            int N = 0, i = 1 ;

            try
            {
                N = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            while (i <= N)
            {
                Console.WriteLine(i);
                i*=2;
            }
        }
    }
}
