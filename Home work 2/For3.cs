using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For3
    {
        public static void main()
        {
            int n;

            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(pow(n));
        }

        public static int pow(int n)
        {
            int answer = 2;
            for (int i = 1; i < n; i++)
            {
                answer *= 2;
            }
            return answer;
        }
    }
}
