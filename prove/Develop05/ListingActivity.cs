using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private int _count = 0;
    private List<string> _anwsers = new List<string>();
    public ListingActivity(): base("ListingActivity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        
    }
    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, _prompts.Count());
        return _prompts[randomNumber];
    }
    private void GetListFromUser()
    {
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
        while (futureTime < startTime)
        {
            GetListFromUser();  
            
        }
        _count = _anwsers.Count();
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
        
    }
}