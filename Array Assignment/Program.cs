using System;
using System.Collections.Generic;

namespace Array_Assignment
{
    class Program
    {
        static void Main()
        {
            // Asks user for input for which index to recieve for the string Array
            Console.WriteLine("Which index (1-5) of the string array should be displayed?");
            string[] stringArray = new string[] { "My", "name", "is", "Josh", "fifthWord" };
            int stringIndex = Int32.Parse(Console.ReadLine());
            // Tests if the selected index exists, repeatedly asks for a new one if it does not
            while (stringIndex > stringArray.Length)
            {
                Console.WriteLine("That index does not exist, please select another between 1-5");
                stringIndex = Int32.Parse(Console.ReadLine());
            }
            // Displays the selected index, (minus one because lists and indexes begin at 0)
            Console.WriteLine(stringArray[stringIndex - 1]);

            // Asks user for input for which index to recieve for the int Array
            Console.WriteLine("Which index (1-5) of the integer array should be displayed?");
            int[] intArray = new int[] { 21, 345, 456, 6367, 7567 };
            int intIndex = Int32.Parse(Console.ReadLine());
            // Tests if the selected index exists, repeatedly asks for a new one if it does not
            while (intIndex > intArray.Length)
            {
                Console.WriteLine("That index does not exist, please select another between 1-5");
                intIndex = Int32.Parse(Console.ReadLine());
            }
            // Displays the selected index, (minus one because lists and indexes begin at 0)
            Console.WriteLine(intArray[intIndex - 1]);

            // Asks user for input for which index to recieve for the string List
            Console.WriteLine("Which index (1-5) of the string array should be displayed?");
            List<string> stringList = new List<string>();
            stringList.Add("I need");
            stringList.Add("to think");
            stringList.Add("of a");
            stringList.Add("new");
            stringList.Add("sentence.");
            int listIndex = Int32.Parse(Console.ReadLine());
            // Tests if the selected index exists, repeatedly asks for a new one if it does not
            while (listIndex > stringList.Count)
            {
                Console.WriteLine("That index does not exist, please select another between 1-5");
                listIndex = Int32.Parse(Console.ReadLine());
            }
            // Displays the selected index, (minus one because lists and indexes begin at 0)
            Console.WriteLine(stringList[listIndex - 1]);
            Console.ReadLine();
        }
    }
}