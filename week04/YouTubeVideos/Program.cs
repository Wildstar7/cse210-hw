using System;

class Program
{
    static void Main(string[] args)
    {
        // Video 1 comments
        List<Comment> comments1 = new List<Comment>
        {
            new Comment("Alice", "Great video!"),
            new Comment("Bob", "Very informative."),
            new Comment("Charlie", "Loved the editing style.")
        };

        // Video 2 comments
        List<Comment> comments2 = new List<Comment>
        {
            new Comment("Diana", "This helped me a lot."),
            new Comment("Ethan", "Can you make a follow-up?"),
            new Comment("Fiona", "Awesome content!")
        };

        // Video 3 comments
        List<Comment> comments3 = new List<Comment>
        {
            new Comment("George", "Not what I expected."),
            new Comment("Hannah", "Still pretty good."),
            new Comment("Ian", "Subscribed!")
        };

        // Create videos
        Video video1 = new Video("Intro to C#", "TechGuru", 600, comments1);
        Video video2 = new Video("Cooking Pasta", "ChefMike", 480, comments2);
        Video video3 = new Video("Travel Vlog: Japan", "Wanderlust", 900, comments3);

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video info
        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.GetTitle()}");
            Console.WriteLine($"Author: {v.GetAuthor()}");
            Console.WriteLine($"Length: {v.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {v.NumComments()}");

            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine($"   {c.GetUsername()}: {c.GetCommentText()}");
            }

            Console.WriteLine(); // Blank line between videos
        }
    }
}