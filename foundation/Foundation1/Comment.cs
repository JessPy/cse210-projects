using System;
using System.Diagnostics.Tracing;

class Comment
{
    private string _author;
    private string _text;

    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"@{_author}");
        Console.WriteLine(_text);
    
    }
    // Setters
    public void SetName(string author)
    {
        _author = author;
    }
    public void SetText(string text)
    {
        _text = text;
    }
}