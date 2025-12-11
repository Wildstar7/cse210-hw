using System.ComponentModel;

public class Goal
{
    // Variables
    private string _shortName;
    private string _description;
    private string _points;

    // Constructors
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Methods
    public virtual void RecordEvent()
    {
        
    }

    public virtual bool IsComplete()
    {
        return true;
    }

    public virtual string GetDetailsString()
    {
        return "";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }
}