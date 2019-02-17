using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumber
{
    /* 
     * Write a method to find the sum of every number in an int number
     */


    class Program
    {

        public static int splitInNumber(int x)
        {
            int sum = 0;
            int count = 0;
            while (x != 0)
            {
                sum += x % 10;
                x /= 10;
                count++;
            }
  
            return sum;

        }

        static void Main(string[] args)
        {
            int x = 1984;
            Console.WriteLine("The sum of every number in " + x + " is " + splitInNumber(x));
        }
    }
}
