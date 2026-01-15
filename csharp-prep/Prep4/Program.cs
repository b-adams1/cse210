using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished ");
        int numberInt = -1;
        while (numberInt != 0)
        {
            Console.Write("Enter your number: ");
            string numberStr = Console.ReadLine();
            numberInt = int.Parse(numberStr);
            numbers.Add(numberInt);
        }
        numbers.RemoveAt(numbers.Count - 1);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        int avg = sum / numbers.Count;
        Console.WriteLine($"The average is: {avg}");

        int largest = 0;
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is {largest}");
    }
}