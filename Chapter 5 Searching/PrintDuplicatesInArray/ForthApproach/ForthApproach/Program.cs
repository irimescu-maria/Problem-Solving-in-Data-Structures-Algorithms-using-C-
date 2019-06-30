using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthApproach
{
    class Program
    {
        /**
         * Counting, this approach is only possible if we know the range of the input. 
         */

        public static void printRepeating(int[] arr, int size)
        {
            int[] count = new int[size];
            for (int i = 0; i < size; i++)
            {
                count[i] = 0;
            }
            for (int i = 0; i < size; i++)
            {
                if (count[arr[i]] == 1)
                {
                    Console.WriteLine("" + arr[i]);
                }else
                {
                    count[arr[i]]++;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 5, 7, 5, 2, 4, 4 };
            int size = arr.Length;
            printRepeating(arr, size);
        }
    }
}
