using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For5
    {
        public static void main()
        {
            int a, n;

            a = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(pow(a, n));
        }

        public static int pow(int a, int n)
        {
            int answer = a;
            for (int i = 1; i < n; i++)
            {
                answer *= a;
            }
            return answer;
        }
    }
}
