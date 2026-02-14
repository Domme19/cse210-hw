using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Runtime.InteropServices;

public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration = 0;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    // public void SetName(string name)
    // {
    //     _name = name;
    // }

    // public void SetDescription(string description)
    // {
    //     _name = description;
    // }
    

    // public void SetDuration(int duration)
    // {
    //     _duration = duration;
    // }
    public void DisplayStartingMessage()
    {
        // building display starting Message
       Console.WriteLine($"Welcome to the {_name} Activity.");
       Console.WriteLine();
       Console.WriteLine(_description); 
       Console.WriteLine();
       Console.Write("How long, in seconds, would you like for your session? ");
       _duration = int.Parse(Console.ReadLine());
       Console.WriteLine("Get ready...");  
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity."); 
    }


    public void ShowSpinner(int seconds)
    {

        // List of all animation
        List<string> animationStrings = new List<string>(); 
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        // TODO: 
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0; 
        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;
            
            if (i >= animationStrings.Count)
            {
                i = 0; 
            }

        }
        
    }


    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
        }
    
    }
}