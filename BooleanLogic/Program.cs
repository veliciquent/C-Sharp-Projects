using System;


namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            // Gather user input age, DUI status, and number of tickets, and parse them into relevant information
            Console.WriteLine("What is your age?");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please respond true/false");
            bool DUI = bool.Parse(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Int32.Parse(Console.ReadLine());

            // Test each variable to see if they meet specified qualifications
            bool qualifies = age > 15 && DUI == false && tickets < 3;

            // Display the result of there qualified status
            Console.WriteLine("Qualified?\r\n" + qualifies);
            Console.ReadLine();
        }
    }
}
