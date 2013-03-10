using System;
using System.Collections.Generic;

class InvalidRangeException<T> : ApplicationException
{
    private T min;
    private T max;

    public InvalidRangeException(T min, T max)
    {
        Console.WriteLine("Value out or range [ " + min + ", " + max + " ]");
    }
}