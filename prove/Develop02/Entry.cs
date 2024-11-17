using System;

public class Entry
{
    public DateTime _date;
    public TimeSpan _duration;
    public string _promptText = "";
    public string _entryText = "";

    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"{_date} Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Duration: {_duration.Minutes} min and {_duration.Seconds} secs");

    }
}
