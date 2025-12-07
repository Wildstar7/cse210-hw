using System.Web;

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
        ShowSpinner(3);  // Pause for a few seconds and show spinner animation

        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Wonderful job!");
        ShowSpinner(3);
        Console.WriteLine($"You completed the {_name} for {_duration} seconds!");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        int animationLength = 1;
        string backspaces = new string('\b', animationLength);
        string spaces = new string(' ', animationLength);
        List<string> spinnerStrings = new List<string> {"/","-","\\","|"};
        
        // Experimenting with some other ideas for spinners/animations
        // {
        //     "X         ",
        //     " +        ",
        //     "  X       ",
        //     "   +      ",
        //     "    X     ",
        //     "     +    ",
        //     "      X   ",
        //     "       +  ",
        //     "        X ",
        //     "         +",
        //     "        X ",
        //     "       +  ",
        //     "      X   ",
        //     "     +    ",
        //     "    X     ",
        //     "   +      ",
        //     "  X       ",
        //     " +        "
        // };


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        int i = 0;
        Console.CursorVisible = false;  // Hide cursor for smoother animation
        
        while (DateTime.Now < endTime)
        {
            string s = spinnerStrings[i];
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write($"{backspaces}{spaces}{backspaces}");

            i++;

            if (i >=spinnerStrings.Count)
            {
                i = 0;
            }
        }
        Console.CursorVisible = true;
    }

    public void ShowCountDown(int seconds, bool countUp = false)
    {
        List<string> countDownNumbers = new List<string>();

        int secondsDigits = seconds.ToString().Length;
        string numberTransition = new string ('\u2588', secondsDigits);
        string numberSpaces = new string(' ', secondsDigits);
        string numberBackspaces = new string('\b', secondsDigits);

        if (countUp)
        {
            for (int i = 0; i <= seconds; i++)
            {
                int iString = i.ToString().Length;
                countDownNumbers.Add($"{new string(' ', secondsDigits - iString)}{i + 1}");
                countDownNumbers.Add($"{numberTransition}");
            }
        }
        else
        {
            for (int i = seconds; i >= 0; i--)
            {
                int iString = i.ToString().Length;
                
                countDownNumbers.Add($"{new string(' ', secondsDigits - iString)}{i}");
                countDownNumbers.Add($"{numberTransition}");

                // if (secondsDigits == 2)
                // {
                //     if (iString.Length == 2)
                //     {
                //         countDownNumbers.Add($"{i}");
                //         countDownNumbers.Add("  ");
                //     }
                //     if (iString.Length == 1)
                //     {
                //         countDownNumbers.Add($" {i}");
                //         countDownNumbers.Add("  ");
                //     }
                // }
                // if (secondsDigits == 1)
                // {
                //     countDownNumbers.Add($"{i}");
                //     countDownNumbers.Add(" ");
                // }
            }
        }
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int j = 0;
        Console.CursorVisible = false;  // Hide cursor for smoother animation
        while (DateTime.Now < endTime)
        {
            string s = countDownNumbers[j];
            
            if (j % 2 == 0)
            {
                Console.Write(s);
                Thread.Sleep(950);
            }
            else
            {
                Console.Write(s);
                Thread.Sleep(50);
            }

            Console.Write($"{numberBackspaces}{numberSpaces}{numberBackspaces}");

            j++;

            if (j >=countDownNumbers.Count)
            {
                j = 0;
            }
        }
    }

    public int GetDuration()
    {
        return _duration;
    }
}