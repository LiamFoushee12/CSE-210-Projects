using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static QuestManager questManager = new QuestManager();

    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Add a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. Calculate total score");
            Console.WriteLine("5. Save goals to a file");
            Console.WriteLine("6. Load goals from a file");
            Console.WriteLine("7. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    AddNewGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    DisplayGoals();
                    break;
                case "4":
                    CalculateTotalScore();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddNewGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal value: ");
        int value = int.Parse(Console.ReadLine());

        Goal goal;

        switch (choice)
        {
            case "1":
                goal = new SimpleGoal(name, value);
                break;
            case "2":
                goal = new EternalGoal(name, value);
                break;
            case "3":
                goal = new ChecklistGoal(name, value, value / 50); // Assuming 50 points per checklist item
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal not added.");
                return;
        }

        questManager.AddGoal(goal);
        Console.WriteLine("Goal added successfully!");
    }

    static void RecordEvent()
    {
        Console.Write("Enter the goal index to record the event: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        questManager.RecordEvent(goalIndex);
        Console.WriteLine("Event recorded successfully!");
    }

    static void DisplayGoals()
    {
        questManager.DisplayGoals();
    }

    static void CalculateTotalScore()
    {
        int totalScore = questManager.CalculateTotalScore();
        Console.WriteLine($"Total Score: {totalScore}");
    }

    static void SaveGoals()
    {
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();

        try
        {
            questManager.SaveToFile(filename);
            Console.WriteLine("Goals saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}
