public class Swimming : Activity
{
    // Variables
    private int _laps;

    // Constructors
    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    // Methods
    public override double CalculateDistance()
    {
        return _laps * 50 / 1000 * 0.52;
    }

    public override double CalculateSpeed()
    {
        return CalculateDistance() / GetDuration();
    }

    public override double CalculatePace()
    {
        return GetDuration() / CalculateDistance();
    }
}