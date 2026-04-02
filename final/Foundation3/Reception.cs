using System;

class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail): base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    protected override string GetEventType()
    {
        return "Reception";
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() +
               "\nType: " + GetEventType() +
               "\nRSVP Email: " + rsvpEmail;
    }

    public override string GetShortDescription()
    {
        return "Type: " + GetEventType() +
               "\nTitle: " + GetTitle() +
               "\nDate: " + GetDate();
    }
}