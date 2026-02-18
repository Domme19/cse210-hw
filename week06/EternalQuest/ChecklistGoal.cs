using System.Drawing;
using System.Threading.Channels;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isComplete;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _isComplete = false;
        _target = target;
        _bonus = bonus;
    }



     
    public override void RecordEvent()
    {
        // TODO: 
    }

    public override bool IsCompleted()
    {
    //    TODO
        return false;
    }

    public override string GetDetailsString()
    {
        // TODO
        return "in progress";
    }

    public override string GetStringRepresentation()
    {
        // TODO: 
        return "in progress"; 
    }
}