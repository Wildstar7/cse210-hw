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
                    Console.Clear();
                    Console.Write("\x1b[3J");
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
                    Console.Clear();
                    Console.Write("\x1b[3J");
                    currentJournal.DisplayAll();
                    Console.Write("Press <ENTER> to return to main menu . . .");
                    Console.ReadLine();
                    break;
                // Load
                case 3:
                    Console.Clear();
                    Console.Write("\x1b[3J");
                    Console.WriteLine("Load from file");
                    Console.Write("Press <ENTER> to return to main menu . . .");
                    Console.ReadLine();
                    break;
                //Save
                case 4:
                    Console.Clear();
                    Console.Write("\x1b[3J");
                    Console.WriteLine("Save to file");
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
            Console.Clear();
            Console.Write("\x1b[3J");
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