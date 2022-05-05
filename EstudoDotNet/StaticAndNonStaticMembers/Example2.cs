using System;

namespace EstudoDotNet.StaticAndNonStaticMembers
{
    class Example2
    {
        int x = 100;
        static int y = 200;
        static void Add()
        {
            //This is a static block
            //We can access non-static members X with the help of Example2 object
            //We can access the static member directly or through class name
            Example2 obj = new Example2();

            Console.WriteLine("Sum of 100 and 200 is :" + (obj.x + y));
        }

        void Mul()
        {
            //This a non-static method
            //We can access static members directly or through class name
            //We can access the non-static members directly or throug this keyword
            Console.WriteLine("Mutiplication of 100 amd 200 is :" + (this.x * Example2.y));

            Console.WriteLine("Mutiplication of 100 amd 200 is :" + (x * y));
        }

        static void Main(string[] args)
        {
            //Main method is a static method
            //ADD() method is a static method
            //Static to static
            //We can call the add method directly or through class name

            Example2.Add();
            Add();

            //Mul method is a non-static method
            //We can call the non-static method usning object only from a static method
            //Static to non-static
            Example2 obj = new Example2();
            obj.Mul();

            Console.WriteLine("Press any key to exit");

            Console.ReadLine();
        }
    }

}
