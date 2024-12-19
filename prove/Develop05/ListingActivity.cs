using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _anwsers = new List<string>();

    private int _count = 0;
    public ListingActivity(): base("ListingActivity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }
    private string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            _prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
        }

        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        string prompt = _prompts[index];
        _prompts.RemoveAt(index);
        return prompt;

    }
    private void GetListFromUser()
    {
        Console.Write("> ");
        string anwser = Console.ReadLine();
        _anwsers.Add(anwser);
    }
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        
        Console.WriteLine("List as many responses you can to the following prompt");
        Console.WriteLine($"---- {GetRandomPrompt()} ----");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            GetListFromUser();  
            currentTime = DateTime.Now;
        }
        _count = _anwsers.Count();
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
        Thread.Sleep(3000);
        
    }
}