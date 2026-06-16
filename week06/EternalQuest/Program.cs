using System;

//I EXCEED THE REQUIREMENT BY HELPING THE USER KEEP TRACK OF DAY HE DO THE ACTIVITY AND ALSO KEEP 
//TRACK OF THE TIME HE STARTS AND ENDS 
// I ALSO DID NOT ALLOW THE USER TO REPEAT A GOAL HE HAS COMPLETED IN THE SIMPLE AND CHECKLIST GOAL
class Program
{
    static void Main(string[] args)
    {
        //creating an instance of the goalmanager
        GoalManager goalManager = new GoalManager();

        int quit = 6;

        int theOption = 0;

        //importing the date time function to track the time the user start the activity
        DateTime theCurrentTime = DateTime.Now;

        string date = theCurrentTime.ToShortDateString();

        string time = theCurrentTime.ToShortTimeString();

        Console.WriteLine($"You did this activity today, which is {date}");
        Console.WriteLine($"You start this activity at {time}");

        while (theOption != quit)
        {
            //displaying the player score
            goalManager.DisplayPlayerInfo();


            //display the starting message
            goalManager.Start();

            Console.Write("Select a choice from the menu:  ");
            string option = Console.ReadLine();

            //converting user input to number
            theOption = int.Parse(option);




            //if user input is 1
            //creating new goal and it to the list
            if (theOption == 1)
            {
                //displaying the goal names
                goalManager.ListGoalNames();

                //creating goals
                goalManager.CreateGoal();
            }

            if (theOption == 2)
            {
                Console.WriteLine("\nThe goals are:");
                goalManager.ListGoalDetails();
            }

            if (theOption == 3)
            {
                goalManager.SaveGoals();
            }

            if (theOption == 4)
            {
                goalManager.LoadGoals();
            }

            if (theOption == 5)
            {
                goalManager.RecordEvent();
            }
        }

        Console.WriteLine("Thanks for using the Goal Program, Have a Nice Day\n");
        Console.WriteLine($"You finished this activity at {time}");

    }
}