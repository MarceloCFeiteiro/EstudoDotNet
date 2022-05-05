using System;

namespace EstudoDotNet.StaticAndNonStaticMembers
{
    class Example
    {
        int x;
        static int y = 200;

        public Example(int x)
        {
            this.x = x;
        }

        static void Main(string[] args)
        {
            //Accessing the static variable using class name
            //Before object creaton
            Console.WriteLine("Static Variable Y = " + Example.y);

            //Creating object1
            Example obj1 = new Example(50);

            //Creating object1
            Example obj2 = new Example(100);

            Console.WriteLine($"object1 x = {obj1.x}  object2 x = {obj2.x}");

            Console.WriteLine("Press any key to exit");

            Console.ReadLine();
        }
    }
}
