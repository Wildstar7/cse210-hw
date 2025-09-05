using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "no";
        while (playAgain == "yes")
        {
            if (playAgain == "yes")
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
                    Console.WriteLine("Do you want to play again? ");
                    playAgain = Console.ReadLine();
                }
                else { }
            }
        }
    }
}