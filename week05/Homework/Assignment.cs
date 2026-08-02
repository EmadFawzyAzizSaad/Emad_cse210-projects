// This class will be responsible for the general assignment data: name and topic

using System;

public class Assignment
{
    // private variables for safety
    private string _studentName;
    private string _topic;

    // Constructor to initialize the values
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Getter: for student name to help the child classes access it later
    public string GetStudentName()
    {
        return _studentName;
    }

    // Method to return the summary text
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
