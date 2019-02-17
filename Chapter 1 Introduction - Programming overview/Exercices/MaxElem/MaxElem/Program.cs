using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElem
{
    /*
        Find all maxima's in an array.(A value is maximum ig the value before and after its index are smaller than it is or does
    not exist.
    Hint:
    a) Start traversing array from the end and keep track of the max element.
    b) If we ecounter an element>max, print the element and update max.
    */
    class Program
    {
        public static void maxElem(int[] arr)
        {
            int max = -9999;
            for (int i = arr.Length-1; i>=0 ; i--)
            {
                /* if (arr[i] > max)
                 {
                     max = arr[i];
                     Console.WriteLine(max);
                 }*/
                max = arr[i];
                if (arr[i - 1] < max)
                    max = arr[i];
                if (arr[i - 1] < max && arr[i + 1] < max)
                {
                    max = arr[i];
                    Console.WriteLine(max);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 25,90, 30, 105, 75 };
            maxElem(array);
         
        }
    }
}
