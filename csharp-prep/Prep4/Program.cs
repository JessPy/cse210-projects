using System;

class Program
{
    static void Main(string[] args)
    {
        int userNumber;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        do
        {
            Console.Write("Enter number: ");
            string userNumberStr = Console.ReadLine();

            userNumber = int.Parse(userNumberStr);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
    
        } while (userNumber != 0);

        // Sum
        int numbersSum = 0;

        foreach (int number in numbers)
        {
            numbersSum += number;
        }
            
        Console.WriteLine($"The sum is: {numbersSum}");

        // Average
        float average = numbersSum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Largest number
        
        int largestNumber = 0;

        for (int number = 0; number < numbers.Count; number++)
        {
            if (numbers[number] > largestNumber)
            {
                largestNumber = numbers[number];
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}