using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment normalHomeWork = new Assignment("Jessica Guimarães", "Inheritance");
        Console.WriteLine(normalHomeWork.GetSummary());
        Console.WriteLine();

        MathAssignment mathHomeWork = new MathAssignment("John Anders", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathHomeWork.GetSummary());
        Console.WriteLine(mathHomeWork.GetHomeworkList());
        Console.WriteLine();

        WrittingAssignment writtingHomeWork = new WrittingAssignment("Maty Waters", "Dystopian novel", "Perfection");
        Console.WriteLine(writtingHomeWork.GetSummary());
        Console.WriteLine(writtingHomeWork.GetWritingInformation());
        Console.WriteLine();

    }
}