using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        DisplayResult(name, favNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        
        return favoriteNumber;
    }

    static int SquareNumber(int number)
    {
        int squared = number * number;
        
        return squared;
    }

    static void DisplayResult(string userName, int number)
    {
        int numSquared = SquareNumber(number);
        Console.WriteLine($"{userName}, the square of your number is {numSquared}");
    }
}