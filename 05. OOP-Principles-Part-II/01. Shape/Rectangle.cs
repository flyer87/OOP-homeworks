using System;
using System.Collections.Generic;

public class Rectangle : Shape
{
    // consctructor
    public Rectangle(double height, double width)
        : base(height, width)
    {
    }

    // methods
    public override double CalculateSurface()
    {
        return Height * Width;
    }
}
