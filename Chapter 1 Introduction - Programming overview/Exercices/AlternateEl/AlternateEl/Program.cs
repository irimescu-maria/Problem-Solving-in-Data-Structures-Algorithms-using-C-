using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternateEl
{
    /*
     * Print alternate element in array
     */
    class Program
    {
        public static void alternateArray(int[] arr)
        {
            //Print elements 
            for (int i = 0; i < arr.Length; i+=2)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            alternateArray(array);
        }
    }
}
