using System;
using System.Transactions;
using System.IO;
using System.Security;  //this system.io is mandatory if you want to save file as text

//I exceed the requirement by adding a new member variable named _time in the Entry class to store the 
//current time of the input so that the user can know the time the entries were made

class Program
{
    static void Main(string[] args)
    {
        int one = 1;
        int two = 2;
        int three = 3;
        int four = 4;
        int five = 5;
        int myChoice = 0;

        Console.WriteLine("Welcome to the Journal Program");
        Console.WriteLine("Please select one of the following choices");

        //creating a new template called journal from the Journal class
        Journal journal = new Journal();

        while (myChoice != five)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            //Asking user to pick a choice
            Console.Write("What would you like to do (Please enter a number)? ");
            string choice = Console.ReadLine();

            myChoice = int.Parse(choice);

            if (myChoice == one)
            {
                journal.AddEntry();
            }

            //the if statement to display all prompt text, entries and date
            else if (myChoice == two)
            {
                journal.DisplayList();
            }


            //if statement that writes to file
            else if (myChoice == three)
            {
                //calling the write to file function in the journal class
                journal.SaveToFile();
            }

            //the if statement that load from file
            else if (myChoice == four)
            {
                journal.LoadFromFile();
            }

        }

        //goodbye message after pressing five
        Console.WriteLine("Have a Nice Day");
    }
}