using System;

class Program
{
    static void Main(string[] args)
    {       
        // For the Breathing Activity, I've added functionality to the
        // ShowCountdown method so that it can be used to count up for
        // breathing in.
        
        
        int menuLoop = 1;
        while (menuLoop != 0)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program:\n");
            Console.WriteLine("  1) Start Breathing Activity");
            Console.WriteLine("  2) Start Reflecting Activity");
            Console.WriteLine("  3) Start Listing Activity");
            Console.WriteLine("  4) Quit");

            Console.Write("\nSelect a choice from the menu: ");
            string userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.DisplayStartingMessage();
                    breathing.Run();
                    breathing.DisplayEndingMessage();
                    break;

                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.DisplayStartingMessage();
                    reflecting.Run();
                    reflecting.DisplayEndingMessage();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.DisplayStartingMessage();
                    listing.Run();
                    listing.DisplayEndingMessage();
                    break;

                case "4":
                    menuLoop = 0;
                    break;

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
    
    // It doesn't seem like trying to set up this function is going to
    // work, so I'll manually do this for each activity

    // static void ExecuteMenuOption(Activity chosenActivity)
    // {
    //     chosenActivity.DisplayStartingMessage();
    //     chosenActivity.Run();
    //     chosenActivity.DisplayEndingMessage();
    // }
}