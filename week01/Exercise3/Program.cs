using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        while (playAgain == "yes" || playAgain == "y")
        {
            if (playAgain == "yes" || playAgain == "y")
            {
                playAgain = "no";
            }
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int userGuess = 0;
            int numGuesses = 0;
            while (userGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string stringUserGuess = Console.ReadLine();
                userGuess = int.Parse(stringUserGuess);
                numGuesses++;

                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You got it in {numGuesses} guesses.");
                    Console.WriteLine("Do you want to play again (yes/no)? ");
                    playAgain = Console.ReadLine();
                    playAgain = playAgain.ToLower();

                    if (playAgain != "yes" && playAgain != "y")
                    {
                        Console.WriteLine("Thank you for playing! Goodbye!");
                    }
                }
                else { Console.WriteLine("Error!"); }
            }
        }
    }
}