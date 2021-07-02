using System;


namespace Math_Comparison_Operator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            // Ask for user input on Rate and hours worked on Person 1, then cast them to correct formats
            Console.WriteLine("Person1 \r\nHourly Rate: ");
            float p1Rate = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours Worked per Week: ");
            int p1Hours = Int32.Parse(Console.ReadLine());

            // Ask for user input on Rate and hours worked on Person 1, then cast them to correct formats
            Console.WriteLine("Person2 \r\nHourly Rate: ");
            float p2Rate = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours Worked per Week: ");
            int p2Hours = Int32.Parse(Console.ReadLine());

            // Assign values to both Persons salaries, then define if whose is greater
            float p1Salary = (float)p1Rate * (p1Hours *52);
            float p2Salary = (float)p2Rate * (p2Hours *52);
            bool greaterSal = p1Salary > p2Salary;

            // Display relevant information
            Console.WriteLine("Annual salary of Person 1: \r\n" + p1Salary);
            Console.WriteLine("Annual salary of Person 2: \r\n" + p2Salary);
            Console.WriteLine("Does Person1 make more money than Person2? \r\n" + greaterSal);
            Console.ReadLine();
        }
    }
}
