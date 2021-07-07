using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating two employees with varying ID's
            Employee employee1 = new Employee() { FirstName = "Jim", LastName = "Browning", Id = 32459 };
            Employee employee2 = new Employee() { FirstName = "Imbiamba", LastName = "Jones", Id = 34547 };
            // Using the overloaded "=" operator to compare employee ID's
            Console.WriteLine("Is the ID of employee 1 equal to employee 2? \r\n" + (employee1 == employee2));
            Console.ReadLine();
        }
    }
}
