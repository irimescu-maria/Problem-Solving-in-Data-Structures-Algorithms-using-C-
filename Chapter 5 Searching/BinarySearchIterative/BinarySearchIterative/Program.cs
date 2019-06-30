using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchIterative
{
    class Program
    {
        public static bool BinarySearchIterative(int[] array, int size, int value)
        {
            int low = 0;
            int high = size - 1;
            int mid;

            while(low <= high)
            {
                mid = low + (high - low) / 2;
                if(array[mid] == value)
                {
                    return true;
                }else if(array[mid]< value)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] array = { 12, 4, 7, 44, 6, 8, 84 };
            int size = array.Length;
            int value = 7;
            Console.WriteLine(BinarySearchIterative(array, size, value));
        }
    }
}
