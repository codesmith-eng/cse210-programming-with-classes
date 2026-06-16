//base class 
using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    //inheriting the color from the base class constructor
    public Rectangle(double length, double width, string color) : base(color)
    {
        _length = length;
        _width = width;
    }

    //overridden inherited GetArea method from the base class
    public override double GetArea()
    {
        return _length * _width;
    }
}