using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class IfElseSwich19
    {
        public static void main()
        {
            int a = 0, b = 0,c = 0;

            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

            if(a == b)
            {
                if (a == c)
                {
                    Console.WriteLine(3);
                }
                else Console.WriteLine(2);
            }
            else if(b == c)
            {
                Console.WriteLine(2);
            }
            else if(a == c)
            {
                Console.WriteLine(2);
            }
            else Console.WriteLine(0);
            
        }
    }
}
