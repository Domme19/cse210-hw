using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        // program start:
        // Console.WriteLine("Press Enter to continue or type quit to finish"); 
        // string answer = Console.ReadLine();
        // Console.WriteLine("The answer is: ", answer); 


        // testing scripture class

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding " +
                      "In all thy ways acknowledge him and he shall direct thy paths";
        
        Scripture scripture = new Scripture(reference, text);
        bool isNotStopped = false;

        while (!isNotStopped)
        {
            Console.Clear(); 
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide words or type 'quit' to exit:");
            string cmdInput = Console.ReadLine();
            string cleanedInput = cmdInput.Trim().ToLower();

            if (cleanedInput == "quit")
            {
                isNotStopped = true;
            }

            if (scripture.IsCompletelyHidden())
            {
                isNotStopped = true;
            }

            scripture.HideRandomWords(3);

        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Program terminated!"); 




    
    }
}