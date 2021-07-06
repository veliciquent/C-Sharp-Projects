using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    class Operations
    {
        //Creating 3 methods for the "Operations" class, that each mathemtically operate on the given input
        public static int Square(int input)
        {
            return input * input;
        }

        public static float Inverse(int input)
        {
            return 1 / (float)input;
        }

        public static float Percent (int input)
        {
            return (float)input * 100;
        }
    }
}
