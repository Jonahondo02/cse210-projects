// Video.cs
using System;
using System.Collections.Generic;

public class Video
{
    private List<Comment> _comments;

    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
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

    public List<Comment> GetComments()
    {
        return _comments;
    }
}