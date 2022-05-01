using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class While11
    {
        static int A = 0, MaxA = 0, B = 0, MaxB = 0, N = 0;
        public static void main()
        {
            

            try
            {
                MaxA = Convert.ToInt32(Console.ReadLine());
                MaxB = Convert.ToInt32(Console.ReadLine());
                N = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("error FormatException" + '\a');
                Environment.Exit(0);//прервать выполнение
            }

             if((MaxA < N && MaxB < N) || (MaxA != N && MaxB != N && MaxA == MaxB))
             {
                 Console.WriteLine("imposible");
             }
             else
             {
                if (MaxA < MaxB)
                {
                    while (!(A == N || B == N)) 
                    {
                        if (A == 0)
                        {
                            FillA();
                        }
                        else
                        {
                            PourOverAtoB();
                        }

                        if (B == MaxB && A != N && B != N)
                        {
                            PourOutB();
                        }
                        
                     }
                 }
                 else
                 {
                     while (!(B == N || A == N))
                     {
                         if(B == 0)
                         {
                             FillB();
                         }
                         else
                         {
                             PourOverBtoA();
                         }


                         if (A == MaxA && B != N && A != N)
                         {
                             PourOutA();
                         }

                     }
                 }
             }  
            
        }

        static void  FillA()
        {
            A = MaxA;
            Console.WriteLine(">A");
        }

        static void FillB()
        {
            B = MaxB;
            Console.WriteLine(">B");
        }

        static void PourOutA()
        {
            A = 0;
            Console.WriteLine("A>");
        }
        static void PourOutB()
        {
            B = 0;
            Console.WriteLine("B>");
        }

        static void PourOverAtoB()
        {       
           while( B != MaxB && A > 0)
           {
                B++;
                A--;
           }

            Console.WriteLine("A>B");
        }

        static void PourOverBtoA()
        {
            while (A != MaxA && B > 0)
            {
                A++;
                B--;
            }

            Console.WriteLine("B>A");
        }

    }
}
