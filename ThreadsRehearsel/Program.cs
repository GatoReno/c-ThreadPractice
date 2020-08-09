using System;
using System.Threading;

namespace ThreadsRehearsel
{
    class Program
    {
        //exe multiple pieces of data at the same time
        static void Main(string[] args)
        {
            Thread t = new Thread(Print1);
            t.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(0);
            }
            Console.ReadLine();
        }

        static void Print1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(1);
            }
        }
    }
}
