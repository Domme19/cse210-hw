using System.Runtime.CompilerServices;

public class SimpleGoal: Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, int points, bool isComplete): base(shortName, description, points)
    {
        _isComplete = isComplete;
    }

}