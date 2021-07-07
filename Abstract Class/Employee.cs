using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Employee : Person
    {
        // Creating a subclass from the "Person" Class and overriding the virtual function
        public override void SayName()
        {
            base.SayName();
        }
    }
}
