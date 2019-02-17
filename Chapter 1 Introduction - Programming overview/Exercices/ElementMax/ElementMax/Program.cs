using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementMax
{
    /*
     * Find the maximum element in a sorted and rotated array. 
     * Hint: Use binary search algorithm.
     */
    class Program
    {
        public static int binarySearch(int[] arr, int size, int value)
        {
            int mid;
            int low = 0;
            int high = size - 1;
            while (low<=high)
            {
                mid = low + (high - low) / 2;
                if(arr[mid] == value)
                {
                    return arr[mid];
                }else if (arr[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 25, 30, 105, 75 };
            Console.WriteLine("The maximum element is "+ binarySearch(array, 4, 105));
        }
    }
}
