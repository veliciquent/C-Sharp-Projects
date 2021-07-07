using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission
{
    class Operations
    {
        // Creating a class with an output and an overloaded input that halves the given input
        public static void Halve(out int output, int input = 2)
        {
            output = input / 2;
        }
    }
}
