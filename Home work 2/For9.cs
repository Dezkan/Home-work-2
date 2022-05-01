using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For9
    {
        public static void main()
        {
            int a, b;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            for (double i = a; i <= b; i++)
            {
                if (Math.Sqrt(i) == Convert.ToInt32(Math.Sqrt(i)))
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
