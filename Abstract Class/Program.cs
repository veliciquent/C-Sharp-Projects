using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating inheriting class with given values
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            // Calling the "Say Name" function from the subclass
            employee.SayName();
        }
    }
}
