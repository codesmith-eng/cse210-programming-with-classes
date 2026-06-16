//child or derive class
using System;

public class Square : Shape
{
    private double _side;

    //inheriting color from the base class constructor
    public Square(double side, string color): base(color)
    {
        _side = side;
    }

    //overridden GetArea method inherited from the base class
    public override double GetArea()
    {
        return _side * _side;
    }
}