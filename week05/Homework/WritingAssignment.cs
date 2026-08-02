// This class will inherit from Assignment and add writing title

using System;

public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor that passes name and topic to the base constructor
    public WritingAssignment(string studentName, string topic, string title) 
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method to return writing info with author name
    public string GetWritingInformation()
    {
        // Using base.GetStudentName() because the variable is private in parent
        return $"{_title} by {base.GetStudentName()}";
    }
}
