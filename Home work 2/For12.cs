using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For12
    {
        public static void main()
        {
            int x, answer = 0;

            x = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i > 0; i /= 10)
            {
                answer *= 10;
                answer += i % 10;
            }

            Console.WriteLine(answer);

        }
    }
}
