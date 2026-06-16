//derive class
using System;
using System.Reflection.Metadata.Ecma335;

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(int target, int bonus, string name, string description, int points) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        // Verify if it was already complete to stop further increments
        if (IsComplete())
        {
            Console.WriteLine("This checklist goal is already completely finished!");
            return;
        }

        // Advance the internal counter
        _amountCompleted++;
        Console.WriteLine($"Event recorded! Progress for {GetName()}: {_amountCompleted}/{_target}");

        // Inform the user immediately if they hit the target milestone
        if (IsComplete())
        {
            Console.WriteLine($"Fantastic! You hit your target milestone and unlocked the bonus!");
        }
    }

    //method to calculate the completion status dynamically!
    public override bool IsComplete()
    {
        // If the amount we completed is greater than or equal to our target, 
        // this will return 'true'. Otherwise, it returns 'false'.
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    

    
    // This replaces the base method specifically for Checklist goals
    public override string GetDetailsString()
    {
        // conditional statement to check completion
        string checkBox = "[ ]";
        if (IsComplete())
        {
            checkBox = "[X]"; // Changes to X if amountCompleted >= target
        }

        // Returns the checkbox, the name, description, and the fraction count
        return $"{checkBox} {GetName()} ({GetDescription()}) -- Currently completed: {GetCompleted()}/{GetTarget()}";
    }



    //this method holds the format for saving to a file and for retrieving it
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()}|{GetDescription()}|{GetPoint()}|{GetBonus()}|{GetCompleted()}|{GetTarget()}";
    }

    //getter for target
    public int GetTarget()
    {
        return _target;
    }


    //setter for target 
    public void SetTarget(int target)
    {
        _target = target;
    }



    //getter for bonus
    public int GetBonus()
    {
        return _bonus;
    }



    //setter for bonus 
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }



    //getter for completed
    public int GetCompleted()
    {
        return _amountCompleted;
    }



    //setter for completed
    public void SetCompleted(int completed)
    {
        _amountCompleted = completed;
    }
}
