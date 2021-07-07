using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Employee<T> : Person
    {
        // Creating a sublcass of person that has a generic that is included as a new list of "things"
        public List<T> things = new List<T>();
        public override void SayName()
        {
            base.SayName();
        }

        // Creating a method that when called iterates through the list of "things"
        public void SayThings()
        {
            foreach ( T thing in things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
