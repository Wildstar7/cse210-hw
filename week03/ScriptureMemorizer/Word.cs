public class Word
{
    // Variables
    string _text;
    bool _isHidden;

    // Constructors
    public Word(string text)
    { 

    }

    // Methods
    public void Hide()
    {

    }

    public void Show()
    {
        Console.Write(_text);
    }

    public bool IsHidden()
    {
        return true;
    }

    public string GetDisplayText()
    {
        return "";
    }
}