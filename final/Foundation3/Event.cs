using System;

class Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address;

    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return "Title: " + title +
               "\nDescription: " + description +
               "\nDate: " + date +
               "\nTime: " + time +
               "\nAddress: " + address.GetFullAddress();
    }

    protected string GetTitle()
    {
        return title;
    }

    protected string GetDate()
    {
        return date;
    }

    protected virtual string GetEventType()
    {
        return "Event";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails() +
               "\nType: " + GetEventType();
    }

    public virtual string GetShortDescription()
    {
        return "Type: " + GetEventType() +
               "\nTitle: " + title +
               "\nDate: " + date;
    }
}