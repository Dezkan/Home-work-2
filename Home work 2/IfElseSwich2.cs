using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class IfElseSwich2
    {
        public static void main()
        {
            double Year = 0;

            try
            {
                Year = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            if ((Year%4 == 0 && Year%100 != 0) || Year%400 == 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
