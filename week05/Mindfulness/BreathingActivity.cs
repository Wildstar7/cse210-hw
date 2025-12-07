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
        Console.Clear();
        
        for (int i = 3; i <= 10; i++)
        {
            Console.Write("Breathe in . . . ");
            ShowCountDown(i, true);
            Console.WriteLine();
            
            Console.Write("Breathe out . . . ");
            ShowCountDown(i);
            Console.WriteLine("\n");
        }

        for (int i = 9; i >= 3; i--)
        {
            Console.Write("Breathe in . . . ");
            ShowCountDown(i, true);
            Console.WriteLine();
            
            Console.Write("Breathe out . . . ");
            ShowCountDown(i);
            Console.WriteLine("\n");
        }
    }
}