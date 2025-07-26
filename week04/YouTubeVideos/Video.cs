using System;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

// Added a feature where seconds is converted to minutes
    public string GetLengthFormatted()
    {
        int minutes = _length / 60;
        int seconds = _length % 60;
        return $"{minutes}m {seconds}s";
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {GetLengthFormatted()}");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");

        Console.WriteLine("Comments:");
        foreach (var comment in _comments)
        {
            comment.DisplayComment();
        }

        Console.WriteLine(new string('-', 30));
    }
}