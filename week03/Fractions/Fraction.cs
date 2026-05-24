using System;


public class Fraction
{
    private int _top;
    private int _bottom;

    //  -------------------------------------------------------------------------------------------------
    //1st construtor with no parameter but has default values for member variables
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //2nd constructor with one parameter but has one default a value for a member variable
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    //third constructor with two parameters and no default value for member variables 
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // ------------------------------------------------------------------------------------
    //setting the setters that will pass values to the member variables.
    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // ---------------------------------------------------------------------------------------------
    //setting the getters that will get values from the member variables
    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    // ---------------------------------------------------------------------------------------------
    //creating methods that uses getters and setters from the private member variables 
    public void GetFractionString()
    {
        string first = GetTop().ToString();    
        string second = GetBottom().ToString();
        Console.WriteLine($"{first}/{second}");
    }

    public void GetDecimalValue()
    {
        double div = (double)GetTop() / (double)GetBottom();
        Console.WriteLine(div);
    
    }
}

