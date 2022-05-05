using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDotNet.PropertiesExample
{
    class Program
    {
        static void Main(string[] args)
        {

            
            var person = new Person();
            person.Name = "";
            Console.WriteLine(person.Name);

            person.Name = "Marcelo";

            Console.WriteLine(person.Name);


        }
    }

    public class Person
    {
        private  string _name;
        public string Name
        {
            get
            {
                return string.IsNullOrEmpty(_name)? "No name": _name;
            }
           
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(Name + " Not be empty");
                _name = value;
            }
        }


    }
}
