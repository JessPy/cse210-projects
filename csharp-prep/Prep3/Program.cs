using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //Random Generator
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        // Define variables
        int guessNumber;
        int guessCounter = 0;
        string response;
        
        // Ask if the user wanna continue
        do
        {
            // Play the game
            do
            {
                Console.Write("What is the guess? ");
                string inputGuessNumber = Console.ReadLine();
                guessNumber = int.Parse(inputGuessNumber);
                guessCounter += 1;
                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                } 
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.Write("You guessed it! ");
                }
            } while (guessNumber != magicNumber);
            Console.WriteLine($"You needed {guessCounter} tentatives");

            Console.Write("Do you want to play again? ");
            response  = Console.ReadLine();
            
        } while (response == "yes");
    }
}