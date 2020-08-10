using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ArrayList Code
            ArrayList aList = new ArrayList();

            aList.Add("Bobo");
            aList.Add("Dogo");
            aList.Add(239);

            Console.WriteLine("Count : {0}", aList.Count);

            Console.WriteLine("Capacity : {0}", aList.Capacity);

            ArrayList aList2 = new ArrayList();

            aList2.AddRange(new object[] { "nike", "mustang", "sonny" });

            aList.AddRange(aList2);
            aList2.Sort();
            aList2.Reverse();

            aList2.Insert(1, "nokia");
            ArrayList range = aList2.GetRange(0, 2);

            foreach (object item in range)
            {
                Console.WriteLine(item);
            }


            #endregion



            Console.ReadLine();
        }
    }
}
