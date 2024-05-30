using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {_shortName} - {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal;{_shortName};{_description};{_points};{_isComplete}";
    }
}

// using System;

// public class SimpleGoal : Goal
// {
//     private bool _isComplete;

//     public SimpleGoal(string name, string description, int points) : base(name, description, points)
//     {
//         _isComplete = false;
//     }

//     public override int RecordEvent() 
//     {
//         if (!_isComplete)
//         {
//             _isComplete = true;
//             return _points;
//         }
//         return 0;
//     }
//     public override bool IsComplete() { return _isComplete; }
//     public override string GetStringRepresentation() 
//     {
//         return $"SimpleGoal: {_shortName}, {_description}, {_points}, {_isComplete}";
//     }
// }