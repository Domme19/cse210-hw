using System.Runtime.CompilerServices;

public abstract class Goal
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


    public abstract void RecordEvent(); 

    public abstract bool IsCompleted();


    public abstract string GetDetailsString();

    public  abstract string GetStringRepresentation();
}