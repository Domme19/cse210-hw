public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62; 
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