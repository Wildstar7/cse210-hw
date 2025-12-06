public class Activity
{
    // Variables
    private string _name;
    private string _description;
    private int _duration;

    // Constructors
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    // Methods
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine(_description);

        Console.Write("\nHow long would you like for your session (in seconds)? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);

        Console.WriteLine("Get ready . . .");
        ShowSpinner(5);  // Pause for a few seconds and show spinner animation
    }

    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Wonderful job!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds!");
        ShowSpinner(7);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerStrings = new List<string> {
                                                        "X         ",
                                                        " +        ",
                                                        "  X       ",
                                                        "   +      ",
                                                        "    X     ",
                                                        "     +    ",
                                                        "      X   ",
                                                        "       +  ",
                                                        "        X ",
                                                        "         +",
                                                        "        X ",
                                                        "       +  ",
                                                        "      X   ",
                                                        "     +    ",
                                                        "    X     ",
                                                        "   +      ",
                                                        "  X       ",
                                                        " +        "
                                                        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i =0;
        Console.CursorVisible = false;
        while (DateTime.Now < endTime)
        {
            string s = spinnerStrings[i];
            Console.Write(s);
            Thread.Sleep(50);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                \b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");

            i++;

            if (i >=spinnerStrings.Count)
            {
                i = 0;
            }
        }
        Console.CursorVisible = true;
    }

    public void ShowCountDown(int seconds)
    {

    }
}