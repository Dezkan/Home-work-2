using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For6
    {
        public static void main()
        {
            int n;

            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(fact(n));
        }

        public static int fact(int n)
        {
            int answer = 1;
            for (int i = 1; i <= n; i++)
            {
                answer *= i;
            }
            return answer;
        }
    }
}
