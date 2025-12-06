public class ListingActivity : Activity
{
    // Variables
    private int _count;
    private List<string> _prompts = new List<string>();

    // Constructors
    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    // Methods
    public void Run()
    {

    }

    public void GetRandomPrompt()
    {

    }
    
    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}