using System.Drawing;
using System.Runtime.CompilerServices;

public class SimpleGoal: Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, int points, bool isComplete): base(shortName, description, points)
    {
        _isComplete = isComplete;
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
        string formattedString = $"[ ] {_shortName} ({_description})"; 
        return formattedString; 
    }

    public override string GetStringRepresentation()
    {
        // TODO: 
        return $"SimpleGoal:{_shortName}, {_description}, {_points}, {_isComplete}"; 
    }
}