using System;

//MathAssignment inheriting the whole of the Assignment class including its attributes and methods
//Inheritance occurs in the child class using the colon ":"
public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    //using the base keyword to call the assignment constructor and inherit its parameters
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{GetStudentName()} {GetTopic()} {_textbookSection} - {_problems}";
    }
}

