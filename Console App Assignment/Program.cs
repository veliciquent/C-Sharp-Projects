using System;
using System.Collections.Generic;

namespace Console_App_Assignment
{
    class Program
    {
        static void Main()
        {
            // Part 1, asks for user input and appends the string to each item within the array
            Console.WriteLine("What format would you like to convert the files to? (e.g .txt)");
            string format = Console.ReadLine();
            string[] files = new string[] { "Josh", "Is", "Unoriginal", "With", "Strings" };
            for (int i = 0; i <= format.Length; i++)
            {
                files[i] += format;
                Console.WriteLine(files[i]);
            }
            
            // Part 2, Creates an infinite loop that SIKE! Isn't actually infinite.
            Console.WriteLine("\r\nPart 2");
            int loopForever = 5;
            while (loopForever < 5)
            {

                Console.WriteLine("Oh NO, is this iNfINiTE?!??");
                loopForever += 1;
            }

            // Part 3, creates for loops that evalueate at both the "<" and <=" operators
            Console.WriteLine("\r\nPart 3");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Break\r\n");

            for (int i = 0; i  <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Break\r\n");

            // Part 4, Asks for a user input to search for
            Console.WriteLine("\r\nPart 4");
            Console.WriteLine("Input a value to search the list for:");
            string listIndex = (Console.ReadLine());
            //Creates a boolean to record whether a match was found in the iteration
            bool matchfound = false;
            List<string> originalString = new List<string>() { "Josh", "Is", "Unoriginal", "With", "Strings" };
            // Iterates through the string, comparing each index to the user input
            for (int i = 0; i < originalString.Count; i++)
            {
                if (originalString[i] == listIndex)
                {
                    Console.WriteLine("Your value is located at index: " + (i));
                    matchfound = true;
                    break;
                }
            }
            if (matchfound == false) { Console.WriteLine("That value was not found"); }
            Console.ReadLine();

            // Part5, iterates through each unit in the list within itself to find any duplicate values.
            Console.WriteLine("\r\nPart 5");
            List<string> unoriginalString = new List<string>() { "Josh", "Is", "Unoriginal", "With", "Josh" };
            List<string> unoriginalDupe = new List<string>();
            // Iterates through each part of the list for every index, adding the value to the duplicated list. If it exists, it diplays to the user that it is a duplicate.
            foreach (string i in unoriginalString)
            {
                if (unoriginalDupe.Contains(i))
                {
                    Console.WriteLine(i + " already exists!");
                }
                else Console.WriteLine(i); unoriginalDupe.Add(i);
            }
            Console.ReadLine();
        }
    }
}
