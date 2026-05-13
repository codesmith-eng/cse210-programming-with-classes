using System;

//creating class is creating custom data type that can contains data types of int, string, methods etc
//class is like a template to hold int, strings, functions etc, which we can later pass values to them or call the function in instances
//This is a public class Resume syntax
public class Resume
{
    //Declaring variables for the member class
    public string _name;

    //member variable for creating List and iniatilizing it to variable called _jobList
    public List<Job> _jobList = new List<Job>();

    //creating a method to display the name and content of the _jobList
    public void displayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //looping through the list "_jobList" to display it content
        foreach (Job ourJob in _jobList)
        {
            Console.WriteLine($"{ourJob._jobTitle} ({ourJob._company}) {ourJob._startYear}-{ourJob._endYear}");
        }
    }
}