//derive class

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    //This function records event
    public override void RecordEvent()
    {
        // Eternal goals never expire or finish; they always award points
        Console.WriteLine($"Event recorded! You practiced your eternal goal: {GetName()}");
    }

    public override bool IsComplete()
    {
        return false;
    }

    //this method holds the format for saving to a file and for retrieving it
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()}|{GetDescription()}|{GetPoint()}";
    }
}