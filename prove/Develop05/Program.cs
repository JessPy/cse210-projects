using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Menu Options: \n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4.Quit\n Select a choice from the menu: ");
        string userChoince = Console.ReadLine();

        if (userChoince == "1")
        {
            BreathingActivity bActivity = new BreathingActivity();
            bActivity.Run();
        }
    
    }
}