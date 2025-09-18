using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        int userNumber = -1;
        List<int> numberList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string stringUserNumber = Console.ReadLine();
            userNumber = int.Parse(stringUserNumber);
            if (userNumber != 0)
            {
                numberList.Add(userNumber);
            }
        }

        double listSum = 0;
        foreach (int number in numberList)
        {
            listSum += number;
        }

        Console.WriteLine($"The sum is: {listSum}");

        double listAverage = listSum / numberList.Count;
        Console.WriteLine($"The average is: {listAverage}");

        int largest = 0;
        foreach (int number in numberList)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");

        double smallestPositive = Single.PositiveInfinity;
        foreach (int number in numberList)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        numberList.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numberList)
        {
            Console.WriteLine(number);
        }
        
    }
}