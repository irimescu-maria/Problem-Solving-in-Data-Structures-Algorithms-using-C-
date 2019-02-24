using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a linkedlist
            LinkedList<int> linkedList = new LinkedList<int>();

            //Add elements to tje list
            linkedList.AddFirst(10);
            linkedList.AddLast(20);
            linkedList.AddLast(9);
            linkedList.AddLast(21);
            linkedList.AddLast(8);
            linkedList.AddLast(22);

            Console.WriteLine("\nContents of Linked List: ");
            foreach(int val in linkedList)
            {
                Console.WriteLine(val + " ");
            }

            linkedList.RemoveFirst(); //remove the first element of linked list
            linkedList.RemoveLast(); //remove the last element of linked list

            Console.WriteLine("\nContents of Linked List: ");
            foreach (int val in linkedList)
            {
                Console.WriteLine(val + " ");
            }
        }
    }
}
