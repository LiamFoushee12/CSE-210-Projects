namespace edu.byui.cs210.dev4;
using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        MainMenu();
    }

    static void MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness app!");
        Console.WriteLine("");
        Console.WriteLine("Option 1: Breathing Activity");
        Console.WriteLine("Option 2: Listing Activity");
        Console.WriteLine("Option 3: Reflection Activity");
        Console.WriteLine("Option 4: Exit");
        Console.WriteLine("Select an option from the menu:");

        string myOptions = Console.ReadLine();
        Breathing breathingActivity = new Breathing();
        Listing listingActivity = new Listing();
        Reflecting reflectingActivity = new Reflecting();

        switch (myOptions)
        {
            case "1":
                breathingActivity.run();

                break;
            case "2":
                listingActivity.run();

                break;
            case "3":
                reflectingActivity.run();

                break;
            //case "4":
            //  Exit();
            //break;
            default:
                break;

        }

        MainMenu();






    }
}