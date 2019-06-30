using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApproach
{
    class Program
    {
        /* 
         * Sorl all the elements in the array and after this in a single scan, we can find the duplicates 
         */

        public static void printRepeating(int[] arr, int size)
        {
            int i;
            //Use Sort method to sort the array
            Array.Sort(arr);
            Console.WriteLine("Repeating elements are ");
            for ( i = 1; i < size; i++)
            {
                if(arr[i] == arr[i - 1])
                {
                    Console.WriteLine("" + arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 12, 43, 56, 7, 45, 34, 56, 34, 6 };
            int size = arr.Length;
            printRepeating(arr, size);
        }
    }
}
