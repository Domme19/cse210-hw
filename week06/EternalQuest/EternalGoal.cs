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
        return "in progress";
    }

    public override string GetStringRepresentation()
    {
        // TODO: 
        return "in progress"; 
    }
}