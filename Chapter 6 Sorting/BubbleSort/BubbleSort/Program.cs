﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {

        public static void Main(string[] args)
        {
            int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            BubbleSort bs = new BubbleSort(array);
            bs.sort();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "");
            }
        }
    }
}
