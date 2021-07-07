using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates an interface object of type Employee, and calls the "Quit" function on it
            IQuittable quitter = new Employee();
            quitter.Quit();
        }
    }
}
