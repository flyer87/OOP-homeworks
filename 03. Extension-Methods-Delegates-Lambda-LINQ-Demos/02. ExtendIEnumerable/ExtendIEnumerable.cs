using System;
using System.Collections.Generic;

static class ExtendIEnumerable
{
    public static dynamic Sum<T>(this IEnumerable<T> items) 
        where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        dynamic sum = 0;
        foreach (var item in items)
        {
            sum += item;
        }

        return sum;
    }

    public static T Product<T>(this IEnumerable<T> items)
        where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        dynamic prod = 1;
        foreach (var item in items)
        {
            prod *= item;
        }

        return prod;
    }

    public static T Min<T>(this IEnumerable<T> items)
        where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        dynamic min = Int32.MaxValue;
        foreach (var item in items)
        {
            if (item.CompareTo(min) < 0)
            {
                min = item;
            }
        }

        return min;
    }


    public static T Max<T>(this IEnumerable<T> items)
        where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        dynamic max = Int32.MinValue;
        foreach (var item in items)
        {
            if (item > max)
            {
                max = item;
            }
        }

        return max;
    }

    public static T Average<T>(this IEnumerable<T> items)
        where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        int counter = 0;
        dynamic sum = 0;
        foreach (var item in items)
        {
            sum += item;
            counter++;
        }

        return sum / counter;
    }
}