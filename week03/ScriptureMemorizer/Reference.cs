public class Reference
{
    // Variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0;  // default to zero if unused

    // Constructors
    public Reference(string book, int chapter, int verse)
    {

    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {

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