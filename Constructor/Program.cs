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
            // Creating an abritrary constant string
            const string nope = "I AM ETERNAL";
            // Creating an implied variable utilizing "var"
            var implied = Guid.NewGuid();
        }
    }

    class Person
    {
        // Creating initial constructor
        public Person(string FirstName, string LastName, DateTime Birthday)
        {
            firstName = FirstName;
            lastName = LastName;
            birthday = Birthday;
        }
        // Creating chained constructor
        public Person(string FirstName) : this(FirstName, "", DateTime.Now)
        {

        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthday { get; set; }
    }
}
