public class Cycling : Activity
{
    // Variables
    private int _speed;

    // Constructors
    public Cycling(string date, int duration, int speed) : base(date, duration)
    {
        _speed = speed;
    }

    // Methods
    public override double CalculateDistance()
    {
        
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return 60 / _speed;
    }
}