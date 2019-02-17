using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array0_1_2
{
    class Program
    {
        public static void arrayOf0And1(int[] arr)
        {

            int aux = 0;
            for (int start = 0; start < arr.Length; start++)
            {
                for (int end = arr.Length - 1; end >= 0; end--)
                {
                    if (start == end || start > end)
                    {
                        break;
                    }
                    if (arr[start] != 0 && arr[end] != 2)
                    {
                        aux = arr[start];
                        arr[start] = arr[end];
                        arr[end] = aux;
                    }
                }
            }
            Console.Write("Array sorted: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 1, 1, 0,2,2, 0, 1,2,2, 1, 1, 0 };
            arrayOf0And1(array);
        }
    }
}
