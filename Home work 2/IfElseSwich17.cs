using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class IfElseSwich17
    {
        public static void main()
        {
            int k = 0;

            try
            {
                k = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            

            if (k < 3 || k == 4 || k == 7)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

        }
    }
}
