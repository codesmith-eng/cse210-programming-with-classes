using System;

//I EXCEED THE REQUIREMENT BY ADDING THE DATE AND TIME THE USER START AND ENDS THE ACTIVITY
class Program
{
    static void Main(string[] args)
    {

        //creating an instance of the breathing activity
        BreathingActivity breathingActivity = new BreathingActivity("Welcome to the Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");

        //creating an instance of the reflectingactivity
        ReflectingActivity reflectingActivity = new ReflectingActivity("Welcome to the Reflecting Activity",
         "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        int quit = 4;
        
        //creating an instance of the listingactivity
        ListingActivity listingActivity = new ListingActivity("Welcome to the Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        int theOption = 0; //initializing the option to zero first to take me into the loop

        Console.WriteLine("Welcome to the Breathing, Reflecting, and Listing Activity");
        Console.Write("This Activity is Going to Help you Breath well, Reflect and List your thoughts\n");
        
        //importing the date time function to track the time the user start the activity
        DateTime theCurrentTime = DateTime.Now;

        string date = theCurrentTime.ToShortDateString();
        
        Console.WriteLine($"Todays date is {date}\n");


        while (theOption != quit)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("     1. Start breathing activity");
            Console.WriteLine("     2. Start reflecting activity");
            Console.WriteLine("     3. Start listing activity");
            Console.WriteLine("     4. Quit");

            Console.Write("Select a choice from the menu:  ");
            string option = Console.ReadLine();

            theOption = int.Parse(option);

            //if the option is breathingactivity
            if (theOption == 1)
            {

                breathingActivity.Run();
            }

            if (theOption == 2)
            {
                reflectingActivity.Run();
            }

            if (theOption == 3)
            {
                listingActivity.Run();
            }
        }

        Console.WriteLine("Thanks for using this program");
    }
}