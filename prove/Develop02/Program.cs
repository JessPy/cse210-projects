using System;

class Program
{
    static void Main(string[] args)
    {
        int userCommand;
        Journal journalUser = new Journal();

        do
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices: ");
            
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            userCommand = int.Parse(Console.ReadLine());

            // Cammands
            if (userCommand == 1)
            {
                journalUser.AddEntry();
                continue;
            } 
            else if (userCommand == 2)
            {
                journalUser.DisplayAll();
                continue;
            }
            else if (userCommand == 3)
            {
                journalUser.LoadFromFile();
                continue;
            }
            else if (userCommand == 4)
            {
                journalUser.SaveToFile();
                continue;
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }while (userCommand != 5);
        
    }
}