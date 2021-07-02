using System;

namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy \r\nStudent Daily Report");


            // Asks user input for their name
            Console.WriteLine("What is your Name?");
            string name = Console.ReadLine();

            // Asks user input for their current course
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");

            // Asks user input for their current page, then converts the string to a number
            int page = Convert.ToInt32(Console.ReadLine());

            // Asks user input if they need help, then converts the string to a boolean
            Console.WriteLine("Do you need any help? Please answer \"true\" or \"false\"");
            bool help = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
