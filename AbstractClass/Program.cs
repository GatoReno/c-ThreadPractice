using System;


namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstact classes & abstract shit!");
            Shape[] shapes = { new Circle(12), new Rectangle(4, 7) };
            foreach (var item in shapes)
            {
                item.GetInfo();
                Console.WriteLine("{0} Area : {1:f2}", item.Name, item.Area());

                Circle testC = item as Circle;
                if (testC == null)
                {
                    Console.WriteLine("this is not a circle");
                }

                if (item is Circle)
                {
                    Console.WriteLine("this is a circle not a rectangle");
                }
            }

        }
    }
}
