using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction sample = new Fraction();

        Console.WriteLine(sample.GetFractionString());
        Console.WriteLine(sample.GetDecimalValue());

        sample.SetTop(5);
        Console.WriteLine(sample.GetFractionString());
        Console.WriteLine(sample.GetDecimalValue());

        sample.SetTop(3);
        sample.SetBottom(4);
        Console.WriteLine(sample.GetFractionString());
        Console.WriteLine(sample.GetDecimalValue());

        sample.SetTop(1);
        sample.SetBottom(3);
        Console.WriteLine(sample.GetFractionString());
        Console.WriteLine(sample.GetDecimalValue());
    }
}