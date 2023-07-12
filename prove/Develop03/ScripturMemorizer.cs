
namespace edu.byui.cs210.dev3;
using System;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorizer program");
        Console.WriteLine("Press Enter to start, and quit when finished");


        var myScripture = new Scripture(("“For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.”"), new Reference("John 3:16"));

        while (true)
        {
            Console.Write("Enter/Quit:");
            string userInput = Console.ReadLine();

            if (String.Equals(userInput, "quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            Console.Clear();
            myScripture.Print();
            Console.WriteLine();
        }


    }

}