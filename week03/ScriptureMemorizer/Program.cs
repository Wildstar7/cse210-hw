using System;

class Program
{
    static void Main(string[] args)
    {
        // Create reference, text, and scripture objects
        Reference reference = new Reference("2 Nephi", 2, 1, 2);
        string text = "And now, Jacob, I speak unto you: Thou art my firstborn in the days of my tribulation in the wilderness. And behold, in thy childhood thou hast suffered afflictions and much sorrow, because of the rudeness of thy brethren. Nevertheless, Jacob, my firstborn in the wilderness, thou knowest the greatness of God; and he shall consecrate thine afflictions for thy gain.";
        Scripture scripture = new Scripture(reference, text);

        // Loop until scripture completely hidden or user quits
        while (!scripture.IsCompletelyHidden())
        {
            DisplayScripture(scripture);

            Console.WriteLine("\nPress <ENTER> to hide more words or type 'quit' to exit");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}