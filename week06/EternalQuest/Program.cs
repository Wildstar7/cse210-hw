using System;

class Program
{
    static void Main(string[] args)
    {
        int menuLoop = 1;
        while (menuLoop != 0)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest\n");
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
                                Console.Clear();
                                Console.WriteLine("Implement simple goal here.");
                                Console.WriteLine("Going back to Main Menu...");
                                Thread.Sleep(2000);
                                submenuLoop = 0;
                                break;
                            case "2":
                                Console.Clear();
                                Console.WriteLine("Implement eternal goal here.");
                                Console.WriteLine("Going back to Main Menu...");
                                Thread.Sleep(2000);
                                submenuLoop = 0;
                                break;
                            case "3":
                                Console.Clear();
                                Console.WriteLine("Implement checklist goal here.");
                                Console.WriteLine("Going back to Main Menu...");
                                Thread.Sleep(2000);
                                submenuLoop = 0;
                                break;
                            case "4":
                                submenuLoop = 0;
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid option, please try again.");
                                Thread.Sleep(1000);  // Pause for a second so the user can read the message
                                break;
                        }

                    }
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Implement list goals");
                    Console.WriteLine("Going back to Main Menu...");
                    Thread.Sleep(2000);
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Implement save goals");
                    Console.WriteLine("Going back to Main Menu...");
                    Thread.Sleep(2000);
                    break;
                
                case "4":
                    Console.Clear();
                    Console.WriteLine("Implement load goals");
                    Console.WriteLine("Going back to Main Menu...");
                    Thread.Sleep(2000);
                    break;

                case "5":
                    Console.Clear();
                    Console.WriteLine("Implement record event");
                    Console.WriteLine("Going back to Main Menu...");
                    Thread.Sleep(2000);
                    break;

                case "6":
                    Console.WriteLine("\nQuitting...");
                    Thread.Sleep(1000);
                    menuLoop = 0;
                    break;

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    Thread.Sleep(1000);  // Pause for a second so the user can read the message
                    break;
            }
        }
    }
}