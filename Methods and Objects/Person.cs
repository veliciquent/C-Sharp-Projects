using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects
{
    public class Person
    {
        // Creating Superclass to the Employee class with given properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
            Console.ReadLine();
        }
    }
}
