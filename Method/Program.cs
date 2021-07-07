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
            Operations = new Operations();
            // Ask the user for their selected integer to operate on
            Console.WriteLine("What number would you like to operate on?");
            int input = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What number would you like to take it to the power of? If left blank it will square the number by default");
            // Create a "Try-Catch" block in case the user chooses not to enter a second value, calling each function with/without the overload if given;
            try
            {
                int power = Int32.Parse(Console.ReadLine());
                Console.WriteLine(Operations.Power(input, power));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(Operations.Power(input));
            }
            Console.ReadLine();
        }
    }
}
