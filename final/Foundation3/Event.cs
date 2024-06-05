using System;

public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        // return $"Event Title : {_eventTitle}\nDescription : {_description}\nDate: {_date}\nTime: {_time}\nAddress : {_address.DisplayStreetAddress()}";
        return $"{_eventTitle} - {_description}\n{_date} @ {_time}\n{_address.DisplayStreetAddress()}"; 

    }  

    // public string GetShortDescription()
    // {
    //     return $"Type: Event\nTitle: {_eventTitle}\nDate: {_date}";
    // }
}