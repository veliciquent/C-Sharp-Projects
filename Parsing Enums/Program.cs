using System;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week");
                // Parsing the given user input string into an object, and from an object into a "Days" enum.
                Days today = (Days)Enum.Parse(typeof(Days),Console.ReadLine());
                Console.WriteLine("Today is {0}", today);
            }
            // Create a catch for any exceptions, displaying the exception message
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            finally
            {
                Console.WriteLine("The console has emerged from a try-catch block");
                Console.ReadLine();
            }
        }

        // Creating an enum for the days of the week
        public enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
