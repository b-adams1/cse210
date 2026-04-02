using System;

class Activity
{
    private string date;
    private int minutes;

    public Activity(string date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public string GetDate()
    {
        return date;
    }

    public int GetMinutes()
    {
        return minutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetTypeName()
    {
        return "Activity";
    }

    public string GetSummary()
    {
        return GetDate() + " " + GetTypeName() + " (" + GetMinutes() + " min) - Distance " + GetDistance().ToString("0.0") + " miles, Speed " + GetSpeed().ToString("0.0") + " mph, Pace: " + GetPace().ToString("0.0") + " min per mile";
    }
}