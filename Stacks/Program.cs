using System;
using System.Collections;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stacks!");

            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            foreach (var item in st)
            {
                Console.WriteLine($"stack : {item}");
            }

            // u can use peek, pop to delete and contains

            Console.ReadLine();

        }
    }
}
