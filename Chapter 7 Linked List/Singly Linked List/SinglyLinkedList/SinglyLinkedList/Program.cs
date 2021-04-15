using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.addHead(3);
            list.addHead(4);
            list.addHead(5);
            //list.sortedList(9);
            //list.isPresent(4);
            //list.DeleteHead();
            list.deleteNode(4);
            list.print();
        }
    }
}
