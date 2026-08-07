// Management class to handle menu control, tracking, and files
using System;
using System.Collections.Generic; // important for the unified list

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>(); // Polymorphism list
    private int _score;

    // Constructor initializing starting score
    public GoalManager()
    {
        _score = 0;
    }

    // Menu and operation stubs for the control loop
    public void Start()
    {
        // stub empty body
    }

    public void DisplayPlayerInfo()
    {
        // stub empty body
    }

    public void ListGoalNames()
    {
        // stub empty body
    }

    public void ListGoalDetails()
    {
        // stub empty body
    }

    public void CreateGoal()
    {
        // stub empty body
    }

    public void RecordEvent()
    {
        // stub empty body
    }

    public void SaveGoals()
    {
        // stub empty body
    }

    public void LoadGoals()
    {
        // stub empty body
    }
}
