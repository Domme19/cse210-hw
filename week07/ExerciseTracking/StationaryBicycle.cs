public class StationaryBicycle : Activity
{
    private double _speed; 

    public StationaryBicycle(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        double product = _speed * GetMinutes();
        return product / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}