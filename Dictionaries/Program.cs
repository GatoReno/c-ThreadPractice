using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictinaries!");
            // define data type of the key and the value stored
            Dictionary<string, string> superheros =
                new Dictionary<string, string>();

            superheros.Add("Bruno Dias", "Batman");
            superheros.Add("Ed Rodrgiuez", "Oniphanimon");

            //dictionaries can use Remove by key

            //superheros.Remove("Ed Rodriguez"); //example

            Console.WriteLine("Bruno : {0}", superheros.ContainsKey("Bruno Dias"));
            
                superheros.TryGetValue("Bruno Dias", out string test);

            Console.WriteLine($"try get valie from bruno dias : {test}");

            foreach ( KeyValuePair<string,string> item in superheros )
            {
                Console.WriteLine("{0} : {1}",item.Key, item.Value);
            }
            // also can use clear
        }
    }
}
