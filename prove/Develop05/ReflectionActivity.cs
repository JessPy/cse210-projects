using System;
public class ReflectionActivity : Activity
{
    private List<string> _questions = new List<string>();
    private List<string> _prompts = new List<string>();
    
    public ReflectionActivity(): base("ReflectionActivity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
            _prompts.Add("Think of a time when you stood up for someone else.");
            _prompts.Add("Think of a time when you did something really difficult.");
            _prompts.Add("Think of a time when you helped someone in need.");
            _prompts.Add("Think of a time when you did something truly selfless");

            _questions.Add("Why was this experience meaningful to you?");
            _questions.Add("Have you ever done anything like this before?");
            _questions.Add("How did you get started?");
            _questions.Add("How did you feel when it was complete?");
            _questions.Add("What made this time different than other times when you were not as successful?");
            _questions.Add("What is your favorite thing about this experience?");
            _questions.Add(" What could you learn from this experience that applies to other situations?");
            _questions.Add("What did you learn about yourself through this experience?");
            _questions.Add("How can you keep this experience in mind in the future?");

    }

    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, _prompts.Count());
        return _prompts[randomNumber];
    }
    private string GetRandomQuestion()
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, _questions.Count());
        return _questions[randomNumber];
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
        while (futureTime < startTime)
        {   
            
            DisplayQuestions();

        }
        DisplayEndingMessage();

    }
}