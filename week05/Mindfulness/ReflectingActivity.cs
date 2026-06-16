using System;


public class ReflectingActivity : Activity
{
    //initializing the prompts list 
    private List<String> _prompts = new List<String>
    {
        "--Think of a time when you stood up for someone else.",
        "--Think of a time when you did something really difficult.",
        "--Think of a time when you helped someone in need.",
        "--Think of a time when you did something truly selfless."
    };

    private List<String> _questions = new List<String>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    //ReflectingActivity inheriting name and description from the base class
    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:\n");

        //displaying the prompt text 
        DisplayPrompt();

        //Asking user to press enter
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string pressEnter = Console.ReadLine();

        Console.WriteLine("Now Ponder on each of the following questions as they related to this experience");

        //This loop says count from 5 to 1
        Console.Write("You may begin in...");
        for (int i = 5; i > 0; i--) // this loop count from 5 to 1
        {
            Console.Write(i);
            Thread.Sleep(1000); //pause for one seconds before counting down
            Console.Write("\b \b");
        }

        //clearing the console
        Console.Clear();

        int startTime = 0;

        //as long as startTime is less than showcountdown(), start counting
        //if the user specify 30 seconds of reflecting activity, the prompt will continue generating till its 30 seconds
        while (startTime < ShowCountDown())
        {
            DisplayQuestions();
            ShowSpinner();

            startTime += 8; //
        }

        //end message
        DisplayEndingMessage();
        Console.WriteLine($"You have completed {ShowCountDown()} seconds of Reflecting Activity");

        ShowSpinner();


        //importing the date time function to track the time the user end the activity
        DateTime theCurrentTime = DateTime.Now;
        string time = theCurrentTime.ToShortTimeString();

        Console.WriteLine($"You finished this activity at {time}");
        Console.WriteLine();
    }

    //this method randomly picks one of the prompt from the prompt list and returns it 
    public string GetRandomPrompt()
    {

        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }

    //this function randomly picks one of the questions prompt and returns it
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);

        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
    }

    public void DisplayQuestions()
    {
        Console.Write(GetRandomQuestion());

    }
}