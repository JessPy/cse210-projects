using System;

public class PromptGenerator
{
    public string _prompt;
    private string[] _prompts = new string[]
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        _prompt =  _prompts[index];
        Console.WriteLine(_prompt);
    }
}