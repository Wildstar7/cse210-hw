public class SimpleGoal : Goal
{
    // Variables
    private bool _isComplete;

    // Constructors
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
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