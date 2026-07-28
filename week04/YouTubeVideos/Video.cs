using System;
using System.Collections.Generic; // to work the list

// public class
public class Video
{
    // privte variables : title, author and lengthINScond:
    private string _title;
    private string _author;
    private int _lengthInScond;

    // private list to restore inside it objects fron comment class

    private List<Comment> _comments = new List<Comment>();

    // Constructor: to prepare the basic video data
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInScond = lengthInSeconds;
    }
    // public funcation to add a new comment opject inside the private video list
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    // A public function that returns the exact number of comments on this video (required in the specification)

    public int GetCommentCount()
    {
        return _comments.Count;
    }
    // The service function prints the entire video data, and below it, it prints a comment.
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInScond} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
    
    // it goes through the list of comments and print the name of the person who made the comment and the text of what they said.

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.GetCommenterName()}: \"{comment.GetCommentText()}\"");
        }
                Console.WriteLine("--------------------------------------------------");
    }
}









