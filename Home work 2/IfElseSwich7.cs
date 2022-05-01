using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class IfElseSwich7
    {
        public static void main()
        {
            int x1 = 0, y1 = 0, x2 = 0, y2 = 0;

            try
            {
                x1 = Convert.ToInt32(Console.ReadLine());
                y1 = Convert.ToInt32(Console.ReadLine());
                x2 = Convert.ToInt32(Console.ReadLine());
                y2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }


            if (x1 == x2 || y1 == y2)
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");

        }
    }
}
