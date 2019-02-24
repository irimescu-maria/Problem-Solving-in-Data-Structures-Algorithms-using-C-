using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Dictionary or map
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            // Put elements into SortedDictionary
            dictionary["Mason"] = 55;
            dictionary["Jacob"] = 77;
            dictionary["William"] = 99;
            dictionary["Alexander"] = 80;
            dictionary["Michael"] = 50;
            dictionary["Emma"] = 65;
            dictionary["Olivia"] = 77;
            dictionary["Sophia"] = 88;
            dictionary["Emily"] = 99;
            dictionary["Isabella"] = 100;

            Console.WriteLine("The total number of elements is: " + dictionary.Count);
            foreach (string key in dictionary.Keys)
            {
                Console.WriteLine(key + " score mark " + dictionary[key]);
            }

            Console.WriteLine("Emma present in class:: " + dictionary.ContainsKey("Emma"));
        }
    }
}
