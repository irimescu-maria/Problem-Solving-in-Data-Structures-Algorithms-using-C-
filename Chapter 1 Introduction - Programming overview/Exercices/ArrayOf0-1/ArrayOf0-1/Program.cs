using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOf0_1
{
    /*
     * Given an array of 0s and 1s. We need to sort it so that all the 0s are before all the 1s.
     * 
     */


    class Program
    {
        public static void arrayOf0And1(int[] arr){

            int aux = 0;
            for(int start= 0; start< arr.Length; start++)
            {
                for (int end = arr.Length-1; end >=0; end--)
                {
                    if(start == end || start > end)
                    {
                        break;
                    }
                    if(arr[start] == 1 && arr[end] == 0)
                    {
                        aux = arr[start];
                        arr[start] = arr[end];
                        arr[end] = aux;
                    }
                }
            }
            Console.Write("Array sorted: ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

    static void Main(string[] args)
        {
            int[] array = new int[] { 0, 1, 1, 0, 0, 1, 1, 1, 0 };
            arrayOf0And1(array);
        }
    }
}
