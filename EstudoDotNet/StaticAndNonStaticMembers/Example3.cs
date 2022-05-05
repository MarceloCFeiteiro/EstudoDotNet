using System;

namespace EstudoDotNet.StaticAndNonStaticMembers
{
    class Example3
    {
        static Example3()
        {
            Console.WriteLine("Static construtor is called");
        }
        public Example3()
        {
            Console.WriteLine("Non-Static construtor is called");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main method is executed");
            Example3 obj1 = new Example3();
            Example3 obj2 = new Example3();

            Console.WriteLine("Press any key to exit");

            Console.ReadLine();
        }
    }
}
