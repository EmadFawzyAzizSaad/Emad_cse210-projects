// Child class for one-time goals
using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    // Constructor passing data to the parent base constructor
    public SimpleGoal(string name, string description, string points) 
        : base(name, description, points)
    {
        _isComplete = false; // default value at birth
    }

    // Overriding the abstract methods with empty stubs for now
    public override void RecordEvent()
    {
        // stub empty body
    }

    public override bool IsComplete()
    {
        return false; // stub return
    }

    public override string GetDetailsString()
    {
        return ""; // stub return
    }

    public override string GetStringRepresentation()
    {
        return ""; // stub return
    }
}
