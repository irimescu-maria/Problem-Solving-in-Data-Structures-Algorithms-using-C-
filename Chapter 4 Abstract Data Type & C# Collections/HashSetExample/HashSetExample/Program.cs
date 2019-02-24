using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a HashTable 
            HashSet<string> hashSet = new HashSet<string>();

            hashSet.Add("Romania");
            hashSet.Add("France");
            hashSet.Add("UK");
            hashSet.Add("Spain");
            hashSet.Add("Italy");
            hashSet.Add("India");

            foreach (String hs in hashSet)
            {
                Console.WriteLine(hs);
            }

            Console.WriteLine("Hash table constains UK " + hashSet.Contains("UK"));
            Console.WriteLine("Hash table constains Italy " + hashSet.Contains("Italy"));

            hashSet.Remove("UK");
            foreach (String hs in hashSet)
            {
                Console.WriteLine(hs);
            }
        }
    }
}
