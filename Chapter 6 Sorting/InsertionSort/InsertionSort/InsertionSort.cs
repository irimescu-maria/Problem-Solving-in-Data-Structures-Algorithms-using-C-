using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class InsertionSort
    {
        private int[] arr;

        public InsertionSort(int[] array)
        {
            arr = array;
        }

        public bool more(int value1, int value2)
        {
            return value1 > value2;
        }

        public virtual void sort()
        {
            int size = arr.Length;

            int i, j, temp;

            for (i = 0; i < size - 1; i++)
            {
                temp = arr[i];
                for(j=i; j>0 && more(arr[j-1], temp); j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[j] = temp;
            }
        }
    }
}
