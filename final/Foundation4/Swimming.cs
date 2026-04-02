using System;

class Swimming : Activity
{
    private int laps;

    public Swimming(string date, int minutes, int laps): base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        double km = (((laps * 50) / 1000.0) * 0.62);
        return km;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    public override string GetTypeName()
    {
        return "Swimming";
    }
}