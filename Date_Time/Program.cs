using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tell user current time
            Console.WriteLine("The current time is: {0}", DateTime.Now);
            // Prompt user for a number, then store that number as a timespan
            Console.WriteLine("Please enter a number of hours");
            TimeSpan hours = new TimeSpan(0, Int32.Parse(Console.ReadLine()), 0 ,0);
            // Combine the current date/time with user timespan
            Console.WriteLine("The new time {0} hours from now is {1}", hours.Hours, DateTime.Now + hours);
            Console.ReadLine();
        }
    }
}
