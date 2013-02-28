using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sum: " + (new List<int> { 1, 2, 3 }).Sum<int>());
        //Console.WriteLine("Min: " + (new List<String> { "1", "2", "3", "4" }).Min<String>());
        Console.WriteLine("Min: " + (new List<int> { 1, 2, -3, 4 }).Min<int>());
        Console.WriteLine("Max: " + (new List<int> { 10, 2, -3, 4 }).Max<int>());
        Console.WriteLine("Product: " + (new List<double> { 1, 2, 3, 4 }).Product<double>());
        Console.WriteLine("Average: " + (new List<double> { 1, 2, 3, 4.6 }).Average<double>());
    }
}
