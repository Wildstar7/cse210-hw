public abstract class Activity
{
    // Variables
    private string _date;
    private int _duration;

    // Constructors
    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    // Methods
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public string GetDate()
    {
        return _date;
    }
    
    public int GetDuration()
    {
        return _duration;
    }
}