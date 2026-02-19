using System.Drawing;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class SimpleGoal: Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, int points, bool isComplete): base(shortName, description, points)
    {
        _isComplete = isComplete;
    }


    public override int GetBonus()
    {
        return 0; 
    }
    public override bool IsCompleted()
    {
    //    TODO
        return _isComplete;
    }

    public override int GetAmountCompleted()
    {
        return 0; 
    }

    public override void RecordEvent()
    {
        // TODO: 
        _isComplete = true;
    }


    // Getters
    public override int GetPoints()
    {
        return _points;
    }

    public override string GetDetailsString()
    {
        // TODO
        if (_isComplete)
        {
            return $"[X] {_shortName} ({_description})"; 
        }
        return  $"[] {_shortName} ({_description})"; 
    }

    public override string GetStringRepresentation()
    {
        // TODO: 
        return $"SimpleGoal:{_shortName}, {_description}, {_points}, {_isComplete}"; 
    }
}