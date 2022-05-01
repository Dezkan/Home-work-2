using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class For7
    {
        public static void main()
        {
            int a, b;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if(a % 2 != 0)
            {
                a++;
            }

            for(int i = a; a<b; a += 2)
            {
                Console.Write(a + " ");
            }
        }
    }
}
