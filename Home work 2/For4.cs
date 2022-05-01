using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For4
    {
        public static void main()
        {
            int n;
            double answer = 0;

            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= n; i++)
            {
                answer += 1f/fact(i);
            }

            Console.WriteLine(answer);
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
