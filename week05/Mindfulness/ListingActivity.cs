public class ListingActivity : Activity
{
    // Variables
    private int _count;
    private List<string> _prompts = new List<string>();

    // Constructors
    public ListingActivity() 
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
            )
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