using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int magicInt = number;
        int guessInt = -1;

        while (magicInt != guessInt)
        {
            Console.WriteLine("What is your guess? ");
            string numberGuess = Console.ReadLine();
            guessInt = int.Parse(numberGuess);
            if (magicInt == guessInt)
            {
                Console.WriteLine("You guessed it! ");
            }
            else if (magicInt < guessInt)
            {
                Console.WriteLine("Lower ");
            }
            else if (magicInt > guessInt)
            {
                Console.WriteLine("Higher ");
            }
        }
    }
}