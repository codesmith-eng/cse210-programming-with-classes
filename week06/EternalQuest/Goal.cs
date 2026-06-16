//base class
using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    //this code display to the user if the user has fulfilled it or not
    public virtual string GetDetailsString()
    {
        //Iscomplete will determine to display [x] or []
        string checkBox = IsComplete() ? "[X]" : "[ ]";

        return $"{checkBox} {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();


    //getters and setters for the base class
    //getter for name
    public string GetName()
    {
        return _shortName;
    }

    //setter for name 
    public void SetName(string name)
    {
        _shortName = name;
    }

    //getter for description
    public string GetDescription()
    {
        return _description;
    }

    //setter for description 
    public void SetDesciption(string description)
    {
        _description = description;
    }

    //getter for points
    public int GetPoint()
    {
        return _points;
    }

    //setter for points 
    public void SetPoint(int points)
    {
        _points = points;
    }

}