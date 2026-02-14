using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
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
        const string BreathingName = "Breathing Activity"; 
        const string BreathingDesc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        const int BreathingDuration = 10;
        
        const string ReflectingName = "Reflecting Activity";
        const string ReflectingDesc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        const int ReflectingDuration = 20;

        const string ListingName = "Listing Activity"; 
        const string ListingDesc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."; 
        const int ListingDuration = 30; 



        
        // TODO: Build a Menu for testing Purpose for now

      
        bool hasStopped = false; 
       

        while (!hasStopped)
        {
            DisplayMenu();
            int choice = GetSelectedChoice(); 

            switch (choice)
            {
                case BreathingChoice:
                    Activity breathing = new Activity(BreathingName, BreathingDesc, BreathingDuration); 
                    breathing.DisplayStartingMessage();
                    break;
                case ReflectingChoice: 
                    Activity reflecting = new Activity(ReflectingName, ReflectingDesc, ReflectingDuration); 
                    reflecting.DisplayStartingMessage(); 
                    break;
                case ListingChoice:
                    Activity listing = new Activity(ListingName, ListingDesc, ListingDuration);
                    listing.DisplayStartingMessage(); 
                    break;
                case QuitChoice:
                    hasStopped = true; 
                    Console.WriteLine($"You have terminated the program"); 
                    break;
                default: 
                    Console.WriteLine("Invalid choice"); 
                    break;
            }

        }
       
    }
}