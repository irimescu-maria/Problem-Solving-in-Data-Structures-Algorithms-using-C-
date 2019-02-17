using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedArray
{
    /*
     * Given an array with 'n' elements & a value 'x', find two elements in the array that sums to 'x'.
      */
    class Program
    {
        public static void sortArray(int[] arr, int x)
        {
            int aux;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                    if(arr[i]+arr[j] == x)
                    {
                        Console.Write(arr[i] + ", " + arr[j]);
                    }
                    else { break; }
                                    }
            }
           
            }
        static void Main(string[] args)
        {
            int[] array = new int[] { 25, 30, 105, 75 };
            sortArray(array, 135);
        }
    }
}
