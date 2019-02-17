using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestElem
{
    class Program
    {
        public static int largestElem(int[] arr)
        {
           
            int largest = -9999;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                    largest = arr[i];
            }
            return largest;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 25, 30, 105, 75 };
            Console.WriteLine("The largest element of array is " + largestElem(array));
        }
    }
}
