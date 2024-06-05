using System;

public class Reception : Event
{
    private  string _emailRSVP;

    public Reception(string title, string description, string date, string time, Address address, string RSVP) 
        : base(title, description, date, time, address)
    {
        _emailRSVP = RSVP;
    }

    public string GetFullDetails()
    {
        return $"Type: {GetType().Name}\n{GetStandardDetails()}\nRSVP Email: {_emailRSVP}";
    }

    public string GetShortDescription()
    {
         return $"Reception | {_eventTitle} | {_date}";
    }
}