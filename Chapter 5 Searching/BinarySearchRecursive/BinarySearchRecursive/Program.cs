using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchRecursive
{
    class Program
    {
        public static bool BinarySearchRecursive(int[] array, int low, int high, int value)
        {
            if (low > high)
            {
                return false;
            }

            int mid = low + (high - low) / 2;
            if(array[mid] == value)
    
                return true;
            else if(array[mid] < value)
            
                return BinarySearchRecursive(array, mid + 1, high, value);
            
            else
            
                return BinarySearchRecursive(array, low, mid - 1, value);
            

        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 44, 565, 77, 44 };
            int low = 0;
            int high = arr.Length - 1;
            int size = arr.Length;
            int value = 565;
            Console.WriteLine(BinarySearchRecursive(arr, low, high, value));
        }
    }
}
