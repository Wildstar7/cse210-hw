using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string stringGradePercentage = Console.ReadLine();
        int gradePercentage = int.Parse(stringGradePercentage);

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


        int lastDigit = gradePercentage % 10;
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

        if (fullLetterGrade == "A+")
        {
            fullLetterGrade = "A";
        }
        else if (fullLetterGrade == "F+" || fullLetterGrade == "F-")
        {
            fullLetterGrade = "F";
        }
        else {}

        Console.WriteLine($"You got a {fullLetterGrade}");
    }
}