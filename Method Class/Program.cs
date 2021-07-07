using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the class
            Operations Operate = new Operations();
            // Calls the method with defined arguments for code legibility
            Operate.notRandom(input: 2, display: 12);
            Console.ReadLine();
        }
    }
}
