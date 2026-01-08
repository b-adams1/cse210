using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradePercent = Console.ReadLine();
        int gradeInt = int.Parse(gradePercent);
        string letter = "";
        if (gradeInt >= 90)
        {
            letter = "A";
        }
        else if (gradeInt >= 80)
        {
            letter = "B";
        }
        else if (gradeInt >= 70)
        {
            letter = "C";
        }
        else if (gradeInt >= 60)
        {
            letter = "D";
        }
        else if (gradeInt < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass, keep working!");
        }
    }
}