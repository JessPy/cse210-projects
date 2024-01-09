using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> num = new List<int>();
        int numUser = -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        do
        {
            Console.Write("Enter number: ");
            numUser = int.Parse(Console.ReadLine());
    
            if (!(numUser == 0))
            {
                num.Add(numUser);
            }
        }while(numUser != 0);
        
        float sum = 0;
        foreach (int element in num)
        {
            sum += element;
        }
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The avarage is: {sum/num.Count}");
    }
}
