//base class 
using System;

public class Circle : Shape
{
    private double _radius;

    //circle inheriting color from the base class
    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return (_radius * _radius) * 3.14159;
    }
}