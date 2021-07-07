using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating inheriting class with given values
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", Id = 3245 };
            // Calling the "Say Name" function from the superclass
            employee.SayName();
        }
    }
}
