using System;

class Program
{
    static void Main(string[] args)
    {
        Running runOne = new Running("27 Nov 2022", 25, 3.2);

        List<Activity> exerciseActivities = new List<Activity>
        {
            new Running("27 Nov 2022", 25, 3.2),
            new Cycling("30 Nov 2025", 42, 24.2),
            new Swimming("07 Dec 2025", 29, 49)
        };

        foreach (Activity entry in exerciseActivities)
        {
            Console.WriteLine(entry.GetSummary());
        }
    }
}