/*I don't think there is any exceeding/comment that needs to be made, but just in case, I didn't really do any excess creativity except for the details on the exercises!
~ Thanks! ~*/ 

using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("16 Apr 2026", 60, 5.0));
        activities.Add(new Cycling("01 Apr 2020", 45, 12.0));
        activities.Add(new Swimming("27 Jul 2019", 30, 20));

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}