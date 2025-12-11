public class Cycling : Activity
{
    // Variables
    private double _speed;

    // Constructors
    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    // Methods
    public override string GetActivityName()
    {
        return "Cycling";
    }

    public override double CalculateDistance()
    {
        return _speed * GetDuration() / 60;
    }
}