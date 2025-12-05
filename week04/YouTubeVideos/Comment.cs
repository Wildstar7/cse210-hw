public class Comment
{
    // Variables
    private string _username;
    private string _comment;

    // Constructors
    public Comment(string username, string comment)
    {
        _username = username;
        _comment = comment;
    }
    
    // Methods
    public string GetUsername()
    {
        return _username;
    }

    public string GetCommentText()
    {
        return _comment;
    }
}