using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static Journal journal = new Journal();

    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void WriteNewEntry()
    {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Length);
        string prompt = prompts[index];

        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Response: ");
        string response = Console.ReadLine();

        journal.AddEntry(prompt, response);

        Console.WriteLine("Entry added successfully!");
    }

    static void DisplayJournal()
    {
        journal.DisplayEntries();
    }

    static void SaveJournal()
    {
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();

        try
        {
            journal.SaveToFile(filename);
            Console.WriteLine("Journal saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    static void LoadJournal()
    {
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();

        try
        {
            journal.LoadFromFile(filename);
            Console.WriteLine("Journal loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}
