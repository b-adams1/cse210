using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;

    public Activity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine(_activityDescription);
        Console.Write("\nHow long, in seconds, would you like for your session? ");

        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

        Console.WriteLine("\nPrepare to begin...");
        PauseSpinner(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("\nWell done!");
        PauseSpinner(3);

        Console.WriteLine($"You have completed the {_activityName} Activity for {_activityDuration} seconds.");
        PauseSpinner(3);
    }

    public void PauseSpinner(int seconds)
    {
        List<string> spinner = new List<string> { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;
            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }

    public int GetDuration()
    {
        return _activityDuration;
    }

    public void SetDuration(int duration)
    {
        _activityDuration = duration;
    }

    public string GetRandomPrompt(List<string> list)
    {
        Random rand = new Random();
        int index = rand.Next(list.Count);
        return list[index];
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"\n{prompt}");
    }
}