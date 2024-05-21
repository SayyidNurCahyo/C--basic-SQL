using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerSequenceFunction
{
    internal class No1
    {
        public static void OKYES(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 4 == 0) Console.Write("OKYES");
                else if (i % 3 == 0) Console.Write("OK");
                else if (i % 4 == 0) Console.Write("YES");
                else Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
