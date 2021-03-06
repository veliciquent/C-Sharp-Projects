using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class
            Operations Operate = new Operations();
            // Ask the user for their selected integer to operate on
            Console.WriteLine("What number would you like to operate on?");
            int input = Int32.Parse(Console.ReadLine());
            // Calling the "Operations" class for each method and casting the input as the different input types, returning the result to the console
            Console.WriteLine("Int: " + Operate.notRandom(input) + "\r\nFloat: " + Operate.notRandom((float)input) + "\r\nString: " + Operate.notRandom(input.ToString()));
            Console.ReadLine();
        }
    }
}
