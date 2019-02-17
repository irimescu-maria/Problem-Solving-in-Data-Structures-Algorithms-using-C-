using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    /*
     * Write a method to compute Sum(N) = 1 + 2 + 3 + ... + N
     */
    class Program
    {
        public static int sum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine("The sum of numbers is " + sum(n));
        }
    }
}
