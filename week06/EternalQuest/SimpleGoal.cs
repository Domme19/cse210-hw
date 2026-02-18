using System.Runtime.CompilerServices;

public class SimpleGoal: Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, int points): base(shortName, description, points)
    {
        _isComplete = false;
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