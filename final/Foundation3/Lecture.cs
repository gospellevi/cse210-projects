using System;
using System.Collections.Generic;
using System.Linq;

public class Lecture : Event
{
    private string _speakerName;
    private int _attendance;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int attendance) 
        : base(title, description, date, time, address)
    {
        _speakerName = speaker;
        _attendance = attendance;
    }

    public string GetFullDetails()
    {
        // return $"Type: Lecture\n{GetStandardDetails()}\nSpeaker: {_speakerName}\nCapacity: {_attendance} participants";
        return $"Type: {GetType().Name}\n{GetStandardDetails()}\nSpeaker: {_speakerName}\nCapacity: {_attendance} participants";

    }

    public string GetShortDescription()
    {
        // return base.GetShortDescription();
        return $"Lecture | {_eventTitle} | {_date}";
    }




}