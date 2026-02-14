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

        const string BreathingName = "Breathing"; 
        const string BreathingDesc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        const string ReflectingName = "Reflecting";
        const string ReflectingDesc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        const string ListingName = "Listing"; 
        const string ListingDesc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."; 
        // TODO: Build a Menu for testing Purpose for now

      
        bool hasStopped = false; 
       

        while (!hasStopped)
        {
            DisplayMenu();
            int choice = GetSelectedChoice(); 

            switch (choice)
            {
                case BreathingChoice:
                    // Breathing section
                    BreathingActivity breathing = new BreathingActivity(BreathingName, BreathingDesc, 0); 
                    breathing.DisplayStartingMessage();
                    breathing.ShowSpinner(breathing.GetDuration()); 
                    breathing.Run(); 
                    breathing.ShowSpinner(2); 
                    breathing.DisplayEndingMessage(); 

                    break;
                case ReflectingChoice: 
                    // Reflecting section
                    List<string> prompts = ["Think of a time when you stood up for someone else.",
                                            "Think of a time when you did something really difficult.",
                                            "Think of a time when you helped someone in need.",
                                            "Think of a time when you did something truly selfless."
                                            ];
                    
                    List<string> questions = ["Why was this experience meaningful to you?",
                                                "Have you ever done anything like this before?",
                                                "How did you get started?",
                                                "How did you feel when it was complete?",
                                                "What made this time different than other times when you were not as successful?", 
                                                "What is your favorite thing about this experience?", 
                                                "What could you learn from this experience that applies to other situations?",
                                                "What did you learn about yourself through this experience?",
                                                "How can you keep this experience in mind in the future?"
                                            ];

                    ReflectingActivity reflecting = new ReflectingActivity(ReflectingName, ReflectingDesc, 0, prompts, questions); 
                    reflecting.DisplayStartingMessage(); 
                    reflecting.ShowSpinner(reflecting.GetDuration()); 
                    reflecting.Run(); 
                    break;
                case ListingChoice:
                    Activity listing = new Activity(ListingName, ListingDesc, 0);
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