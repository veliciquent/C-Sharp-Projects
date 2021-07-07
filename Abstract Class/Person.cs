using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public abstract class Person
    {
        // Creating an abstract class that is inherited by the "Employee" class with the given properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
            Console.ReadLine();
        }
    }
}
