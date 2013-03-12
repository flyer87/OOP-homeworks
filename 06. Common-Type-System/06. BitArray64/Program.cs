using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        BitArray64 number = new BitArray64(long.MaxValue);

        // test [] (indexer)
        Console.WriteLine("Test []: ");
        Console.WriteLine("number [{0}] : {1}", 16, number[16]);
        //Console.WriteLine(number[64]); - throws exception
        
 
        // test IEnumerable
        Console.WriteLine();
        Console.WriteLine("Test IEnumerable: ");
        int i = 0;
        foreach (var item in number)
        {
            Console.WriteLine(i + " = " + item);
            i++;
        }

        // test Equals
        Console.WriteLine();
        Console.WriteLine("Test Equals(): ");
        BitArray64 number2 = new BitArray64(5);
        Console.WriteLine(number.Equals(number2));

        // test !=
        Console.WriteLine();
        Console.WriteLine("Test != ");
        Console.WriteLine(number != number2);

        // test GetHashCode()
        Console.WriteLine();
        Console.WriteLine("Test GetHasCode()");
        Console.WriteLine(number2.GetHashCode());
        Console.WriteLine(number.GetHashCode());
    }
}