using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For13
    {
        public static void main()
        {
            int x, answer = 0;

            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= x; i++)
            {
                if(x%i == 0)
                {
                    answer = i;
                    break;
                }
            }

            Console.WriteLine(answer);

        }
    }
}
