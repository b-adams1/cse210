using System;

class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity): base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    protected override string GetEventType()
    {
        return "Lecture";
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() +
               "\nType: " + GetEventType() +
               "\nSpeaker: " + speaker +
               "\nCapacity: " + capacity;
    }

    public override string GetShortDescription()
    {
        return "Type: " + GetEventType() +
               "\nTitle: " + GetTitle() +
               "\nDate: " + GetDate();
    }
}