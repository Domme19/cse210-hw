public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        
    }


    // GETTERS
    public override int GetPoints()
    {
        return _points;
    }

    public override int GetBonus()
    {
        return 0; 
    }


    public override int GetAmountCompleted()
    {
        return 0; 
    }



     public override void RecordEvent()
    {
        // TODO: Nothing to do
    }

    public override bool IsCompleted()
    {
    //    TODO
        return false;
    }

    public override string GetDetailsString()
    {
        // TODO
        string formattedString = $"[] {_shortName} ({_description})"; 
        return formattedString;
    }

    public override string GetStringRepresentation()
    {
        // TODO:
        return $"EternalGoal:{_shortName}, {_description}, {_points}"; 
    }
}