using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int num = PromptUserNumber();

        int birthYear;
        PromtUserBirthYear(out birthYear);

        int squ = SquareNumber(num);

        DisplayResult(name, squ, birthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program! ");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numStr = Console.ReadLine();
        int favNum = int.Parse(numStr);
        return favNum;
    }
    static void PromtUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter your birth year: ");
        birthYear = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int favNum)
    {
        int square = favNum * favNum;
        return square;
    }
    static void DisplayResult(string name, int squ, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {squ}");
        Console.WriteLine($"{name}, you will turn {2026 - birthYear} this year");
    }
}