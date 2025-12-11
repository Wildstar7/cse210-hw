public class ChecklistGoal : Goal
{
    // Variables
    private int _amountCompleted;
    private int _target;
    private int _bonuse;

    // Constructors
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonuse = bonus;
    }

    // Methods
    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}