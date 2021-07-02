using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main()
        {
            // Asks user input for arbitary boolean which in this case is music playing.
            Console.WriteLine("Is the Music Playing? Please respond true/false");
            bool music = bool.Parse(Console.ReadLine());
            // Creates a while loop that executes at least once regardless of the above input
            do
            {
                Console.WriteLine("You start dancing");

                // Creates a while loop that tests if the arbitrary user input is false, exiting the program after shaming the user.
                // Yes I know this is basically an if statement, no I couldn't think of anything else.
                while (music == false)
                {
                    Console.WriteLine("But no music is playing, so you look like a fool!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                
                // If the preceding while loop is not executed, gives statement of affirmation on the user's groovy dance moves that in reality are likely non-existent.
                Console.WriteLine("Your groovy moves strike with the beat, causing everyone to cheer you one. You're the hero of the party!");
                Console.ReadLine();
                Environment.Exit(0);
            } while (music == true);
        }
    }
}
