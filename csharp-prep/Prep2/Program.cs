using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentageFromUserStr = Console.ReadLine();

        int percentageFromUserInt = int.Parse(percentageFromUserStr);

       

        // Grade letter calculator
        string letterGrade;
        if (percentageFromUserInt >= 90)
        {
            letterGrade ="A";
        } 
        else if (percentageFromUserInt >= 80) 
        {
            letterGrade ="B";
        }
        else if (percentageFromUserInt >= 70) 
        {
            letterGrade ="C";
        }
        else if (percentageFromUserInt >= 60) 
        {
            letterGrade ="D";
        }
        else if (percentageFromUserInt < 60) 
        {
            letterGrade ="F";
        }
        else 
        {
            letterGrade = "None";
        }

        // Signal grade letter calculator
        string letterSign;
        int lastDigit = percentageFromUserInt % 10;
        if (lastDigit >= 7 && letterGrade != "A" && letterGrade != "F") 
        {
            letterSign = "+";
        }
        else if (lastDigit < 3 && percentageFromUserInt != 100 && letterGrade != "F" )
        {
            letterSign = "-";
        }
        else{
           letterSign = ""; 
        }

        Console.WriteLine($"Your grade is: {letterGrade}{letterSign}");

        if (percentageFromUserInt >= 70) 
        {
            Console.WriteLine("Congratulations! You passed.");
        } 
        else
        {
            Console.WriteLine("Sorry, good luck in next time!");
        }

    }
}