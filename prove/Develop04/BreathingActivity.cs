using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on breathing.")
    {
    }

    public void Run()
    {
        StartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            Countdown(4);

            Console.Write("\nBreathe out... ");
            Countdown(4);
        }

        EndMessage();
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}