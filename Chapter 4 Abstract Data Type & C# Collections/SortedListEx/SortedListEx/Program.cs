using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a sorted List
            SortedList<string, int> sortedList = new SortedList<string, int>();

            //Put elements into sorted list
            sortedList["Mason"] = 55;
            sortedList["Jacob"] = 77;
            sortedList["William"] = 99;
            sortedList["Alexander"] = 80;
            sortedList["Michael"] = 50;
            sortedList["Emma"] = 65;
            sortedList["Olivia"] = 77;
            sortedList["Sophia"] = 88;
            sortedList["Emily"] = 99;
            sortedList["Isabella"] = 100;

            Console.WriteLine("Total number of students in class::" + sortedList.Count);

            foreach(string key in sortedList.Keys)
            {
                Console.WriteLine(key + "score marks " + sortedList[key]);
            }

            Console.WriteLine("Emma present in class::" + sortedList.ContainsKey("Emma"));
            Console.WriteLine("John present in class::" + sortedList.ContainsKey("John"));
        }
    }
}
