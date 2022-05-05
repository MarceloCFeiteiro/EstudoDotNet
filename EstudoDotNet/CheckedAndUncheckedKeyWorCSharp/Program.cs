using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDotNet.CheckedAndUnccheckedKeyWorCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MaxInt());
            SumOfTwoMaxIntWithChecked();
            Console.ReadLine();
        }

        /// <summary>
        /// Lança um exceção caso o 
        /// </summary>
        private static void SumOfTwoMaxIntWithChecked()
        {
            int a = 2147483647;
            int b = 2147483647;

            int c = checked(a + b);

            Console.WriteLine(c);
        }

        private static int MaxInt()
        {
            Console.WriteLine("The Max value to int is: ");
            return int.MaxValue;
        }
    }
}
