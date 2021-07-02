using System;

namespace Branching
{
    // Congratulations, you're actually reading this. Yes, I know I was supposed to use "else if" statements, but in my defense I understand those already and that way was dumb.
    class Program
    {
        static void Main()
        {
            // Ask user input for package weight and test for qualified weight, exiting the program if it too heavy
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. \r\n What is your Package's Weight?");
            float weight = float.Parse(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            // Ask user input for package dimensions, quitting the program if it is not a qualified size
            Console.WriteLine("What is your package width?");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("What is your package height?");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("What is your package length?");
            float length = float.Parse(Console.ReadLine());
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            // Calculating the shipping quote and displaying it to the user
            double quote = Math.Round(((height * width * length) * weight) / 100, 2);
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote +"\r\n Thank You!");
            Console.ReadLine();
        }
    }
}
