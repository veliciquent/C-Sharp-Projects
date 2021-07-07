using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism
{
    class Employee : Person, IQuittable
    {
        // Creating a subclass from the "Person" Class and overriding the virtual function
        public override void SayName()
        {
            base.SayName();
        }
        // Calling "Quit" method from interface
        public void Quit()
        {
            Console.WriteLine("I Quit!");
            Console.ReadLine();
        }
    }
}
