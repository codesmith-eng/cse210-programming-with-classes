using System;


//using : to inherit attributes and methods from Assignment class
public class WritingAssignment : Assignment
{
    private string _title;

    //creating a constructor that inherit the attributes of the Assignment class which is the base class 
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{GetStudentName()} - {GetTopic()} - {_title}";
    }
}