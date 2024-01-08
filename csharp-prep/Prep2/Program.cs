using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        int signCalculus = grade % 10;
        string sign = "";

        if (!(grade >= 90 || grade < 60) && signCalculus >= 7)
        {
            sign = "+";
        }
        else if (!(grade < 60) && signCalculus <= 3)
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade was: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass the course!");
        }
        
    }   
}