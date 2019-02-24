using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create stack
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            Console.WriteLine("Element at the top of stack " + stack.Peek());

            int size = stack.Count;
            for(int i=0; i<size;i++)
            {
                Console.WriteLine("Pop from top " + stack.Pop());
            }
        }
    }
}
