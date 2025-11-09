using System;

class Program
{
    static void Main(string[] args)
    {
        // Get grade percentage, convert to float
        Console.Write("What is your grade percentage? ");
        string stringGradePercentage = Console.ReadLine();
        float gradePercentage = float.Parse(stringGradePercentage);

        // Determine letter grade based on grade percentage
        string letterGrade = "";
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // Determine '+' or '-' to append to letter grade
        float lastDigit = gradePercentage % 10;
        string gradeSign = "";

        if (gradePercentage >= 100)
        {
            gradeSign = "+";
        }
        else if (lastDigit >= 7)
        {
            gradeSign = "+";
        }
        else if (lastDigit < 3)
        {
            gradeSign = "-";
        }
        else
        {
            gradeSign = "";
        }

        string fullLetterGrade = $"{letterGrade}{gradeSign}";

        // Remove improper '+' or '-' from edge cases like A+, F+, F-
        if (fullLetterGrade == "A+" && gradePercentage <= 100)
        {
            fullLetterGrade = "A";
        }
        else if (fullLetterGrade == "F+" || fullLetterGrade == "F-")
        {
            fullLetterGrade = "F";
        }
        else { }

        // Determine proper grammer ('a' vs 'an') to display letter grade
        if (letterGrade == "A" || letterGrade == "F")
        {
            Console.WriteLine($"You got an {fullLetterGrade}");
        }
        else
        {
            Console.WriteLine($"You got a {fullLetterGrade}");
        }

        // Determine if class was passed
        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Sorry. . . maybe next term.");
        }
    }
}