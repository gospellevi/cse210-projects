using System;

// Derived class for eternal goals
public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points) 
    { 
         // No additional attributes needed for eternal goals
    }

    // Override methods from base class
    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never "complete"
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} - {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal;{_shortName};{_description};{_points}";
    }
}