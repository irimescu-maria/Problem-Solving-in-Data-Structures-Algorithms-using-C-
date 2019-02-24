using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> al = new List<int>();

            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Add(4);

            Console.WriteLine("Contents of the list after adding 1,2,3,4");
            al.ForEach(Console.WriteLine); // Iterats throught the contents of the list and display to the console

            al.Insert(2, 9); // Insert 9 to 2nd index
            al.Insert(5, 9); // Insert 5 to 5th index
            Console.WriteLine("\nContents of the list after adding 9 twice");
            al.ForEach(Console.WriteLine);

            Console.WriteLine("\nContents of list at index 0: " + al[0]);
            Console.WriteLine("\nSize of list: " + al.Count);
            Console.WriteLine("\nList is Empty:" + (al.Count == 0));

            al.RemoveAt(al.Count - 1); //remove last element if list
            Console.WriteLine("\nList size after element remove: " + al.Count);
            al.Clear(); // Removes all element of the List
            Console.WriteLine("\n List IsEmpty after clear: " + (al.Count == 0));

        }
    }
}
