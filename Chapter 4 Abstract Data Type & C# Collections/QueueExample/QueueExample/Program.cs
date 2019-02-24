using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Queue
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1); // add 1 to the back of the queue
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            int size = queue.Count;
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("Dequeue from queue: " + queue.Dequeue());
            }
        }
    }
}
