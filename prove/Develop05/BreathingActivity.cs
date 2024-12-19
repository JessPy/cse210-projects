using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(): base("BreathingActivity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        // Clear display
        Console.Clear();
        
        // Prepare to start
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.Clear();

        // Activity

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {   
            Console.WriteLine($"Breathe in... ");
            ShowCountDown(4); 

            Console.WriteLine($"Now breathe out... ");
            ShowCountDown(4);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }

        DisplayEndingMessage();
        Thread.Sleep(3000);
    }

}