
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdApproach
{
    class Program
    {
        /* *
         Hash-Table, usign Hash-Table, we can keep track of the elements we have already seen and we can find the duplicates in just one scan.
             */
            
        public static void printRepeating(int[] arr, int size)
        {
            HashSet<int> hs = new HashSet<int>();
            Console.WriteLine("Repeating elements are ");
            for (int i = 0; i < size; i++)
            {
                if (hs.Contains(arr[i]))
                {
                    Console.WriteLine("" + arr[i]);
                }
                else
                {
                    hs.Add(arr[i]);
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
