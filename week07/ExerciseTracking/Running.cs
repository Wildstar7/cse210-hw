public class Running : Activity
{
    // Variables
    private double _distance;

    // Constructors
    public Running(string date, int duration, double distance) : base (date, duration)
    {
        _distance = distance;
    }

    // Methods
    public override string GetActivityName()
    {
        return "Running";
    }
    
    public override double CalculateDistance()
    {
        return _distance;
    }
}