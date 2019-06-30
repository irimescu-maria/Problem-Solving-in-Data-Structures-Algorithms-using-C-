using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElementArray
{
    /**
     *  Given an array of n elements. Find the majority element, which appears more than n/2 times. Return  0
     * in case there is no majority element
     */
    class Program
    {
        /**
         *  First approach:
         * Exhaustive search or Brute force
         */
        public static int getMajority(int[] arr, int size)
        {
            int max = 0, count = 0, maxCount = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = i+1; j < size; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    max = arr[i];
                    maxCount = count;
                }
            }
            if (maxCount > size/2)
            {
                return max;
            }
            else
            {
                return 0;
            }
        }


        static void Main(string[] args)
        {
            int[] arr = { 1, 33,1, 22,1,  44, 5, 1};
            int size = arr.Length;

            Console.WriteLine("First approach " + getMajority(arr, size));
        }
    }
}
