using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating two employees with different passed variable types.
            Employee<string> employee = new Employee<string> { things = new List<string> { "Winner", "winner", "chicken", "dinner" } };
            Employee<int> employee2 = new Employee<int> { things = new List<int> { 3214, 254 ,48, 435 } };
            employee.SayThings();
            employee2.SayThings();
        }
    }
}
