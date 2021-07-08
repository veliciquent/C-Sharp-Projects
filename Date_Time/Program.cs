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
            Console.WriteLine("The current time is: {0}", DateTime.Now);
            Console.WriteLine("Please enter a number of hours");
            TimeSpan hours = new TimeSpan(0, Int32.Parse(Console.ReadLine()), 0 ,0);
            Console.WriteLine("The new time {0} hours from now is {1}", hours.Hours, DateTime.Now + hours);
            Console.ReadLine();
        }
    }
}
