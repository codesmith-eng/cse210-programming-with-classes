using System;
using System.Collections;
using System.Collections.Generic;
using System.IO; // Added for File operations
using System.Linq;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;


    public GoalManager()
    {
    }

    public void Start()
    {
        Console.WriteLine("Menu Options");
        Console.WriteLine("     1. Create New Goal");
        Console.WriteLine("     2. List Goals");
        Console.WriteLine("     3. Save Goals");
        Console.WriteLine("     4. Load Goals");
        Console.WriteLine("     5. Record Event");
        Console.WriteLine("     6. Quit");
    }

    public int GetScore()
    {
        return _score;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} Points.\n");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal\n");
    }

    public void ListGoalDetails()
    {
        //this index do the work of numbering 
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}.    {goal.GetDetailsString()}");
            index++;
        }
    }

    public void CreateGoal()
    {
        Console.Write("Which type of goal would you like to create? ");
        string createGoal = Console.ReadLine();
        int theGoal = int.Parse(createGoal);

        if (theGoal == 1)
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int thePoint = int.Parse(Console.ReadLine());


            //Create a fresh new instance here instead of sharing a global one
            SimpleGoal newSimpleGoal = new SimpleGoal(goalName, description, thePoint);
            _goals.Add(newSimpleGoal);
        }
        else if (theGoal == 2)
        {
            Console.Write("What is the name of your goal? ");
            string eternalName = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string eternalDesc = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int theEtPoint = int.Parse(Console.ReadLine());

            // Create a fresh new instance here
            EternalGoal newEternalGoal = new EternalGoal(eternalName, eternalDesc, theEtPoint);
            _goals.Add(newEternalGoal);
        }
        else if (theGoal == 3)
        {
            Console.Write("What is the name of your goal? ");
            string checklistName = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string checklistDesc = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int theCheckPoint = int.Parse(Console.ReadLine());

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int targetNow = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusNow = int.Parse(Console.ReadLine());

            // Pass arguments straight to constructor
            ChecklistGoal newChecklistGoal = new ChecklistGoal(targetNow, bonusNow, checklistName, checklistDesc, theCheckPoint);
            _goals.Add(newChecklistGoal);
        }
    }



    // Records that the user accomplished a goal and handles updating the score
    public void RecordEvent()
    {
        // If there are no goals in the list, stop immediately
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals to record events for.");
            return;
        }

        Console.WriteLine("The goals are:");
        // Display a numbered list of all your goal names
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine()) - 1; // Convert 1-based choice to 0-based index

        // Make sure the user entered a valid number inside our list bounds
        if (choice >= 0 && choice < _goals.Count)
        {
            Goal selectedGoal = _goals[choice];

            //Check if the goal was already completed BEFORE doing anything
            if (selectedGoal.IsComplete())
            {
                Console.WriteLine("This goal is already finished. No extra points awarded.");
                return;
            }

            //Run the void method inside the goal class to alter its internal flags
            selectedGoal.RecordEvent();

            // Start with the base points of the goal
            int pointsToAward = selectedGoal.GetPoint();

            // Check if it is a ChecklistGoal. 
            // We use standard string comparison on the object type to keep it easy.
            string goalClassName = selectedGoal.GetType().ToString();
            if (goalClassName == "ChecklistGoal")
            {
                // Convert our base goal object into a ChecklistGoal object so we can use Checklist features
                ChecklistGoal checklistGoal = (ChecklistGoal)selectedGoal;

                // If the goal became complete AFTER running the event, add the bonus point payload!
                if (checklistGoal.IsComplete())
                {
                    pointsToAward = pointsToAward + checklistGoal.GetBonus();
                    Console.WriteLine($"Bonus Points Earned: +{checklistGoal.GetBonus()}");
                }
            }

            // Add the calculated points directly into the player's total score
            _score = _score + pointsToAward;
            Console.WriteLine($"You earned {pointsToAward} points! Current Score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }



    //this method save goals to file
    public void SaveGoals()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            //saving the score first
            outputFile.WriteLine(GetScore());

            foreach (Goal theGoals in _goals)
            {
                outputFile.WriteLine(theGoals.GetStringRepresentation());
            }
        }
        Console.WriteLine("Your Goals are saved successfully!");
    }




    //this method load saved files 
    public void LoadGoals()
    {
        Console.Write("Enter the name of the file: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);
        _goals.Clear();

        _score = int.Parse(lines[0].Trim());

        foreach (string line in lines.Skip(1))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            // FIX: First, split the goal type away from the data using the colon ':'
            string[] typeAndData = line.Split(':');
            string goalType = typeAndData[0].Trim();

            // The rest of the string contains all the data fields separated by '|'
            string dataFields = typeAndData[1];
            string[] parts = dataFields.Split('|');

            switch (goalType)
            {
                case "SimpleGoal":
                    {
                        SimpleGoal simpleGoal = new SimpleGoal("", "", 0);
                        simpleGoal.SetName(parts[0].Trim());
                        simpleGoal.SetDesciption(parts[1].Trim());
                        simpleGoal.SetPoint(int.Parse(parts[2].Trim()));
                        simpleGoal.SetIsComplete(bool.Parse(parts[3].Trim()));

                        _goals.Add(simpleGoal);
                        break;
                    }

                case "EternalGoal":
                    {
                        EternalGoal eternalGoal = new EternalGoal("", "", 0);
                        eternalGoal.SetName(parts[0].Trim());
                        eternalGoal.SetDesciption(parts[1].Trim());
                        eternalGoal.SetPoint(int.Parse(parts[2].Trim()));

                        _goals.Add(eternalGoal);
                        break;
                    }

                case "ChecklistGoal":
                    {
                        ChecklistGoal checklistGoal = new ChecklistGoal(0, 0, "", "", 0);
                        checklistGoal.SetName(parts[0].Trim());
                        checklistGoal.SetDesciption(parts[1].Trim());
                        checklistGoal.SetPoint(int.Parse(parts[2].Trim()));
                        checklistGoal.SetBonus(int.Parse(parts[3].Trim()));
                        checklistGoal.SetCompleted(int.Parse(parts[4].Trim()));
                        checklistGoal.SetTarget(int.Parse(parts[5].Trim()));

                        _goals.Add(checklistGoal);
                        break;
                    }
                default:
                    Console.WriteLine($"Unknown type: {goalType}");
                    break;
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }
}