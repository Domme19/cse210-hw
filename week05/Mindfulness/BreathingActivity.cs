using System.ComponentModel;
using System.Runtime.CompilerServices;

public class BreathingActivity : Activity
{
    // public BreathingActivity(string name, string description, int duration): base(name, description, duration)
    // {
    //     _name = "something"; 
    // }
    public BreathingActivity(string name, string description, int duration): base(name, description, duration)
    {
      
    }

   
    public void Run()
    {
        // Todo:
        Console.WriteLine("Breathing activity is running"); 
    }
}