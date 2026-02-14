using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{

    private static void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Starting reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit"); 
    }

    public static int GetSelectedChoice()
    {
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());
        return choice; 
    }
    static void Main(string[] args)
    {
        // TODO: Create Class Activity
        // setting up constants
        const int BreathingChoice = 1;
        const int ReflectingChoice = 2; 
        const int ListingChoice = 3;
        const int QuitChoice = 4; 
        bool hasStopped = false; 
        // TODO: Build a Menu for testing Purpose for now
       
       
        while (!hasStopped)
        {
            DisplayMenu();
            int choice = GetSelectedChoice(); 

            switch (choice)
            {
                case BreathingChoice:
                    // clear console
                    // Console.Clear(); 
                    Console.WriteLine($"You have picked {choice}: the breathing Activity"); 
                    break;
                case ReflectingChoice: 
                    // Console.Clear(); 
                    Console.WriteLine($"You have picked {choice}: the Reflecting Activity"); 
                    break;
                case ListingChoice:
                    // Console.Clear(); 
                    Console.WriteLine($"You have picked {choice}: the Listing Activity"); 
                    break;
                case QuitChoice:
                    // Console.Clear();
                    hasStopped = true; 
                    Console.WriteLine($"You have terminated the program"); 
                    break;
                default:
                    // Console.Clear(); 
                    Console.WriteLine("Invalid choice"); 
                    break;
            }

        }
       
    }
}