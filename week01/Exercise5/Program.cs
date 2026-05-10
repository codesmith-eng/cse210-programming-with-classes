using System;

class Program
{
    static void Main(string[] args)
    {
        string Welcome = DisplayWelcome();
        Console.WriteLine(Welcome);

        string theName = PromptUserName();

        int num = PromptUserNumber();

        int numberOf = SquareNumber(num);

        //Converting return value of SquareNumber to string so that i can pass it as parameter to Display result function
        string numberString = numberOf.ToString();

        //passing parameters into Display function
        DisplayResult(theName, numberString);

    }

    static string DisplayWelcome()
    {
        string Display = "Welcome to the Program";
        return Display;
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name? ");
        string myName = Console.ReadLine();
        return myName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number? ");
        string myNumber = Console.ReadLine();

        int theNumber = int.Parse(myNumber);
        return theNumber;
    }

    static int SquareNumber(int number)
    {
        int squa = number * number;
        return squa;
    }

    static void DisplayResult(string name, string squareRoot)
    {
        Console.WriteLine($"{name}, the square root of your number is {squareRoot}");
    }
}