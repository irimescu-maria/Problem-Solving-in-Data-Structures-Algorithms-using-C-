using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSetEx
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  SortedSet<T> is implemented using red-black balanced search treee in C# collections. Since SortedSet<T> is implements using binary search tree, its elements
             * are stored in sequential order. 
             */
            //Create a Sorted set
            SortedSet<string> sortedSet = new SortedSet<string>();

            //Add elements to the sorted list
            sortedSet.Add("Romania");
            sortedSet.Add("France");
            sortedSet.Add("Italy");
            sortedSet.Add("Spain");
            sortedSet.Add("India");

            foreach (String item in sortedSet)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
