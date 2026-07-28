using System;

public class Comment
{
    // private variables:
    private string _commenterName;
    private string _commentText;
    
// first constructor: it deletes  the comment, including the name and text, as soon as it is created.


    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }
    // to print them outside of the class will use Getter
    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetCommentText()
    {
        return _commentText;
    }
}