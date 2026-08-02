// This class will inherit from Assignment and add math section and problems

using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Constructor that passes name and topic to the base constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) 
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method to return math list details
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
