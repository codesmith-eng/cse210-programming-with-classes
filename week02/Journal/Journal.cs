using System;

//creating class is creating custom data type that can contains data types of int, string, methods etc
//class is like a template to hold int, strings, functions etc, which we can later pass values to them or call the function in instances
//This is a public class Entry syntax
public class Journal
{

    public List<Entry> _entryList = new List<Entry>();

    public void DisplayList()
    {
        //iterating through the list in Entry class and calling the display method in the entry class
        foreach (Entry listEntries in _entryList)
        {
            listEntries.Display();
        }
    }


    //creating a new variable called "promptGenerator" from PromptGenerator class
    PromptGenerator promptGenerator = new PromptGenerator();


    //This function add new entry to the entry list
    public void AddEntry()
    {
        //creating a new template named entry from the Entry class template
        Entry entry = new Entry();

        //Using the datetime format to get the current date of input and storing it in the member variable called entry._date
        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();

        //Using the datetime format to get the current time of input and storing it in the member variable called entry._time
        entry._time = theCurrentTime.ToShortTimeString();

        //getting the random prompt from the GetRandomPrompt method in the PromptGenerator class 
        // and storing the random prompt in a variable called prompt
        string prompt = promptGenerator.GetRandomPrompt();

        //putting the prompt text in the entry._promptText member variable
        entry._promptText = prompt;

        //using the prompt to ask user and putting the response into the entry._Text member variable
        Console.WriteLine(entry._promptText);
        entry._entryText = Console.ReadLine();

        _entryList.Add(entry);
    }



    //This function write user entries to file
    public void SaveToFile()
    {
        //Asking user the name to save the file with
        Console.WriteLine("Enter Journal Name? ");
        string fileName = Console.ReadLine();

        Console.WriteLine("Your journal has been saved with date and time");

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {

            //for loop to iterate and write the file to text
            foreach (Entry allOfList in _entryList)
            {

                // You can add text to the file with the WriteLine method
                //writing the file with comma so that it can be splitted into three part and can be loaded
                outputFile.WriteLine($"{allOfList._date}|{allOfList._time}|{allOfList._promptText}|{allOfList._entryText}");
            }
        }

        Console.WriteLine();
    }



    //This function loads user entries from file
    public void LoadFromFile()
    {
        Console.WriteLine("Enter the name of the file? ");
        string fileName = Console.ReadLine();

        //using the system.io.file.readalllines to read files into array of strings
        string[] lines = System.IO.File.ReadAllLines(fileName);

        //clearing the journal entry list so that i can load new one to the list 
        _entryList.Clear();

        foreach (string line in lines)
        {

            string[] parts = line.Split("|");


            //creating new entry template from the Entry class
            Entry entry = new Entry();

            entry._date = parts[0];
            entry._time = parts[1];
            entry._promptText = parts[2];
            entry._entryText = parts[3];

            //add the loaded entry to the _entry list in the journal 
            _entryList.Add(entry);

        }
    }
}