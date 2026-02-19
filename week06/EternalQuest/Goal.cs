using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }


    // getters
    public abstract int GetPoints(); 
    public abstract int GetBonus();
    
    public abstract int GetAmountCompleted(); 

    public abstract void RecordEvent(); 

    public abstract bool IsCompleted();


    public abstract string GetDetailsString();

    public  abstract string GetStringRepresentation();
}