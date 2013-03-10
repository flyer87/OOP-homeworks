using System;
using System.Collections.Generic;

class Program
{
    static void CheckNumber()
    {
        int min = 0;
        int max = 100;
        Console.Write("Enter an integer: ");
        int temp = Int32.Parse(Console.ReadLine());
        if (temp < 0 || temp > 100)
        {
            throw new InvalidRangeException<int>(min, max);
        }
    }

    static void CheckDate()
    {
        DateTime minDate = DateTime.Parse("01.01.1980");
        DateTime maxDate = DateTime.Parse("31.12.2013 23:59:59");

        Console.Write("Enter date: ");
        DateTime temp = DateTime.Parse(Console.ReadLine());

        if (temp < minDate || temp > maxDate)
        {
            throw new InvalidRangeException<DateTime>(minDate, maxDate);
        }
    }

    static void Main(string[] args)
    {
        CheckNumber();
        CheckDate();
    }
}
