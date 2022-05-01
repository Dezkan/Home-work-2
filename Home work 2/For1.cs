using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For1
    {
        public static void main()
        {
            int n, sum = 0;

            n = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 1; i <= n; i++)
            {
                sum += i * 10 + 2;
            }

            Console.WriteLine(sum);
        }
    }
}
