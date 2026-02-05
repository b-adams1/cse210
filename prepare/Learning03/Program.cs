using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(6);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Random random = new Random();
        Fraction f4 = new Fraction();
        for (int i = 0; i < 25; i++)
        {
            int topValue = random.Next(1, 11);
            int bottomValue = random.Next(1, 11);
            f4.SetTop(topValue);
            f4.SetBottom(bottomValue);
            Console.Write($"Fraction {i+1}: ");
            Console.Write($"String: {f4.GetFractionString()} ");
            Console.WriteLine($"Decimal: {f4.GetDecimalValue()}");
        }
    }
}