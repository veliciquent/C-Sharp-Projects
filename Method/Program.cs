using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their selected integer to operate on
            Console.WriteLine("What number would you like to operate on?");
            int input = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What number would you like to take it to the power of? If left blank it will square the number by default");
            try
            {
                int power = Int32.Parse(Console.ReadLine());
                Console.WriteLine(Operations.Power(input, power));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(Operations.Power(input));
            }
            // Calling the "Operations" class and returning the value to the console
            Console.ReadLine();
        }
    }
}
