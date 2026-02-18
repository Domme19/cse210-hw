public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        
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
        return $"EternalGoal:{_shortName}, {_description}, {_points}"; 
    }
}