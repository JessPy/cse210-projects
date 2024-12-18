using System.ComponentModel;

public class Activity
{
    protected string _name {get;set;}
    protected string _description {get;set;}
    protected int _duration {get;set;}

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
 
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            foreach(string a in animationStrings)
            {
                Console.Write(a);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        }
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Wellcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!\n");
        Console.WriteLine($"You have completed another {_duration} seconds of the Breathing Activity");
    }
}