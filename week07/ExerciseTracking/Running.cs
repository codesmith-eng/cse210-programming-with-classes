public class Running : Activity
{
    private double _distance;

    // base(date, minutes) passes those values up to the Activity class
    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }


    // Overriding the abstract methods from the base class
    public override double GetDistance()
    {
        return _distance;
    }


    public override double GetSpeed()
    {
        // Speed (mph) = (distance / minutes) * 60
        return (_distance / GetMinutes()) * 60;
    }


    public override double GetPace()
    {
        // Pace = minutes / distance
        return GetMinutes() / _distance;
    }
}