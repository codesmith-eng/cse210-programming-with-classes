using System;


public class Activity
{
    private string _name;
    private string _description;
    private int _duration;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    //display starting message

    public void DisplayStartingMessage()
    {
        //importing the date time function to track the time the user start the activity
        DateTime theCurrentTime = DateTime.Now;

        string time = theCurrentTime.ToShortTimeString();

        

        Console.WriteLine(GetName()); //displaying the name of the activity

        //showing the date and time the user start the activity
        Console.WriteLine($"You start this activity at {time}");

        Console.WriteLine();

        Console.WriteLine(Getdescription()); //displaying the description of the activity

        Console.WriteLine();
        
        Console.Write("How long, in seconds would you like your session? "); //input from user
        string session = Console.ReadLine();

        int theSession = int.Parse(session); //converting user input to integer

        SetDuration(theSession);  //putting the user input in the duration setter from the base Activity class

        Console.WriteLine("Get ready...");
        ShowSpinner(); //displaying dot for 8seconds as animations
    }

    //getter for name
    public string GetName()
    {
        return _name;
    }

    //getter for description
    public string Getdescription()
    {
        return _description;
    }

    //getter for duration 
    public int GetDuration()
    {
        return _duration;
    }

    //setter for duration 
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    //End message for all classes
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(); //displaying animations
    }


    //This function count periods (.) for eight seconds 
    public void ShowSpinner(int seconds = 8)
    {

        //this loop count for eight seconds and displays the dot eight times 
        //the loop says start counting from 8 down to 1 as long as it is great than 0 
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000); //pause for one seconds before displaying the next dot
        }
        Console.WriteLine("\n");
    }

    public int ShowCountDown()
    {
        return GetDuration();
    }
}