using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    abstract class Shape
    {
        public string Name { get; set; }
        public virtual void GetInfo() {
            Console.WriteLine($"This is a {Name} ");
        }
        // we want to override this method depending in any shape
        public abstract double Area();
    }
}
