using System;

public abstract class Activity
{
    // Encapsulation: private variables with underscore
    private string _date;
    private int _minutes;

    // Constructor to set up the shared data
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // getter for GetMinutes
    public int GetMinutes()
    {
        return _minutes;
    }


    // Abstract methods: No body {}, child classes MUST implement these
    public abstract double GetDistance();


    public abstract double GetSpeed();


    public abstract double GetPace();



    // Virtual method for the summary 
    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min): Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}