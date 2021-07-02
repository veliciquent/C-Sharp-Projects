using System;


namespace String_Assignment
{
    class Program
    {
        static void Main()
        {
            //Creates a stringbuilder and concatenates the strings, and then converts it back to a string to make it uppercase for unneccesary complication because why not?
            System.Text.StringBuilder myName = new System.Text.StringBuilder("My name ");
            myName.Append("is Josh ");
            myName.Append("and I love ");
            myName.Append("legible code!");
            string upperName = myName.ToString().ToUpper();
            Console.WriteLine(upperName);
            Console.ReadLine();

            // Generates random placeholder text and puts appended text on a new line
            System.Text.StringBuilder placeholder = new System.Text.StringBuilder("");
            placeholder.Append("Lorem ipsum dolor sit amet, consectetur adipiscing elit. \r\n");
            placeholder.Append("Donec lorem metus, fermentum in consectetur ac, dictum non sapien. \r\n");
            placeholder.Append(" Phasellus dui nunc, pulvinar sit amet convallis vel, sodales sed nisi. \r\n");
            placeholder.Append("Suspendisse finibus fermentum est, finibus scelerisque nunc ornare quis. \r\n");
            placeholder.Append("Fusce at rhoncus magna, et hendrerit tortor. \r\n");
            placeholder.Append("Maecenas tellus augue, tristique ac nunc et, efficitur fermentum augue. \r\n");
            placeholder.Append("Donec vestibulum egestas urna et fermentum. Mauris nec risus malesuada, semper nibh vitae, aliquet velit. \r\n");
            placeholder.Append("Duis pretium leo turpis, et fringilla turpis tincidunt et. Donec sit amet vehicula elit. \r\n");
            placeholder.Append("Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.");
            Console.WriteLine(placeholder);
            Console.ReadLine();
        }
    }
}
