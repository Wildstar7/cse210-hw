public class Word
{
    // Variables
    private string _text;
    private bool _isHidden = false;

    // Constructors
    public Word(string text)
    {
        _text = text;
        _isHidden = false;  // by default, 'Word' is NOT hidden
    }

    // Methods
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        if (IsHidden() == true)
        {
            int wordLength = _text.Length;
            string blank = new string('_', wordLength);
            return blank;
        }
        else
        {
            return _text;
        }
    }
}