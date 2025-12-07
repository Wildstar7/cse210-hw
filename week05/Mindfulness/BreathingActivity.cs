public class BreathingActivity : Activity
{
    // Constructors
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
            )
    {
        
    }

    // Methods
    public void Run()
    {        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        // The activity won't end perfectly on time, but it will at
        // least finish the current breath before exiting the activity
        while (DateTime.Now < endTime)
        {    
            Console.Write("Breathe in . . . ");
            ShowCountDown(3, true);
            Console.WriteLine();

            if (DateTime.Now < endTime)
            {
                Console.Write("Breathe out . . . ");
                ShowCountDown(3);
                Console.WriteLine("\n");
            }
        }
    }
}