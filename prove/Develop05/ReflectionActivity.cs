using System;
public class ReflectionActivity : Activity
{
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless"

    };
    
    public ReflectionActivity(): base("ReflectionActivity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
            
    }

    private string GetRandomQuestion()
    {
        if (_questions.Count == 0)
        {
            _questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
        }

        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        string question = _questions[index];
        _questions.RemoveAt(index);
        return question;
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
    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt");
        Console.WriteLine();
        Console.WriteLine($"---- {GetRandomPrompt()} ----");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.WriteLine();
        Console.ReadLine();
    }
    private void DisplayQuestions()
    {
        Console.WriteLine($"> {GetRandomQuestion()}");
        ShowCountDown(15); 
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();

        DisplayPrompt();


        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();
        
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {   
            
            DisplayQuestions();
            currentTime = DateTime.Now;
        }
        DisplayEndingMessage();
        Thread.Sleep(3000);

    }
}