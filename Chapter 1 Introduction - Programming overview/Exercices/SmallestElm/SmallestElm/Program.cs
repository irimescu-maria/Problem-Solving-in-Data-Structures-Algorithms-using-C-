using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestElm
{
    /*
     * Fid the smallest element in the array
     */
    class Program
    {
        public static int smallestElem(int[] arr)
        {
            int smallest = 9999;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                    smallest = arr[i];
            }
            return smallest;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 30, 200, -45, 56, 7 };
            Console.WriteLine("The smallest element in the array " + smallestElem(array));
        }
    }
}
