using System;
using System.Collections.Generic;


namespace Console_App_Strings_And_Integers
{
    class Program
    {
        static void Main()
        {
            // Create integer list, and enter Try-Catch block
            List<int> integers = new List<int>() { 15, 257, 345, 45 };
            Console.WriteLine("Enter a whole number to divide the integers by:");
            try
            {
                Console.WriteLine("Program has entered a \"try-catch\" block");
                float divisible = float.Parse(Console.ReadLine());

                // Alternate code because apparently Divide by zero exceptions are now handelded by the "∞" symbol
                while (divisible == 0)
                {
                    Console.WriteLine("Unable to divide by zero");
                    divisible = float.Parse(Console.ReadLine());
                }
                // Iterating through the list, printing the divisible result.
                for (int i = 0; i < integers.Count; i++)
                {
                    Console.WriteLine(integers[i] / divisible);
                }
            }
            // Create a catch for invalid formats, a.k.a strings
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a number");
            }
            // Create a seemingly inconsequential catch for dividing by zero
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Unable to divide by zero");
            }
            // Create a catch for any other exceptions, displaying the exception message
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The console has emerged from a try-catch block");
                Console.ReadLine();
            }
        }
    }
}
