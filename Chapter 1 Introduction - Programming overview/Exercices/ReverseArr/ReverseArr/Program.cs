using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArr
{
    /*
     * Reverse an array in-place
     */
    class Program
    {
        public static void reverseArray(int[] arr)
        {
            int aux = 0;
            int start, end;
            for(start = 0; start< arr.Length; start++)
            {
                for (end = arr.Length - 1; end >= 0; end--)
                {
                    aux = arr[start];
                    arr[start] = arr[end];
                    arr[end] = aux;
                }
                if (start == end || start > end)
                    break;

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] + "\n");
                }
            }

        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 25, 30, 105, 75 };
            reverseArray(array);
        }
    }
}
