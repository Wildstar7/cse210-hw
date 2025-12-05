public class Video
{
    // Variables
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    // Constructors
    public Video(string title, string author, int duration, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = duration;
        _comments = comments;
    }
    
    // Methods
    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public int NumComments()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}