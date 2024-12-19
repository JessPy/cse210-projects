using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Menu Options: \n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4.Quit\n Select a choice from the menu: ");
        string userChoice = Console.ReadLine();
        //  Exceeding Requirements
        // Make sure no random prompts/questions are selected until they have all been used at least once in that session.

        while (userChoice != "4")
        {
            if (userChoice == "1")
            {
                BreathingActivity bActivity = new BreathingActivity();
                bActivity.Run();
            }
            else if (userChoice == "2")
            {
                ReflectionActivity rActivity = new ReflectionActivity();
                rActivity.Run();
            }
            else if (userChoice == "3")
            {
                ListingActivity lActivity = new ListingActivity();
                lActivity.Run();
            }
            else
            {
                Console.WriteLine("Chose a valid number! ");
            }
            Console.Clear();
            Console.Write("Menu Options: \n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4.Quit\n Select a choice from the menu: ");
            userChoice = Console.ReadLine();
        }
    }
}