using System;
using System.Collections;
using System.Collections.Generic;

namespace Queques
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue : es cola en spanish mr madafawker
            Console.WriteLine("Queues! \n");

            Queue queque = new Queue();
            //instead of Add
            queque.Enqueue(1);
            queque.Enqueue(2);
            queque.Enqueue(1);
            queque.Enqueue(5);
            queque.Enqueue(6);

            Console.WriteLine("1 in the queue : {0}", queque.Contains(1));
            Console.WriteLine("remove from queue : {0} remove first item ", queque.Dequeue());
            Console.WriteLine("peek from queue : {0}", queque.Peek());

            object[] numArray = queque.ToArray();
            Console.WriteLine(string.Join(", ", numArray));
            //queque.Clear();

            foreach (var item in queque)
            {
                Console.WriteLine($"Queue :  {item}");
            }

        }
    }
}
