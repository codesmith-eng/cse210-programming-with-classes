using System;


public class ListingActivity : Activity
{
    private int _count;
    private List<String> _prompts = new List<String>
    {
        "--Who are people that you appreciate?",
        "--What are personal strengths of yours?",
        "--Who are people that you have helped this week?",
        "--When have you felt the Holy Ghost this month?",
        "--Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    //create a new instance of List<String>
    List<String> _userInputs = new List<String>();



    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many response you can to the following prompt:");

        GetRandomPrompt();
        Console.WriteLine();

        //This loop says count from 5 to 1 for the user to get ready
        Console.Write("You may begin in...");
        for (int i = 5; i > 0; i--) // this loop count from 5 to 1
        {
            Console.Write(i);
            Thread.Sleep(1000); //pause for one seconds before counting down
            Console.Write("\b \b");
        }

        Console.WriteLine();

        //creating datetime instance and passing the user input(seconds) as parameter to the datetime function
        DateTime endTime = DateTime.Now.AddSeconds(ShowCountDown());

        //as long as the seconds entered is less than current time start counting down
        while (DateTime.Now < endTime)
        {

            Console.Write("> ");
            string inputUser = Console.ReadLine();

            _userInputs.Add(inputUser);


        }

        //Counting the content of the list 
        int countList = GetListFromUser().Count();

        //putting the counted number of input from user to the SetCount setter
        SetCount(countList);

        //Displaying the number of input from the user that is stored in a list
        Console.WriteLine($"You listed {GetCount()} items");

        Console.WriteLine();

        //end message
        DisplayEndingMessage();
        Console.WriteLine($"You have completed {ShowCountDown()} seconds of Listing Activity");
        ShowSpinner();


        //importing the date time function to track the time the user end the activity
        DateTime theCurrentTime = DateTime.Now;
        string time = theCurrentTime.ToShortTimeString();

        Console.WriteLine($"You finished this activity at {time}");
        Console.WriteLine();
    }



    //this function get random prompts from the list of _prompts in the member variable in this class
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }


    public List<string> GetListFromUser()
    {

        return _userInputs;
    }


    //getter for count 
    public int GetCount()
    {
        return _count;
    }


    //setter for duration 
    public void SetCount(int count)
    {
        _count = count;
    }
}