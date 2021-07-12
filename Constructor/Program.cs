using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating an implied variable utilizing "var"
            Console.WriteLine("Enter your name or favorite number: "); 
            var answer = Console.ReadLine(); 
            if (int.TryParse(answer, out int x)) 
            { 
                Person newPerson = new Person(x); 
            } else 
            {
                Person newPerson = new Person(answer); 
            }
        }
    }

    class Person
    {
        // Creating initial constructor
        public Person(string name, int age)
        {
            const string nameString = "Your name is: ";
            const string ageString = "\r\nYour age is: ";
            Console.WriteLine(nameString + name + ageString + age);
            Console.ReadLine();
        }
        // Creating chained constructors
        public Person(string name) : this(name, 0)
        {

        }
        public Person(int age) : this("Anonymous", age)
        {

        }
    }
}
