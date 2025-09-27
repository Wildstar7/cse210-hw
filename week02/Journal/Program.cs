using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        int userChoice;

        Console.Clear();
        Console.WriteLine("Welcome to the Journal Program!");

        do
        {
            userChoice = DisplayMenu();
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("Display prompt");
                    break;
                case 2:
                    Console.WriteLine("Display past entries");
                    break;
                case 3:
                    Console.WriteLine("Load from file");
                    break;
                case 4:
                    Console.WriteLine("Save to file");
                    break;
                default:
                    break;
            }
        } while (userChoice != 5);

        Console.WriteLine("Goodbye!");

        return;
    }

    static int DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("Please select from the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            if (!int.TryParse(Console.ReadLine(), out int menuOption))
            {
                Console.WriteLine("Enter a number 1-5: ");
                continue;
            }
            
            return menuOption;
        }
    }
}