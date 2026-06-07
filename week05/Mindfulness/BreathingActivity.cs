using System;

//breathingactivity inheriting from the base class "Activity"
public class BreathingActivity : Activity
{
    //constructor for breathingactivity, no member variable is need it inherit all its member variable from the base class
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        //----------COUNTDOWNS FOR BREATHING IN AND OUT-------------------------

        int startTime = 0;

        //as long as startTime is less than showcountdown(), keep counting
        //Breath in and breath out will count for 4 seconds each till it reach the seconds the user specify
        //if the user specify 30 seconds, breath in and breath out will count for 4 seconds each till the counting reach 30
        while (startTime < ShowCountDown())
        {
            //This loop says count from 4 to 1
            Console.Write("Breath In....");
            for (int i = 4; i > 0 && startTime < ShowCountDown(); i--) //As long a startTime is less than ShowCountDown
            {
                Console.Write(i);
                Thread.Sleep(1000); //pause for one seconds before counting down
                Console.Write("\b \b");

                startTime++; //incrementing the counting of startTime as the loop count, once the loop count to 30, it stops
            }

            Console.WriteLine();

            Console.Write("Breath Out....");
            for (int i = 4; i > 0 && startTime < ShowCountDown(); i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");

                startTime++;
            }

            Console.WriteLine("\n");
        }

        DisplayEndingMessage();
        Console.WriteLine($"You have completed {ShowCountDown()} seconds of Breathing Activity");
        ShowSpinner();


        //importing the date time function to track the time the user end the activity
        DateTime theCurrentTime = DateTime.Now;
        string time = theCurrentTime.ToShortTimeString();

        Console.WriteLine($"You finished this activity at {time}");
        
        Console.WriteLine();
    }
}