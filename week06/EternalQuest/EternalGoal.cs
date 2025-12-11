public class EternalGoal : Goal
{
    // Constructors
    public EternalGoal (string name, string description, string points) : base(name, description, points)
    {
        
    }

    // Methods
    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}