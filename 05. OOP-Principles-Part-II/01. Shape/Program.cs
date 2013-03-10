using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        IEnumerable<Shape> shapes = new Shape[3]{
            new Circle(5),
            new Rectangle(6.4,6),
            new Triangle(4,5)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.CalculateSurface());
        }

    }
}
