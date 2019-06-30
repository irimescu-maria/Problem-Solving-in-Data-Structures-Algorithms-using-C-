using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumberInArray
{
    /*
     * Given an array of n-1 elements, which are in the range of 1 to n. There are no duplicates in the array. One of the integer is missing.
     * Find the missing element.
     */


    class Program
    {
        public static int missingNumber(int[] arr, int size)
        {
            int found = 0;

            for (int i = 1; i <= size; i++)
            {
                found = 0;
                for (int j = 0; j < size; j++)
                {
                    if (arr[j] == i)
                    {
                        found = 1;
                        break;
                    }
                }
                if (found == 0)
                {
                    return i;
                }
            }

            return int.MaxValue;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 5 };
            int size = arr.Length;
            Console.WriteLine(missingNumber(arr, size));
        }
    }
}
