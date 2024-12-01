using System;
using System.Net;
using System.Runtime.InteropServices;

class Video
{
    private string _title;
    private string _author;
    private List<Comment> _commentsSection;

    public Video(string title, string author)
    {
        _title = title;
        _author = author;
        _commentsSection = new List<Comment>();
    }
    public void SetComment(Comment textComment)
    {
        _commentsSection.Add(textComment);
    }
    private int CountComments()
    {
        int commentsNumber = _commentsSection.Count;
        return commentsNumber;
    }
    public void DisplayCommentsSection()
    {   
        Console.WriteLine($"{CountComments()} comments");
        foreach(Comment comment in _commentsSection)
        {
            comment.DisplayComment();
        }
    }
    public void DisplayVideo(){
        Console.WriteLine($"Title: {_title} - Author: {_author}");
        DisplayCommentsSection();
    }
}
