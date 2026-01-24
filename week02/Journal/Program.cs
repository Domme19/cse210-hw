using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {

        // building the program
        int selectedOption = -1;
        
        // random prompts
        PromptGenerator newPromptGenerator = new PromptGenerator();
        newPromptGenerator._prompts.Add("If I had one thing I could do over today, what would it be?");
        newPromptGenerator._prompts.Add("What was the best part of my day?");
        newPromptGenerator._prompts.Add("What was the most challenging moment of my day, and how did I handle it?");
        newPromptGenerator._prompts.Add("What is one thing I’m grateful for today?");
        newPromptGenerator._prompts.Add("What did I learn about myself today?");

        // create the Journal Entries
        Journal newJournal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");

        while (selectedOption != 5)
        {
            Console.WriteLine("Please select one of the following Choices:");
            Console.WriteLine("1. Write"); 
            Console.WriteLine("2. Display"); 
            Console.WriteLine("3. Load"); 
            Console.WriteLine("4. Save"); 
            Console.WriteLine("5. Quit"); 

            Console.Write("What would you like to do?");
            selectedOption = int.Parse(Console.ReadLine().Trim());

            switch (selectedOption)
            {
                case 1:
                    string randomPrompt = newPromptGenerator.GetRandomPrompt();
                    Console.WriteLine($"{randomPrompt}");
                    Console.Write(">");
                    string answer = Console.ReadLine();

                    Entry newEntry = new Entry();
                    string currentDate = DateTime.Today.ToString("MM/dd/yyyy");
                    newEntry._date = currentDate;
                    newEntry._entryText = answer;
                    newEntry._promptText = randomPrompt;

                    // add to the Journal
                    newJournal.AddEntry(newEntry);
                    break;

                 case 2:
                    // Console.WriteLine("Display");
                    newJournal.DisplayAll();
                    break;

                 case 3:
                    Console.Write("What is the file name? ");
                    string fileName1 = Console.ReadLine();
                    newJournal.LoadFromFile(fileName1);
                    break;


                case 4:
                    // Console.WriteLine("Save");
                    Console.Write("What is the file name? ");
                    string fileName = Console.ReadLine();
                    newJournal.SaveToFile(fileName);
                    break;
                
                default:
                    Console.WriteLine("You have terminated the program!");
                    break;

            }

        }
       


    }
}