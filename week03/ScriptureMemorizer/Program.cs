using System;
using System.Collections.Generic;
using System.IO;

// I've added a CSV file that contains a list of the Doctrinal Mastery
// verses from the Book of Mormon. The program selects one of those
// scriptures at random for the user to memorize.

class Program
{
    static void Main(string[] args)
    {
        // Read CSV file and create list of scriptures
        string[] lines = File.ReadAllLines("scriptureList.csv");
        List<Scripture> doctrinalMasteryList = new List<Scripture>();

        for (int i = 1; i < lines.Length; i++)  // skip header row
        {
            string[] scriptureParts = lines[i].Split("||");

            string book = scriptureParts[0];
            int chapter = int.Parse(scriptureParts[1]);
            int verse = int.Parse(scriptureParts[2]);
            if (int.TryParse(scriptureParts[3], out int endVerse))
            {
                // catch valid number
            }
            else
            {
                endVerse = 0;  // if it's empty string, etc.
            }
            string passage = scriptureParts[4];

            Reference reference = new Reference(book, chapter, verse, endVerse);

            Scripture scripture = new Scripture(reference, passage);
            doctrinalMasteryList.Add(scripture);
        }

        // Choose a random scripture from the list
        Random random = new Random();
        int index = random.Next(doctrinalMasteryList.Count);
        Scripture selection = doctrinalMasteryList[index];

        // Loop until scripture completely hidden or user quits
        while (!selection.IsCompletelyHidden())
        {
            DisplayScripture(selection);

            Console.WriteLine("\nPress <ENTER> to hide more words or type 'quit' to exit");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            selection.HideRandomWords(3);
        }
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}