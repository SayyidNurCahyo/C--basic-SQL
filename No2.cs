using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerSequenceFunction
{
    internal class No2
    {
        public static void A(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void B(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void C(int n)
        {
            bool reverse = false;
            int next = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (next > n)
                    {
                        reverse = true;
                        next = next - 2;
                    }
                    if (next == 0)
                    {
                        reverse = false;
                        next = 2;
                    }
                    Console.Write(next);
                    if (reverse) next--;
                    else next++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void D(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j%2 == 0)
                    {
                        Console.Write(n*j+1+i + " ");
                    }
                    else
                    {
                        Console.Write(n*(j+1)-i + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
