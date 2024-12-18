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
        int activitySeconds = _duration;
        while (activitySeconds > 0)
        {   
            
            Console.WriteLine($"Breathe in... ");
            ShowCountDown(4); 

            Console.WriteLine($"Now breathe out... ");
            ShowCountDown(4);
            Console.WriteLine();

            activitySeconds -= 8; 
        }

        DisplayEndingMessage();
    }
}