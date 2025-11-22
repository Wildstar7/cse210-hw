public class Word
{
    // Variables
    private string _text;
    private bool _isHidden = false;  // by default, 'Word' is NOT hidden

    // Constructors
    public Word(string text)
    {

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