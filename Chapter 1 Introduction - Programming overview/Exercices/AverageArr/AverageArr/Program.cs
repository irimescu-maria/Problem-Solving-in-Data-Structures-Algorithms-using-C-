using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageArr
{
    class Program
    {
        public static double avrArray(int[] arr)
        {
                       int numberElem = 0;
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                numberElem++;
                sum += arr[i];
            }

            return sum / numberElem;
        }

        static void Main(string[] args)
        {
            int[] array = new int[] {1,2,3,4,5,6,7,8,9 };
            Console.WriteLine("Average is: " + avrArray(array));
        }
    }
}
