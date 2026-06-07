using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Moses Olagbami", "Software");

        Console.WriteLine(assignment.GetSummary());

        //using inheritance to creating an instance of assignment class
        MathAssignment assignment1 = new MathAssignment("Moses", "Software", "7-9", "84-90");
        Console.WriteLine(assignment1.GetHomeworkList());

        WritingAssignment assignment2 = new WritingAssignment("John", "Web", "Working with Json");
        Console.WriteLine(assignment2.GetWritingInformation());
    }
}