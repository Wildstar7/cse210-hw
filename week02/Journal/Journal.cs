public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        if (_entries.Count == 0)  // In case there aren't entries
        {
            Console.WriteLine("There are no entries yet.");
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile(string File)
    {
        using (StreamWriter outFile = new StreamWriter(File))
        {
            foreach (Entry entry in _entries)
            {
                outFile.WriteLine($"{entry._date}||||{entry._promptText}||||{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string File)
    {
        _entries.Clear(); // Clear current entries
        string[] lines = System.IO.File.ReadAllLines(File);

        foreach (string line in lines)
        {
            string[] entryParts = line.Split("||||");

            Entry loadedEntry = new Entry();
            loadedEntry._date = entryParts[0];
            loadedEntry._promptText = entryParts[1];
            loadedEntry._entryText = entryParts[2];

            AddEntry(loadedEntry);
        }
    }

}