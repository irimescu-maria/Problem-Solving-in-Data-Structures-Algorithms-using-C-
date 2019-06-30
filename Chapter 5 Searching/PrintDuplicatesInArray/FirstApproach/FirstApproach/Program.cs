using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApproach
{
    class Program
    {
        /*
         * Exhaustive search or Brute force
         * Print the duplicates elements in the array.
         */

        public static void printRepeating(int[] arr, int size)
        {
            Console.WriteLine("Repeating elements are ");
            for (int i = 0; i < size; i++)
            {
                for (int j = i+1; j < size; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        Console.WriteLine("" + arr[i]);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 12, 34, 56, 67, 34, 56, 8, 7, 9 };
            int size = arr.Length;
            printRepeating(arr, size);
        }
    }
}
