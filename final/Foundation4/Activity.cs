using System;

// Base class
abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // public DateTime Date => _date;
    // public int Minutes => _minutes;

    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public void SetMinutes(int minutes)
    {
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();


    public string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} {GetType().Name} ({GetMinutes()} min): " +
               $"Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, " +
               $"Pace {GetPace():F2} min per mile";
    }
}