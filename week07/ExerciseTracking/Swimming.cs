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
    public override string GetActivityName()
    {
        return "Swimming";
    }

    public override double CalculateDistance()
    {
        return _laps * 50.0 / 1000.0 * 0.62;
    }
}