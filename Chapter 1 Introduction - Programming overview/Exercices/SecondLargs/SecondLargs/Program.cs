using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargs
{
    /*
        Find the second largest number in the array
         */
    class Program
    {
        public static int secondLargestElem(int[] arr)
        {
            int firstLargest = -9999;
            int secondLargest = -9999;

            for (int i = 0; i < arr.Length; i++)
            
                for (int j = arr.Length-1; j >= 0; j--)
                {
                    if (arr[i] > firstLargest && arr[j] > secondLargest && arr[i] > arr[j])
                    {
                        firstLargest = arr[i];
                        secondLargest = arr[j];
                    }
                }
                            
            return secondLargest;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 25, 30, 105, 75 };
            Console.WriteLine("The second largest number in the array is: " + secondLargestElem(array));
        }
    }
}
