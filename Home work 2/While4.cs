using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While4
    {
        public static void main()
        {
            int N = 0, i = 0;

            try
            {
                N = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            
            while(Math.Pow(2, i) < N)
            {
                i++;
            }

            if (Math.Pow(2, i) == N) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
