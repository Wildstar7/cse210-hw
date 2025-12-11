using System;

class Program
{
    static void Main(string[] args)
    {
        int menuLoop = 1;
        while (menuLoop != 0)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n");
            Console.WriteLine("  1) Create New Goal");
            Console.WriteLine("  2) List Goals");
            Console.WriteLine("  3) Save Goals");
            Console.WriteLine("  4) Load Goals");
            Console.WriteLine("  5) Record Event");
            Console.WriteLine("  6) Quit");

            Console.Write("\nSelect a choice from the menu: ");
            string userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    int submenuLoop = 1;
                    while (submenuLoop != 0)
                    {
                    Console.Clear();
                    Console.WriteLine("Types of goals:\n");
                    Console.WriteLine("  1) Simple Goal");
                    Console.WriteLine("  2) Eternal Goal");
                    Console.WriteLine("  3) Checklist Goal");
                    Console.WriteLine("  4) Back to Main Menu");

                    Console.Write("\nSelect a type of goal: ");
                    string userSubselection = Console.ReadLine();

                    switch (userSubselection)
                        {
                            case "1":
                                Console.WriteLine("Create simple goal here.");
                                break;
                            case "2":
                                Console.WriteLine("Create eternal goal here.");
                                break;
                            case "3":
                                Console.WriteLine("Create checklist goal here.");
                                break;
                            case "4":
                                submenuLoop = 0;
                                break;
                            default:
                                Console.WriteLine("Invalid option, please try again.");
                                Thread.Sleep(1000);
                                break;
                        }

                    }
                    break;

                case "2":
                    Console.WriteLine("List Goals");
                    break;

                case "3":
                    Console.WriteLine("Save Goals");
                    break;
                
                case "4":
                    Console.WriteLine("Load Goals");
                    break;

                case "5":
                    Console.WriteLine("Record Event");
                    break;

                case "6":
                    Console.WriteLine("Quitting");
                    menuLoop = 0;
                    break;

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}