using System;

class Program
{
    static void Main(string[] args)
    {
        string playAganin = "";
        do
        {
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1,101);
            
            int guess = -1;
            int tries = 1;

            while (guess != magic)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess == magic)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You tried {tries} times!");
                    Console.Write("Do you want to play again? (yes/no)");
                    playAganin = Console.ReadLine();

                    if (playAganin == "yes")
                    {
                        magic = randomGenerator.Next(1,101);
                        tries = 1;
                    }
                }     
                else if (guess > magic)  
                {
                    Console.WriteLine("Lower");
                    tries += 1;
                }
                else
                {
                    Console.WriteLine("Higher");
                    tries += 1;
                }
            }
        }
        while(playAganin == "yes");
    }
}