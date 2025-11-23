public class Scripture
{
    // Variables
    private Reference _reference;
    private List<Word> _words;

    // Constructors
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');

        foreach (string w in splitWords)
        {
            _words.Add(new Word(w));
        }
    }

    // Methods
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        int hiddenCount = 0;
        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string verseText = "";
        foreach (Word w in _words)
        {
            verseText += w.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} {verseText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}