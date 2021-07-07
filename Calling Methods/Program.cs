using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations Operate = new Operations();
            // Ask the user for their selected integer to operate on
            Console.WriteLine("What number would you like to operate on?");
            int input = Int32.Parse(Console.ReadLine());
            // Calling the "Operations" class for each method and returning the result to the console
            Console.WriteLine("Square: " + Operate.Square(input) + "\r\nInverse: " + Operate.Inverse(input) + "\r\nPercentage: " + Operate.Percent(input) + "%");
            Console.ReadLine();
        }
    }
}
