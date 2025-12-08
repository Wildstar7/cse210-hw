public class ReflectingActivity : Activity
{
    // Variables
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    // Constructors
    public ReflectingActivity() 
        : base(
            "Reflecting Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
            )
    {

    }

    // Methods
    public void Run()
    {
            Console.WriteLine("Reflecting Activity Placeholder");
            ShowSpinner(GetDuration());
    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestion()
    {

    }
}