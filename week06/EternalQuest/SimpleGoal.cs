//derive class
using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    // Handles recording a simple goal event
    public override void RecordEvent()
    {
        // A SimpleGoal only permits one recording event
        if (!_isComplete)
        {
            // Mark as finished
            _isComplete = true;
            Console.WriteLine($"Event recorded! You completed the goal: {GetName()}");
        }
        else
        {
            // Block repeat completion
            Console.WriteLine("This goal has already been completed.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    //the function holds the string in such a way that it is savable to a file and for retrieving it
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()}|{GetDescription()}|{GetPoint()}|{IsComplete()}";
    }

    //setter for iscomplete
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;

    }
}