using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class
            Operations Operate = new Operations();
            // Requesting the user input for the number to halve
            Console.WriteLine("Enter a number to halve");
            int input = Int32.Parse(Console.ReadLine());
            // Calling the operation on the user input and returning it to the console
            Operate.Halve(out input, input);
            Console.WriteLine("Your halved number is; " + input);
            Console.ReadLine();
        }
    }
}
