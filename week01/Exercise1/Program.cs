using System;

class Program
{
    //Basic input and output in C#
    static void Main(string[] args)
    {
        //Display with Console.Write first
        Console.Write("What is your first name? ");
        //Then define the data type and ask user input with Console.ReadLine
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your Name is {lastName}, {firstName} {lastName}.");
    }
}