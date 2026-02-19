using System.Drawing;
using System.Runtime;
using System.Threading.Channels;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isComplete;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus, int amountCompleted) : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _isComplete = false;
        _target = target;
        _bonus = bonus;
    }

    
    // Getters
    public override int GetPoints()
    {
        return _points;
    }

    public override int GetBonus()
    {
        return _bonus; 
    }

    public override int GetAmountCompleted()
    {
        return _amountCompleted; 
    }
     
    public override bool IsCompleted()
    {
    //    TODO
        if (_amountCompleted < _target)
        {
            _isComplete = false;
            return _isComplete;
        }
        _isComplete = true;
        return _isComplete;
    }


    public override void RecordEvent()
    {
        _amountCompleted += 1;
    }
   

    public override string GetDetailsString()
    {
        // TODO
        if (IsCompleted())
        {
            return  $"[X] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}"; 
        }
        return $"[] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        // TODO:
         return $"ChecklistGoal:{_shortName}, {_description}, {_points}, {_bonus}, {_target}, {_amountCompleted}"; 
    }
}