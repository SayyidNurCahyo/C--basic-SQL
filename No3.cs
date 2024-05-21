using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerSequenceFunction
{
    internal class No3
    {
        public static void Array(int[] arr)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 != 0) list.Add(arr[i]);
            }
            // pake fungsi bawaan sorting
            // list.Sort();
            // pake bubble sort
            BubbleSort(list);
            Console.Write("[ ");
            for (int a = 0; a < list.Count; a++)
            {
                if (a == list.Count - 1) Console.Write(list[a]);
                else Console.Write(list[a] + ", ");
            }
            Console.Write(" ]");
        }

        private static void BubbleSort(List<int> list)
        {
            for (int i = 0; i < list.Count-1; i++)
            {
                for (int j = 0; j < list.Count-i-1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j+1];
                        list[j+1] = temp;
                    }
                }
            }
        }
    }
}
