using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        int userChoice;


        Console.WriteLine("Welcome to the Journal Program!");
        Journal currentJournal = new Journal();
        PromptGenerator freshPrompts = new PromptGenerator();

        do
        {
            userChoice = DisplayMenu();

            switch (userChoice)
            {
                // Write
                case 1:
                    Console.Clear();  // Clear screen
                    Console.Write("\x1b[3J");  // Clear scrollback buffer
                    Entry currentEntry = new Entry();
                    DateTime currentTime = DateTime.Now;
                    currentEntry._date = currentTime.ToShortDateString();
                    currentEntry._promptText = freshPrompts.GetRandomPrompt();
                    Console.WriteLine(currentEntry._promptText);
                    currentEntry._entryText = (Console.ReadLine());
                    currentJournal.AddEntry(currentEntry);
                    Console.Write("Press <ENTER> return to main menu . . .");
                    Console.ReadLine();
                    break;
                // Display
                case 2:
                    Console.Clear();  // Clear screen
                    Console.Write("\x1b[3J");  // Clear scrollback buffer
                    currentJournal.DisplayAll();
                    Console.Write("Press <ENTER> to return to main menu . . .");
                    Console.ReadLine();
                    break;
                // Load
                case 3:
                    Console.Clear();  // Clear screen
                    Console.Write("\x1b[3J");  // Clear scrollback buffer

                    // Get file to load from user
                    Console.Write("What file would you like to load? ");
                    string fileToLoad = Console.ReadLine();

                    currentJournal.LoadFromFile(fileToLoad);
                    Console.WriteLine($"{fileToLoad} has been loaded");
                    Console.Write("Press <ENTER> to return to main menu . . .");
                    Console.ReadLine();
                    break;
                //Save
                case 4:
                    Console.Clear();  // Clear screen
                    Console.Write("\x1b[3J");  // Clear scrollback buffer

                    // Get filename from user
                    Console.Write("What would you like to call the file? ");
                    string fileToSave = Console.ReadLine();

                    currentJournal.SaveToFile(fileToSave);
                    Console.WriteLine($"Your journal has been saved to {fileToSave}");
                    Console.Write("Press <ENTER> to return to main menu . . .");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        } while (userChoice != 5);  // Quit

        Console.WriteLine("Goodbye!");

        return;
    }

    static int DisplayMenu()
    {
        while (true)
        {
            Console.Clear();  // Clear screen
            Console.Write("\x1b[3J");  // Clear scrollback buffer
            Console.WriteLine("Welcome to the JOURNAL PROGRAM");
            Console.WriteLine("Please select from the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            if (!int.TryParse(Console.ReadLine(), out int menuOption) || menuOption < 1 || menuOption > 5)
            {
                Console.WriteLine("ERROR: Enter a number from 1-5");
                Console.Write("Press <ENTER> to continue . . .");
                Console.ReadLine();
                continue;
            }

            return menuOption;
        }
    }
}