using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //getter for studentName
    //I can neither create a getter or make the member variables protected instead of private
    //protected member variables are accessible to the base and derive class
    public string GetStudentName()
    {
        return _studentName;
    }

    //getter for topic
    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}

