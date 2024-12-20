using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string choice;
        do
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save Goals");
            Console.WriteLine("    4. Load Goals");
            Console.WriteLine("    5. Record Event");
            Console.WriteLine("    6. Quit");
            Console.Write("Select a choice from the menu: ");
            Console.WriteLine();

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Exiting. Thank you for using Eternal Quest!");
                    break;
                default:
                    Console.WriteLine("Chose a valid choise");
                    break;
            }
        } while (choice != "6");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The Goals are:\n");
        if (_goals.Count == 0)
        {
            Console.WriteLine("There is no goal created. Please enter a Goal!");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            string completionStatus = goal.IsComplete() ? "[X]" : "[ ]";

            Console.WriteLine($"{i + 1}. {completionStatus} {goal.Name} ({goal.Description})");
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    
        public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();


        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":

                _goals.Add(new SimpleGoal(name, description, points));
                break;

            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;


            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());


                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    public void RecordEvent()
{
    ListGoalDetails();

    Console.Write("Which goal did you acomplish? ");
    int goalNumber = int.Parse(Console.ReadLine()) - 1;

    if (goalNumber >= 0 && goalNumber < _goals.Count)
    {
        Goal numberGoal = _goals[goalNumber];

        if (numberGoal is ChecklistGoal checklistGoal)
        {
            checklistGoal.AmountCompleted++;
            Console.WriteLine("Progress updated.");
        }
        else if (numberGoal is SimpleGoal simpleGoal)
        {
            simpleGoal.MarkComplete();
            Console.WriteLine("Complete.");
        }
        else
        {
            Console.WriteLine("Progress is not allowed for this goal type ");
        }
    }
    else
    {
        Console.WriteLine("Invalid goal number.");
    }
}

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("Enter the filename to load goals: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        _goals.Clear();
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string details = parts[1];

            if (type == "SimpleGoal")
            {
                string[] goalParts = details.Split(',');
                _goals.Add(new SimpleGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2])));
            }
            else if (type == "EternalGoal")
            {
                string[] goalParts = details.Split(',');
                _goals.Add(new EternalGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2])));
            }
            else if (type == "ChecklistGoal")
            {
                string[] goalParts = details.Split(',');
                _goals.Add(new ChecklistGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2]), int.Parse(goalParts[3]), int.Parse(goalParts[4])));
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }
}