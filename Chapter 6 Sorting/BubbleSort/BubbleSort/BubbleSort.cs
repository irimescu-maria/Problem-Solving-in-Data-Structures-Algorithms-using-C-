using System;

namespace BubbleSort
{
    public class BubbleSort
    {
        private int[] arr;

        public BubbleSort(int[] array)
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

        public void sort()
        {
            int size = arr.Length;
            int i, j, temp;
            for ( i = 0; i < size-1; i++)
            {
                for ( j = 0; j < size-i-1; j++)
                {
                    if(more(arr[j], arr[j + 1]))
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }

}

