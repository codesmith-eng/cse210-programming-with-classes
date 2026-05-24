using System;

//I exceed the requirement by adding date method to help the user know the day he/she is using the scripture memorizer 
class Program
{

    static void Main(string[] args)
    {

        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();


        //creating a scripture reference
        Reference reference = new Reference("John", 3, 16, 17);

        //create scripture object and passing the text of the scripture as a parameter
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life");

        //keep running until all words are hidden using iscompletelyhidden method
        while (true)
        {
            //clear the screen first
            Console.Clear();

            //show scripture using GetDisplayText method
            Console.WriteLine($"{date} - {scripture.GetDisplayText()}");

            //displaying to screen
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish");
            string userInput = Console.ReadLine();

            //stop program if user types quit
            if (userInput.ToLower() == "quit")
            {
                //using break statement to break out of the program
                break;
            }

            //  CRITICAL CHECK: If everything is hidden, break out of the program
            else if (scripture.IsCompletelyHidden())
            {
                break;
            }

            //Hide random words if enter is pressed
            scripture.HideRandomWords(2);
        }

        //message to display if the program ends
        Console.WriteLine("Thanks for using the scripture memorizer");
    }
}