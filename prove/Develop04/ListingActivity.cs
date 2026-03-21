using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _userCounter;
    private List<string> _promptsListListing;

    public ListingActivity() 
        : base("Listing", "This activity helps you list positive things in your life. List as many responses as you can!")
    {
        _promptsListListing = new List<string>
        {
            "When have you felt the Holy Ghost this month?",
            "Who are people that you appreciate?",
            "What are your personal strengths?",
            "Who have you helped this week?",
            "When have you felt peace recently?",
            "Who are some of your personal heroes?",
            "What are things that make you smile?",
            "What are things you are grateful for today?",
            "What are activities that help you relax?",
            "What are goals you are working toward?",
            "What are things you enjoy doing in your free time?",
            "What are positive habits you have developed?",
            "Who are people that have influenced you for good?",
            "What are things you are looking forward to?",
            "What are small wins you have had recently?",
            "What are things that bring you comfort?",
        };
    }

    public void Run()
    {
        StartMessage();

        string prompt = GetRandomPrompt(_promptsListListing);
        DisplayPrompt(prompt);

        Console.WriteLine("\nYou may begin in:");
        Countdown(5);

        List<string> responses = GetListFromUser();

        Console.WriteLine($"\nYou listed {responses.Count} items!");

        EndMessage();
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                items.Add(input);
                _userCounter++;
            }
        }

        return items;
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}