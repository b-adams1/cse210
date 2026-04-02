using System;

class OutdoorGathering : Event
{
    private string weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather): base(title, description, date, time, address)
    {
        this.weather = weather;
    }

    protected override string GetEventType()
    {
        return "Outdoor Gathering";
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() +
               "\nType: " + GetEventType() +
               "\nWeather: " + weather;
    }

    public override string GetShortDescription()
    {
        return "Type: " + GetEventType() +
               "\nTitle: " + GetTitle() +
               "\nDate: " + GetDate();
    }
}