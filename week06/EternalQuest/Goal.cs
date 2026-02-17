using System.Runtime.CompilerServices;

public class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }


    public void RecordEvent()
    {
        //TODO
    }

    public bool IsCompleted()
    {
        // TODO
        return false;
    }

    public string GetDetailsString()
    {
        // TODO
        return "";
    }

    public string GetStringRepresentation()
    {
        //TODO
        return "";
    }
}