using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(4, "blue");
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());
        // Console.WriteLine();


        Rectangle rectangle = new Rectangle(5, 5, "Red");
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());
        // Console.WriteLine();


        Circle circle = new Circle(5, "Brown");
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();

        //adding the instances to the list 
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        //looping through the list to display the color and area of all the instances once
        foreach(Shape shape in shapes)
        {   
           Console.WriteLine(shape.GetColor());
           Console.WriteLine(shape.GetArea());
           Console.WriteLine();
        }

        //or (both loop are the same )

        //if we want to keep track of the Getcolor() and GetArea()
        foreach(Shape shape in shapes)
        {   
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine(color);
            Console.WriteLine(area);
            Console.WriteLine();
        }
    }
}