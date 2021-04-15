using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class SelectionSort
    {
        private int[] arr;

        public SelectionSort(int[] array)
        {
            arr = array;
        }

        public bool less(int value1, int value2)
        {
            return value1 < value2;
        }

        public bool more(int value1, int value2)
        {
            return value1 > value2;
        }

        public virtual void sort()
        {
            int size = arr.Length;
            int i, j, temp, max;
            for (i = 0; i < size - 1; i++)
            {
                max = 0;
                for (j = 1; j < size - i - 1; j++)
                {
                    if (arr[j] > arr[max])
                    {
                        max = j;
                    }
                }
                temp = arr[size - i - 1];
                arr[size - i - 1] = arr[max];
                arr[max] = temp;
            }
        }
    }
}
