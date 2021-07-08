using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Operations
    {
        // Creating a method that multiplies the given number by a power, that is an overloaded argument
        public int Power(int input, int power = 2)
        {
            if (power == 0)
            {
                return 1;
            }
            int tempInput = input;
            for (int i = 1; i < power; i++)
            {
                tempInput = tempInput * input;
            }
            return tempInput;
        }
    }
}
