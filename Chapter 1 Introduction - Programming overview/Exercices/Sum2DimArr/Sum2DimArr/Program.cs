using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum2DimArr
{
    class Program
    {
        public static int sumArray(int[,] arr,int row, int col)
        {
            int sum = 0;
            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sum += arr[i, j];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[,] array = new int[4, 2] { {1, 2},{3, 4},{5, 6},{7, 8} };
            Console.WriteLine("The sum of all the elemens of a two dimensional array is: " + sumArray(array, 4, 2));
        }
    }
}
