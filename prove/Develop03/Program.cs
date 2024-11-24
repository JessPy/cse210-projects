using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", "3", "5");
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding");
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide words, type 'back' to reveal the last hidden word, or type 'quit' to exit.");

            string input = Console.ReadLine()?.Trim().ToLower();
            if (input == "quit")
                break;

            if (input == "back")
            {
                scripture.Back();
            }
            else
            {
                scripture.HideRandomWords();
                if (scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine("\nThe scripture is completely hidden. Press ENTER to exit.");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
