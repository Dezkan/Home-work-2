using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While5
    {
        public static void main()
        {
            int N = 0, k = 0, answer = 1;

            try
            {
                N = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            while (answer < N)
            {
                answer *= 2;
                k++;
            }

            Console.WriteLine(k);
            
        }
    }
}
