using System;

class Program
{
    static void Main(string[] args)
    {
        int menuLoop = 0;
        while (menuLoop == 0)
        {
            Console.WriteLine("Please select an activity:/n");
            Console.WriteLine("1) Breathing Activity");
            Console.WriteLine("2) Reflection Activity");
            Console.WriteLine("3) Listing Activity");
            Console.WriteLine("4) Quit");

            Console.Write("/nWhat is your selection? ");
            string userSelection = Console.ReadLine();
            int userSelectionInt = int.Parse(userSelection);

            switch (userSelectionInt)
            {
                case 1:
                    Console.WriteLine("Breathing Activity");
                    break;

                case 2:
                    Console.WriteLine("Reflection Activity");
                    break;

                case 3:
                    Console.WriteLine("Listing Activity");
                    break;

                case 4:
                    Console.WriteLine("Quitting Time!");
                    break;

                default:
                    Console.WriteLine("Invalid Option!!!!");
                    break;
            }
        }
    }
}