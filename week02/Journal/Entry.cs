using System;

//creating class is creating custom data type that can contains data types of int, string, methods etc
//class is like a template to hold int, strings, functions etc, which we can later pass values to them or call the function in instances
//This is a public class Entry syntax
public class Entry
{
    //this Entry class stores input from Program.cs
    //declaring member variables
    public string _date;
    public string _time;
    public string _promptText;
    public string _entryText;

    //the display method
    public void Display()
    {
        Console.WriteLine($"Date: {_date} {_time} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
}

