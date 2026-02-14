using System.Dynamic;
using System.Runtime.InteropServices;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }



    public string GetRandomPrompt()
    {
         Random random = new Random();
        int currentIndex = random.Next(0, _prompts.Count); 
        return _prompts[currentIndex]; 
    }

    public int GetCount()
    {
        return _count;
    }

    public List<string> GetListFromUser()
    {
        List<string> answers = new List<string>();
        return answers;
    }


    public void Run()
    {
        // TODO
        Console.WriteLine("List as many responses you can to the following prompt");
        string chosenPrompt = GetRandomPrompt();
        Console.WriteLine($"----- {chosenPrompt} -----");
        Console.Write("You may begin in: ");
        ShowCountDown(4);
        Console.WriteLine(); 
       
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while(DateTime.Now < endTime)
        {
            Console.Write("> ");
            string answer = Console.ReadLine(); 
            _count++;
        }

        Console.WriteLine($"You listed {_count} items");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(2);
        Console.WriteLine();
        DisplayEndingMessage(); 
        ShowSpinner(3);
    }

}