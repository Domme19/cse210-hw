using System.Dynamic;
using System.Linq.Expressions;
using System.Net;
using System.Security.Cryptography;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }


    


    public string GetRandomPrompt()
    {
        Random random = new Random();
        int currentIndex = random.Next(0, _prompts.Count); 
        return _prompts[currentIndex]; 
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int currentIndex = random.Next(0, _questions.Count);
        return _questions[currentIndex]; 
    }


    public void DisplayPrompt()
    {
        // TODO: display random Prompt;
        string chosenPrompt = GetRandomPrompt();
        Console.WriteLine($"----- {chosenPrompt} -----");
    }

    public void DisplayQuestion()
    {
        // TODO
        string chosenQuestion = GetRandomQuestion();
        Console.Write($"> {chosenQuestion} "); 
    }


    
    public void Run()
    {
        // TODO
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt(); 
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine(); // Waits for the Enter key specifically
        // questions
        Console.WriteLine("Now Ponder on each of the following questions as they related to this experience"); 
        Console.Write("You may begin: ");
        ShowCountDown(3); 
        Console.WriteLine(); 

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            DisplayQuestion(); 
            ShowSpinner(3); 
            Console.WriteLine(); 
            // Console.WriteLine();
        }

        Console.WriteLine(); 
        Console.WriteLine("Well Done!!");
        Console.WriteLine(); 
        DisplayEndingMessage(); 

    }

}