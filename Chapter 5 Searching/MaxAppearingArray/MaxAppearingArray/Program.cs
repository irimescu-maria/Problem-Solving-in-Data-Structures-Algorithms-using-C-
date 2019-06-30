using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxAppearingArray
{
    /*
     * Given an array of n numbers, find the element, which appears maximum number of times.
     */
    class Program
    {



        /*
         * First approach:
         * Exhaustive search or Brute force
         */
         public static int getMax(int[] arr, int size)
        {
            int max = arr[0];
            int count = 1, maxCount = 1;
            for (int i = 0; i < size; i++)
            {
                count = 1;
                for (int j = i+1; j < size; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if(count > maxCount)
                {
                    max = arr[i];
                    maxCount = count;
                }
            }
            return max;
        }

        /*
         * Second approach
         * Sorting: Sort all the elements in the array and after this in a single scan, we can find the counts.
         */
         public static int getMax2(int[] arr, int size)
        {
            int max = arr[0], maxCount = 1;
            int curr = arr[0], currCount = 1;
            Array.Sort(arr);
            for (int i = 1; i < size; i++)
            {
                if (arr[i] == arr[i-1])
                {
                    currCount++;
                }
                else
                {
                    currCount = 1;
                    curr = arr[i];
                }

                if (currCount > maxCount)
                {
                    maxCount = currCount;
                    max = curr;
                }
            }
            return max;
        }

        /*
         * Third approach:
         * Counting
         */
         public static int getMax3(int[] arr, int size)
        {
            int max = arr[0], maxCount = 1;
            int[] count = new int[size];

            for (int i = 0; i < size; i++)
            {
                count[arr[i]]++;
                if(count[arr[i]] > maxCount)
                {
                    maxCount = count[arr[i]];
                    max = arr[i];
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 1, 7, 1, 3, 8, 4, 6 };
            int size = arr.Length;

            // Console.WriteLine(getMax(arr, size));
            //Console.WriteLine("Second approach "+ getMax2(arr, size));
            Console.WriteLine("Third aproach " + getMax3(arr, size));
        }
    }
}
