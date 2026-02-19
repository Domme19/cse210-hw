using System.Diagnostics.Contracts;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        int minutes = GetMinutes();
        double division = distance / minutes;
        return division * 60; 
    }

    public override double GetPace()
    {
        int minutes = GetMinutes();
        double distance = GetDistance();
        return minutes / distance;
    }
}