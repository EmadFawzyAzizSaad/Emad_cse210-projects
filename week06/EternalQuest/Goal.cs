// Base abstract class for all types of goals
// we use abstract because parent dont know how to compute code inside record event
using System;

public abstract class Goal
{
    // private variables for safety and matching with Naming Conventions
    private string _shortName;
    private string _description;
    private int _points; // change to int for easy math calculation

    // Constructor to set up the basic goal data
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Getters for childern classes to read variables privatli
    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    // Abstract methods that child classes MUST override and implement later
    public abstract void RecordEvent();
    public abstract bool IsComplete();

    // Virtual method that can be overridden if needed, or used as default
    public virtual string GetDetailsString()
    {
        // if completed print X, if not print empty space
        string statusSymbol = IsComplete() ? "X" : " ";
        return $"[{statusSymbol}] {_shortName} ({_description})";
    }

    // Method to format data for saving to a file text
    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}:{_description}:{_points}";
    }
}
