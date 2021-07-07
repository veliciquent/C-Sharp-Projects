using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list of employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee { FirstName = "Joe", LastName = "Fischer", Id = 1},
                new Employee { FirstName = "Lucas", LastName = "Goatsman", Id = 2},
                new Employee { FirstName = "Marie", LastName = "Heideger", Id = 3},
                new Employee { FirstName = "Norman", LastName = "Blockman", Id = 4},
                new Employee { FirstName = "Joe", LastName = "Pilosy", Id = 5},
                new Employee { FirstName = "Cynthia", LastName = "Thatcher", Id = 6},
                new Employee { FirstName = "Dublin", LastName = "Creed", Id = 7},
                new Employee { FirstName = "Freddy", LastName = "Mercury", Id = 8},
                new Employee { FirstName = "Lacy", LastName = "McDonald", Id = 9},
                new Employee { FirstName = "Truman", LastName = "Show", Id = 10},
            };

            // Create "for-each" loop that updates a new list with every employee named "Joe"
            List<Employee> employees1 = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    employees1.Add(employee);
                }
            }

            // Replicate the same effect as the previous loop but with a lambda expression
            List<Employee> employees2 = employees.Where(x => x.FirstName == "Joe").ToList();
            // Use a Lambda expression to create another list with all employees with ID's greater than 5
            List<Employee> employees3 = employees.Where(x => x.Id > 5).ToList();
        }
    }
}
