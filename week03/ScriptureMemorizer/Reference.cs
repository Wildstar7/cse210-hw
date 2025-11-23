public class Reference
{
    // Variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;  // default to zero because only one verse
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;

    }

    // Methods
    public string GetDisplayText()
    {
        string fullReference = "";
        if (_endVerse > 0)
        {
            fullReference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            fullReference = $"{_book} {_chapter}:{_verse}";
        }

        return fullReference;
    }
}