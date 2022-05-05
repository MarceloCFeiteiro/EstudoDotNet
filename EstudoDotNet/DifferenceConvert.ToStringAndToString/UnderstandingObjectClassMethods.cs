using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDotNet.DifferenceConvert.ToStringAndToString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer c1 = null;
            //c1.ToString();  //Lança um exception do tipo SystemNullReferenceException
            
            Convert.ToString(c1);

            string name = null;
            Convert.ToString(name);

            Console.WriteLine("No Erros");
            Console.ReadLine();

        }
    }

    public class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
