using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicates
{
    /*
     * Find the duplicate elements in an array of size n where each eleement is in the range 0 to n-1.
     */
    class Program
    {
        public static void findDuplicates(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        Console.Write(arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 25,2,30,45,78,2,30,35,52 };
            Console.Write("The duplicate elements are: ");
            findDuplicates(array);
        }
    }
}
