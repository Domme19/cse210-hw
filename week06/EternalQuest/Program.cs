using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

class Program
{
    private const int CreateNewGoal = 1;
    private const int ListGoals = 2;
    private const int SaveGoals = 3;
    private const int LoadGoals = 4;
    private const int RecordEvent = 5;
    private const int Quit = 6;
    private static void DisplayMainMenu()
    {
         // Create the Menu
        Console.WriteLine("You have 0 points");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
    }
    static void Main(string[] args)
    {
       
    //    Display Main menu
        DisplayMainMenu();
        
        // receive input to select menu 
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case CreateNewGoal:
                Console.WriteLine("Create new Goal");
                Console.WriteLine("in progress");
            break;

            case ListGoals:
                Console.WriteLine("List goals");
                Console.WriteLine("In progress");
            break;

            case SaveGoals:
                Console.WriteLine("Save Goals");
                Console.WriteLine("In progress");
            break;

            case LoadGoals:
                Console.WriteLine("Load Goals");
                Console.WriteLine("In progress");
            break;

            case RecordEvent:
                Console.WriteLine("Record Event");
                Console.WriteLine("In progress");
            break;

            case Quit:
                Console.WriteLine("You have terminated the program.");
            break;

            default:
                Console.WriteLine("Invalid choice");
            break;


        }
    }
}