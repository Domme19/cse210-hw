using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration): base(name, description, duration)
    {
      
    }


    public void Run()
    {
        // Todo:
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine(); 
            Console.Write("Now breathe out...");
            ShowCountDown(5); 
            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine("Well Done!"); 
    }
        


}