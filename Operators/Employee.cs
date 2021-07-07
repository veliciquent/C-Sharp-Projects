using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Employee : Person
    {
        public int Id { get; set; }
        // Creating a subclass from the "Person" Class and overriding the "==" and "!=" operators to return an boolean in relevance to the employee ID
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }
    }
}
