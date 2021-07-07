using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Employee : Person
    {
        // Creating a subclass from the "Person" Class and overriding the virtual function
        public int Id { get; set; }
        public override void SayName()
        {
            base.SayName();
        }
    }
}
