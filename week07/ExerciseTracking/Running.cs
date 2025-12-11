public class Running : Activity
{
    // Variables
    private int _distance;

    // Constructors
    public Running(string date, int duration, int distance) : base (date, duration)
    {
        _distance = distance;
    }

    // Methods
    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return (_distance / GetDuration()) / 60;
    }

    public override double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }
}