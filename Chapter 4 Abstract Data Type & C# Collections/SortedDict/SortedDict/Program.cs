using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDict
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a sortedDictionary
            SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>();

            // Put elements into SortedDictionary
            sortedDictionary["Mason"] = 55;
            sortedDictionary["Jacob"] = 77;
            sortedDictionary["William"] = 99;
            sortedDictionary["Alexander"] = 80;
            sortedDictionary["Michael"] = 50;
            sortedDictionary["Emma"] = 65;
            sortedDictionary["Olivia"] = 77;
            sortedDictionary["Sophia"] = 88;
            sortedDictionary["Emily"] = 99;
            sortedDictionary["Isabella"] = 100;

            Console.WriteLine("The total number of elements is: " + sortedDictionary.Count);
            foreach (string key in sortedDictionary.Keys)
            {
                Console.WriteLine(key + " score mark " + sortedDictionary[key]);
            }

            Console.WriteLine("Emma present in class:: " + sortedDictionary.ContainsKey("Emma"));
        }
    }
}
