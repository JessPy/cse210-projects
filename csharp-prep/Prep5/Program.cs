using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        float userNumber = PromptUserNumber();

        float squareNumber = SquareNumber(userNumber);

        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();

        return userName;
    }
    
    static float PromptUserNumber()
    {
        Console.Write("What is the number? ");
        float userNumber = float.Parse(Console.ReadLine());

        return userNumber;
    }
    
    static float SquareNumber(float number)
    {
        float squareNumber = number * number;
        return squareNumber;
    }

    static void DisplayResult(string userName, float squareNumber)
    {
    Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }
}