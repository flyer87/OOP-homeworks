using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] integers = new int[] { 12, 21, 36, 63 };

        /* Write a program that prints from given array of integers all numbers that are divisible by 7 and 3 
           With LAMBDA expr.
        */
        
        Console.WriteLine("Numbers that are divisible by 7 and 3: (lambda expr.) ");
        var res = integers.Where(x => (x % 3 == 0 && x % 7 == 0));
        foreach (var item in res)
        {
            Console.WriteLine(item);
        }
        

        /* Write a program that prints from given array of integers all numbers that are divisible by 7 and 3 
           With LINQ!
        */
        Console.WriteLine("Numbers that are divisible by 7 and 3: (LINQ) ");
        var result =
            from tempInt in integers
            where (tempInt % 3 == 0) && (tempInt % 7 == 0)
            select tempInt;

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

    }
}