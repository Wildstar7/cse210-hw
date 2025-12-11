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
    public abstract string GetActivityName();

    public string GetDate()
    {
        return _date;
    }
    
    public int GetDuration()
    {
        return _duration;
    }
    
    public virtual double CalculateSpeed()
    {
        return CalculateDistance() / GetDuration() * 60.0;
    }

    public virtual double CalculatePace()
    {
        return GetDuration() / CalculateDistance();
    }

    public virtual string GetSummary()
    {
        double distance = Math.Round(CalculateDistance(), 2);
        double speed = Math.Round(CalculateSpeed(), 2);
        double pace = Math.Round(CalculatePace(), 2);

        return $"{GetDate()} {GetActivityName()} ({GetDuration()} min) - Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";
    }
}