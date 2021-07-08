using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Operations
    {
        //Creating 3 methods for the "Operations" class, that each mathemtically operate on the given input based on the input type
        public int notRandom(int input)
        {
            return input * input;
        }

        public int notRandom(float input)
        {
            return (int)(input / 5);
        }

        public int notRandom(string input)
        {
            return Int32.Parse(input) * 100;
        }
    }
}
