//base class
using System;

public class Shape
{
    private string _color;

    //constructor 
    public Shape(string color)
    {
        _color = color;
    }

    //a virtual method that can be override in the derive or child class
    public virtual double GetArea()
    {
        //I returned anything because it can be override in the child class
        return 1;
    }

    //setter for color
    public void SetColor(string color)
    {
        
        _color = color;
    }

    //getter for color
    public string GetColor()
    {
        return _color;
    }
}



